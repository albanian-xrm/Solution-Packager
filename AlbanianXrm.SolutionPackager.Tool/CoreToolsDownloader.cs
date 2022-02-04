using AlbanianXrm.BackgroundWorker;
using AlbanianXrm.SolutionPackager.Properties;
using AlbanianXrm.XrmToolBox.Shared.Extensions;
using NuGet.Common;
using NuGet.Packaging;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager
{
    internal class CoreToolsDownloader
    {
        public const string coreToolsId = "Microsoft.CrmSdk.CoreTools";
        public const string solutionPackagerName = "SolutionPackager.exe";
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
            //ID of the package to be looked 
            string coreToolsId = "Microsoft.CrmSdk.CoreTools";

            string dir = GetToolDirectory();

            //Connect to the official package repository IPackageRepository
            ILogger logger = NullLogger.Instance;
            CancellationToken cancellationToken = CancellationToken.None;
            SourceCacheContext cache = new SourceCacheContext();

            SourceRepository repository = Repository.Factory.GetCoreV3(nugetSource);
            PackageSearchResource packageSearch = await repository.GetResourceAsync<PackageSearchResource>();
            FindPackageByIdResource findPackageById = await repository.GetResourceAsync<FindPackageByIdResource>();

            var metadata = (await packageSearch.SearchAsync(coreToolsId, new SearchFilter(false, SearchFilterType.IsLatestVersion), 0, 1, logger, cancellationToken)).FirstOrDefault();
            var version = (await metadata.GetVersionsAsync()).Max(v => v.Version);
        
            using (MemoryStream packageStream = new MemoryStream())
            {
                if (!await findPackageById.CopyNupkgToStreamAsync(
                     coreToolsId,
                     version,
                     packageStream,
                     cache,
                     logger,
                     cancellationToken))
                {
                    return string.Format(Resources.Culture, Resources.CORE_TOOLS_NOT_FOUND, coreToolsId, nugetSource);
                }

                using (PackageArchiveReader packageReader = new PackageArchiveReader(packageStream))
                {
                    foreach (var packageFile in await packageReader.GetFilesAsync(cancellationToken))
                    {

                        if (Path.GetFileName(Path.GetDirectoryName(packageFile)) == "coretools")
                        {
                            using (var fileStream = File.OpenWrite(Path.Combine(dir, Path.GetFileName(packageFile))))
                            using (var stream = await packageReader.GetStreamAsync(packageFile, cancellationToken))
                            {
                                await stream.CopyToAsync(fileStream);
                            }
                        }
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
    }
}
