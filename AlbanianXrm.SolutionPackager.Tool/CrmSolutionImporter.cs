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
        private readonly RichTextBox txtOutput;

        public CrmSolutionImporter(SolutionPackagerControl solutionPackagerControl, AsyncWorkQueue asyncWorkQueue, RichTextBox txtOutput)
        {
            this.solutionPackagerControl = solutionPackagerControl;
            this.asyncWorkQueue = asyncWorkQueue;
            this.txtOutput = txtOutput;
        }

        public void ImportSolution(Parameters @params)
        {
            asyncWorkQueue.Enqueue(new WorkAsyncInfo
            {
                Message = string.Format(CultureInfo.InvariantCulture, Resources.IMPORT_SOLUTION, new FileInfo(@params.CustomizationFile).Name),
                IsCancelable = true,
                AsyncArgument = @params,
                Work = ImportSolution,
                PostWorkCallBack = ImportSolutionStarted 
            });
        }

        private void ImportSolution(BackgroundWorker worker, DoWorkEventArgs args)
        {
            var @params = args.Argument as Parameters;
            var importSolutionRequest = new ExecuteAsyncRequest()
            {
                Request = new ImportSolutionRequest()
                {
                    ConvertToManaged = @params.ImportManaged,
                    OverwriteUnmanagedCustomizations = @params.ImportOverwrite,
                    SkipProductUpdateDependencies = @params.ImportDependencies,
                    PublishWorkflows = @params.ImportPublishWorkflows,
                    CustomizationFile = File.ReadAllBytes(@params.CustomizationFile)
                }
            };
            args.Result = solutionPackagerControl.Service.Execute(importSolutionRequest);
        }

        private void ImportSolutionStarted(RunWorkerCompletedEventArgs args)
        {
            ExecuteAsyncResponse executeAsyncResponse = args.Result as ExecuteAsyncResponse;
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.SelectionStart = txtOutput.TextLength;
            txtOutput.SelectionFont = new Font(txtOutput.Font.FontFamily, 12, FontStyle.Underline);
            txtOutput.AppendText(Resources.IMPORT_HEADER + Environment.NewLine);
            txtOutput.SelectionStart = txtOutput.TextLength;
            txtOutput.SelectionFont = new Font(txtOutput.Font, txtOutput.Font.Style);
            txtOutput.AppendText(string.Format(Resources.IMPORT_STARTED, executeAsyncResponse.AsyncJobId) + Environment.NewLine);
        }

        public class Parameters
        {
            public string CustomizationFile { get; set; }
            public bool ImportDependencies { get; set; }
            public bool ImportPublishWorkflows { get; set; }
            public bool ImportOverwrite { get; set; }
            public bool ImportManaged { get; set; }
            public bool HoldingSolution { get; set; }
        }
    }
}
