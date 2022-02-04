using AlbanianXrm.BackgroundWorker;
using AlbanianXrm.SolutionPackager.Properties;
using AlbanianXrm.XrmToolBox.Shared;
using AlbanianXrm.XrmToolBox.Shared.Extensions;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager
{
    internal class CrmSolutionImporter
    {
        private readonly SolutionPackagerControl solutionPackagerControl;
        private readonly AlBackgroundWorkHandler asyncWorkQueue;
        private readonly ToolViewModel toolViewModel;
        private SolutionImportStatus solutionImportStatus;

        public CrmSolutionImporter(SolutionPackagerControl solutionPackagerControl, AlBackgroundWorkHandler asyncWorkQueue, ToolViewModel pluginViewModel)
        {
            this.solutionPackagerControl = solutionPackagerControl;
            this.asyncWorkQueue = asyncWorkQueue;
            this.toolViewModel = pluginViewModel;
        }

        public void ImportSolution(Parameters @params)
        {
            var fileInfo = new FileInfo(@params.CustomizationFile);
            if (@params.PreferManaged)
            {
                fileInfo = new FileInfo(fileInfo.FullName.Substring(0, fileInfo.FullName.Length - fileInfo.Extension.Length) + "_managed" + fileInfo.Extension);
                @params.CustomizationFile = fileInfo.FullName;
            }
            asyncWorkQueue.EnqueueBackgroundWork(
              AlBackgroundWorkerFactory.NewWorker(ImportSolutionInner, @params, ImportSolutionStarted)
                                       .WithViewModel(toolViewModel)
                                       .WithMessage(solutionPackagerControl, string.Format(CultureInfo.InvariantCulture, Resources.IMPORT_SOLUTION, fileInfo.Name)));
        }

        private Models.ImportSolutionRequest ImportSolutionInner(Parameters @params)
        {
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
            return new Models.ImportSolutionRequest()
            {
                ImportJobId = importJobId,
                ExecuteAsyncResponse = solutionPackagerControl.Service.Execute(importSolutionRequest) as ExecuteAsyncResponse
            };
        }

        private void ImportSolutionStarted(Parameters @params, Models.ImportSolutionRequest value, Exception exception)
        {
            if (exception != null)
            {
                solutionPackagerControl.WriteErrorLog("The following error occurred while importing the solution:\r\n{0}", exception);
                MessageBox.Show(exception.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            solutionImportStatus = new SolutionImportStatus(value.ExecuteAsyncResponse.AsyncJobId, value.ImportJobId, solutionPackagerControl, toolViewModel);
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
