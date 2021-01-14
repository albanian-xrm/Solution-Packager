using AlbanianXrm.SolutionPackager.Extensions;
using AlbanianXrm.SolutionPackager.Models;
using AlbanianXrm.SolutionPackager.Properties;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager
{
    internal partial class SolutionImportStatus : Form
    {
        private readonly Guid asyncJobId;
        private readonly Guid importJobId;
        private readonly SolutionPackagerControl solutionPackagerControl;
        private string errorDetails;

        public IOrganizationService OrganizationService { get; set; }

        internal SolutionImportStatus(Guid asyncJobId, Guid importJobId, SolutionPackagerControl solutionPackagerControl)
        {
            InitializeComponent();
            this.asyncJobId = asyncJobId;
            this.importJobId = importJobId;
            this.solutionPackagerControl = solutionPackagerControl;
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(WorkAsync);
            this.backgroundWorkerCancel.DoWork += new System.ComponentModel.DoWorkEventHandler(WorkAsyncCancel);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(WorkAsyncEnded);
            this.backgroundWorkerCancel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(WorkAsyncCancelEnded);
            this.Bind(t => t.OrganizationService, solutionPackagerControl.pluginViewModel, s => s.OrganizationService, formattingEnabled: true);
            this.timer.Start();
        }             

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            backgroundWorker.RunWorkerAsync();
        }

        private void WorkAsync(object sender, System.ComponentModel.DoWorkEventArgs args)
        {
            var service = OrganizationService;
            if (service == null)
            {
                args.Result = null;
                return;
            }

            var query = new QueryExpression(AsyncOperation.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(
                    AsyncOperation.Fields.CreatedOn,
                    AsyncOperation.Fields.CompletedOn,
                    AsyncOperation.Fields.ErrorCode,
                    AsyncOperation.Fields.Message,
                    AsyncOperation.Fields.StartedOn,
                    AsyncOperation.Fields.StatusCode
                )
            };
            query.Criteria.AddCondition(AsyncOperation.Fields.AsyncOperationId, ConditionOperator.Equal, asyncJobId);

            var result = new ImportSolutionStatus()
            {
                AsyncOperation = service.RetrieveMultiple(query).Entities.Select(a => a.ToEntity<AsyncOperation>()).FirstOrDefault()
            };

            query = new QueryExpression(ImportJob.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(
                    ImportJob.Fields.Progress,
                    ImportJob.Fields.SolutionName
                )
            };
            query.Criteria.AddCondition(ImportJob.Fields.ImportJobId, ConditionOperator.Equal, importJobId);

            result.ImportJob = service.RetrieveMultiple(query).Entities.Select(i => i.ToEntity<ImportJob>()).FirstOrDefault();
            args.Result = result;
        }

        private void WorkAsyncEnded(object sender, System.ComponentModel.RunWorkerCompletedEventArgs args)
        {
            if (args.Error != null)
            {
                solutionPackagerControl.WriteErrorLog("The following error occurred while checking the solution import status:\r\n{0}", args.Error);
                MessageBox.Show(args.Error.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer.Start();
                return;
            }

            if (!(args.Result is ImportSolutionStatus result))
            {
                timer.Start();
                return;
            }

            if (result.AsyncOperation == null)
            {
                lblJobStatus.Text = string.Format(Resources.ASYNC_JOB_NOT_FOUND, asyncJobId);
                lblJobStatus.ForeColor = Color.Red;
                return;
            }

            var asyncOperation = result.AsyncOperation;
            var importJob = result.ImportJob;

            lblJobStatus.Text = asyncOperation.StatusCode?.ToString();
            lblCreatedOn.Text = asyncOperation.CreatedOn?.ToString();
            lblStartedOn.Text = asyncOperation.StartedOn?.ToString();
            lblCompletedOn.Text = asyncOperation.CompletedOn?.ToString();

            if (asyncOperation.ErrorCode.HasValue && Enum.IsDefined(typeof(ImportErrorCodes), asyncOperation.ErrorCode.Value))
            {
                ImportErrorCodes errorCode = (ImportErrorCodes)asyncOperation.ErrorCode.Value;
                lblErrorCode.Text = errorCode.ToString();
                toolTip.SetToolTip(lblErrorCode, DataPlatformErrorCodes.ResourceManager.GetString(errorCode.ToString(), DataPlatformErrorCodes.Culture));
            }
            else
            {
                lblErrorCode.Text = asyncOperation.ErrorCode?.ToString();
            }

            if (asyncOperation.ErrorCode.HasValue)
            {
                errorDetails = asyncOperation.Message;
                btnCancelImport.Visible = false;
                tlpContainer.SetRow(btnCancelImport, 8);
                tlpContainer.SetRow(btnCopyMessage, 7);
                btnCopyMessage.Visible = true;
                lblJobStatus.ForeColor = Color.Red;
            }

            if (importJob != null)
            {
                progressBar.Value = importJob.Progress.HasValue ? (int)importJob.Progress : 0;
                toolTip.SetToolTip(progressBar, string.Format(Resources.PROGRESS_X_PERCENT, progressBar.Value));
                lblSolutionName.Text = importJob.SolutionName;
            }


            if (asyncOperation.StatusCode != AsyncOperation.OptionSets.StatusCode.Canceled &&
               asyncOperation.StatusCode != AsyncOperation.OptionSets.StatusCode.Failed &&
               asyncOperation.StatusCode != AsyncOperation.OptionSets.StatusCode.Succeeded)
            {
                this.timer.Start();
            }
        }

        private void WorkAsyncCancel(object sender, System.ComponentModel.DoWorkEventArgs args)
        {
            var service = OrganizationService;
            if (service == null)
            {
                return;
            }

            var asyncOperation = new AsyncOperation()
            {
                Id = asyncJobId,
                StateCode = AsyncOperation.OptionSets.StateCode.Completed,
                StatusCode = AsyncOperation.OptionSets.StatusCode.Canceling
            };

            service.Update(asyncOperation);
        }

        private void WorkAsyncCancelEnded(object sender, System.ComponentModel.RunWorkerCompletedEventArgs args)
        {
            if (args.Error != null)
            {
                solutionPackagerControl.WriteErrorLog("The following error occurred while canceling the solution import:\r\n{0}", args.Error);
                MessageBox.Show(args.Error.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            timer.Stop();
            timer.Dispose();
            backgroundWorker.Dispose();
            backgroundWorkerCancel.Dispose();
        }

        private void BtnCopyMessage_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(errorDetails);
        }

        private void BtnCancelImport_Click(object sender, EventArgs e)
        {
            if (!btnCancelImport.Enabled)
            {
                return;
            }
            btnCancelImport.Enabled = false;
            backgroundWorkerCancel.RunWorkerAsync();
        }
    }
}
