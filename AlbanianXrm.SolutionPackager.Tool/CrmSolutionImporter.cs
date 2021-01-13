using AlbanianXrm.SolutionPackager.Models;
using AlbanianXrm.SolutionPackager.Properties;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace AlbanianXrm.SolutionPackager
{
    internal class CrmSolutionImporter
    {
        private readonly SolutionPackagerControl solutionPackagerControl;
        private readonly AsyncWorkQueue asyncWorkQueue;
        private readonly PluginViewModel pluginViewModel;
        private SolutionImportStatus solutionImportStatus;

        public CrmSolutionImporter(SolutionPackagerControl solutionPackagerControl, AsyncWorkQueue asyncWorkQueue, PluginViewModel pluginViewModel)
        {
            this.solutionPackagerControl = solutionPackagerControl;
            this.asyncWorkQueue = asyncWorkQueue;
            this.pluginViewModel = pluginViewModel;
        }

        public void ImportSolution(Parameters @params)
        {
            var fileInfo = new FileInfo(@params.CustomizationFile);
            if (@params.PreferManaged)
            {
                fileInfo = new FileInfo(fileInfo.FullName.Substring(0, fileInfo.FullName.Length - fileInfo.Extension.Length) + "_managed" + fileInfo.Extension);
                @params.CustomizationFile = fileInfo.FullName;
            }
            asyncWorkQueue.Enqueue(new WorkAsyncInfo
            {
                Message = string.Format(CultureInfo.InvariantCulture, Resources.IMPORT_SOLUTION, fileInfo.Name),
                IsCancelable = true,
                AsyncArgument = @params,
                Work = ImportSolution,
                PostWorkCallBack = ImportSolutionStarted
            });
        }

        private void ImportSolution(BackgroundWorker worker, DoWorkEventArgs args)
        {
            var @params = args.Argument as Parameters;
            Guid importJobId = Guid.NewGuid();
            var importSolutionRequest = new ExecuteAsyncRequest()
            {
                Request = new Microsoft.Crm.Sdk.Messages.ImportSolutionRequest()
                {
                    ImportJobId = importJobId,
                    ConvertToManaged = @params.ImportManaged,
                    OverwriteUnmanagedCustomizations = @params.ImportOverwrite,
                    SkipProductUpdateDependencies = @params.ImportDependencies,
                    PublishWorkflows = @params.ImportPublishWorkflows,
                    CustomizationFile = File.ReadAllBytes(@params.CustomizationFile)
                }
            };
            args.Result = new Models.ImportSolutionRequest()
            {
                ImportJobId = importJobId,
                ExecuteAsyncResponse = solutionPackagerControl.Service.Execute(importSolutionRequest) as ExecuteAsyncResponse
            };
        }

        private void ImportSolutionStarted(RunWorkerCompletedEventArgs args)
        {
            if (args.Error != null)
            {
                solutionPackagerControl.WriteErrorLog("The following error occurred while importing the solution:\r\n{0}", args.Error);
                MessageBox.Show(args.Error.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var importSolution = args.Result as Models.ImportSolutionRequest;

            solutionImportStatus = new SolutionImportStatus(importSolution.ExecuteAsyncResponse.AsyncJobId, importSolution.ImportJobId, pluginViewModel);
            solutionImportStatus.Show(solutionPackagerControl);
        }

        public class Parameters
        {
            public string CustomizationFile { get; set; }
            public bool ImportDependencies { get; set; }
            public bool ImportPublishWorkflows { get; set; }
            public bool ImportOverwrite { get; set; }
            public bool ImportManaged { get; set; }
            public bool HoldingSolution { get; set; }
            public bool PreferManaged { get; set; }
        }
    }
}
