using AlbanianXrm.BackgroundWorker;
using AlbanianXrm.SolutionPackager.Properties;
using AlbanianXrm.XrmToolBox.Shared.Extensions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlbanianXrm.SolutionPackager.Models;
using System.IO.Packaging;

namespace AlbanianXrm.SolutionPackager
{
    internal class CoreToolsDownloader
    {
        public const string coreToolsId = "Microsoft.CrmSdk.CoreTools";
        public const string solutionPackagerName = "SolutionPackager.exe";
        private const string NuGetURI = "https://api.nuget.org/v3/index.json";
        private readonly AlBackgroundWorkHandler backgroundWorkHandler;
        private readonly SolutionPackagerControl solutionPackagerControl;
        private readonly ToolViewModel toolViewModel;

        public CoreToolsDownloader(AlBackgroundWorkHandler backgroundWorkHandler, SolutionPackagerControl solutionPackagerControl, ToolViewModel toolViewModel)
        {
            this.backgroundWorkHandler = backgroundWorkHandler ?? throw new ArgumentNullException(nameof(backgroundWorkHandler));
            this.solutionPackagerControl = solutionPackagerControl ?? throw new ArgumentNullException(nameof(solutionPackagerControl));
            this.toolViewModel = toolViewModel ?? throw new ArgumentNullException(nameof(toolViewModel));
        }

        public void DownloadCoreTools(string nuGetFeed)
        {
            backgroundWorkHandler.EnqueueBackgroundWork(
                AlBackgroundWorkerFactory.NewAsyncWorker(DownloadCoreToolsAsync, nuGetFeed, DownloadCoreToolsCompleted)
                                         .WithViewModel(toolViewModel)
                                         .WithMessage(solutionPackagerControl, Resources.DOWNLOADING_CORE_TOOLS));
        }

        public static Version GetSolutionPackagerVersion()
        {
            return GetSolutionPackagerVersion(GetToolDirectory());
        }

        public static string GetToolDirectory()
        {
            string dir = Path.GetDirectoryName(typeof(CoreToolsDownloader).Assembly.Location).ToUpperInvariant();
            dir = Path.Combine(dir, coreToolsId);
            Directory.CreateDirectory(dir);
            return dir;
        }

        private static Version GetSolutionPackagerVersion(string dir)
        {
            FileInfo solutionPackager = new FileInfo(Path.Combine(dir, solutionPackagerName));
            return solutionPackager.Exists ?
                        new Version(FileVersionInfo.GetVersionInfo(solutionPackager.FullName).FileVersion) :
                        null;
        }

        public async Task<object> DownloadCoreToolsAsync(string nugetSource)
        {
            string dir = GetToolDirectory();

            //ID of the package to be looked 
            var nuGetFeed = new Uri(nugetSource ?? NuGetURI);
            NuGetSearch nuGetSearch = null;
            string version = null;

            if (nuGetFeed.IsFile)
            {
                var packages = Directory.GetFiles(nugetSource, coreToolsId + ".*.nupkg");
                version = packages.Select(package => Path.GetFileName(package))
                                  .Select((package) => package.Length >= 33 ? package.Substring(27, package.Length - 33) : "")
                                  .Where(v => Version.TryParse(v, out _))
                                  .OrderByDescending((v) => new Version(v))
                                  .FirstOrDefault();
            }
            else
            {
                nuGetSearch = await GetNuGetSearch(nuGetFeed);
                version = nuGetSearch.Data?.Find(package => package.Id == coreToolsId)?.Version;
            }

#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Version {version}");
#endif

            string localPackagePath = null;
            if (nuGetFeed.IsFile)
            {
                var packages = Directory.GetFiles(nugetSource, coreToolsId + ".*.nupkg");
                localPackagePath = packages.Select(package => Path.GetFileName(package))
                                           .Where((package) => package.Length >= 33 ? package.Substring(27, package.Length - 33) == version : false)
                                           .Select(package => Path.Combine(nugetSource, package))
                                           .FirstOrDefault();
            }
            else
            {
                if (nuGetSearch == null)
                {
                    nuGetSearch = await GetNuGetSearch(nuGetFeed);
                }
                var onlinePackageInfoPath = nuGetSearch.Data.Find(package => package.Id == coreToolsId).Versions.Find(v => v.Version == version)?.Id;
                string packageContent = null;
                if (onlinePackageInfoPath == null ||
                    (packageContent = await GetPackageContent(onlinePackageInfoPath)) == null ||
                    (localPackagePath = await DownloadNuGetPackage(packageContent)) == null)
                {
                    return string.Format(Resources.Culture, Resources.CORE_TOOLS_NOT_FOUND, coreToolsId, nugetSource);
                }

            }

            var packageInfo = new FileInfo(localPackagePath);
            using (var package = Package.Open(packageInfo.OpenRead()))
            {
                foreach (var part in package.GetParts())
                {
                    var path = part.Uri.ToString();

                    if (!path.StartsWith("/content/bin/coretools", StringComparison.InvariantCultureIgnoreCase)) continue;

                    var fileName = Path.GetFileName(path);


                    using (var fileStream = File.OpenWrite(Path.Combine(dir, fileName)))
                    using (var stream = part.GetStream())
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                }
            }
            return GetSolutionPackagerVersion(dir);
        }

