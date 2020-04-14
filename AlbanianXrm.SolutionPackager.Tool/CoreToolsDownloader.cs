﻿using AlbanianXrm.SolutionPackager.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace AlbanianXrm.SolutionPackager
{
    internal class CoreToolsDownloader
    {
        private const string coreToolsId = "Microsoft.CrmSdk.CoreTools";
        private const string solutionPackagerName = "SolutionPackager.exe";
        private readonly AsyncWorkQueue workQueue;
        private readonly RichTextBox txtCoreTools;

        public CoreToolsDownloader(AsyncWorkQueue workQueue, RichTextBox txtCoreTools)
        {
            this.workQueue = workQueue ?? throw new ArgumentNullException(nameof(workQueue));
            this.txtCoreTools = txtCoreTools ?? throw new ArgumentNullException(nameof(txtCoreTools));
        }

        public void DownloadCoreTools(string nuGetFeed)
        {
            workQueue.Enqueue(new WorkAsyncInfo
            {
                Message = Resources.DOWNLOADING_CORE_TOOLS,
                AsyncArgument = nuGetFeed,
                Work = DownloadCoreTools,
                PostWorkCallBack = DownloadCoreToolsCompleted
            });
        }

        public static Version GetSolutionPackagerVersion()
        {
            return GetSolutionPackagerVersion(GetToolDirectory());
        }

        private static string GetToolDirectory()
        {
            string dir = Path.GetDirectoryName(typeof(CoreToolsDownloader).Assembly.Location).ToUpperInvariant();
            string folder = Path.GetFileNameWithoutExtension(typeof(CoreToolsDownloader).Assembly.Location);
            dir = Path.Combine(dir, folder);
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

        private void DownloadCoreTools(BackgroundWorker worker, DoWorkEventArgs args)
        {
            string nuGetFeed = args.Argument as string;
            string dir = GetToolDirectory();

            var repo = NuGet.PackageRepositoryFactory.Default.CreateRepository(nuGetFeed);
            NuGet.IPackage coreToolsPackage;
            try
            {
                coreToolsPackage = repo.GetPackages().Where(x => x.Id == coreToolsId && x.IsLatestVersion)
                                                .OrderByDescending(x => x.Version)
                                                .FirstOrDefault();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    args.Result = ex.Message;
                    return;
                }
                throw;
            }

            if (coreToolsPackage == null)
            {
                args.Result = string.Format(Resources.Culture, Resources.CORE_TOOLS_NOT_FOUND, coreToolsId, nuGetFeed);
                return;
            }
            foreach (var file in coreToolsPackage.GetFiles())
            {
                using (var stream = File.Create(Path.Combine(dir, Path.GetFileName(file.Path))))
                    file.GetStream().CopyTo(stream);
            }
            args.Result = GetSolutionPackagerVersion(dir);
        }

        private void DownloadCoreToolsCompleted(RunWorkerCompletedEventArgs args)
        {
            if (args.Error != null)
            {
                MessageBox.Show(args.Error.ToString(), Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (args.Result is string errorMessage)
            {
                MessageBox.Show(errorMessage, Resources.MBOX_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (args.Result is Version version)
            {
                txtCoreTools.Text = version.ToString();
            }
        }
    }
}