        private void DownloadCoreToolsCompleted(string source, object value, Exception exception)
        {
            if (exception != null)
            {
                solutionPackagerControl.WriteErrorLog("The following error occured while downloading core tools: \r\n{0}", exception);
                MessageBox.Show(exception.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (value is string errorMessage)
            {
                MessageBox.Show(errorMessage, Resources.MBOX_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (value is Version version)
            {
                toolViewModel.SolutionPackagerVersion = version.ToString();
            }
        }

        private async Task<string> DownloadNuGetPackage(string packageContent)
        {
            var tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "AlbanianEarlyBound"));
            tempPath.Create();
            var fileInfo = new FileInfo(Path.Combine(tempPath.FullName, Path.GetFileName(packageContent)));
            var httpClient = new HttpClient { BaseAddress = new Uri(new Uri(packageContent).GetLeftPart(UriPartial.Authority)) };
            var stream = await httpClient.GetStreamAsync(packageContent);
            using (var fileStream = fileInfo.OpenWrite())
            {
                await stream.CopyToAsync(fileStream);
            }
            return fileInfo.FullName;
        }

        public async Task<string> GetPackageContent(string package)
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(new Uri(package).GetLeftPart(UriPartial.Authority)) };
            var stream = await httpClient.GetStreamAsync(package);
            using (var reader = new JsonTextReader(new StreamReader(stream)))
            {
                return (await JObject.LoadAsync(reader)).ToObject<NuGetPackage>().PackageContent;
            }
        }

        public async Task<NuGetSearch> GetNuGetSearch(Uri nuGetFeed)
        {
            var searchEndpoint = new Uri(await GetSearchEndpoint(nuGetFeed) + $"?q={coreToolsId}");
            var httpClient = new HttpClient { BaseAddress = new Uri(searchEndpoint.GetLeftPart(UriPartial.Authority)) };
            var stream = await httpClient.GetStreamAsync(searchEndpoint);
            using (var reader = new JsonTextReader(new StreamReader(stream)))
            {
                return (await JObject.LoadAsync(reader)).ToObject<NuGetSearch>();
            }
        }

        public async Task<string> GetSearchEndpoint(Uri nuGetFeed)
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(nuGetFeed.GetLeftPart(UriPartial.Authority)) };
            var stream = await httpClient.GetStreamAsync(nuGetFeed);

            NuGetApi nuGetApi = null;
            using (var reader = new JsonTextReader(new StreamReader(stream)))
            {
                nuGetApi = (await JObject.LoadAsync(reader)).ToObject<NuGetApi>();
            }
            return nuGetApi.Resources?.Find(resource => resource.type == "SearchQueryService")?.id;
        }
    }
}
