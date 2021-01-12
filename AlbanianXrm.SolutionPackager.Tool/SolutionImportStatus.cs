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
    public partial class SolutionImportStatus : Form
    {
        private readonly Guid asyncJobId;
        private readonly Guid importJobId;
        private string errorDetails;

        public IOrganizationService OrganizationService { get; set; }

        public SolutionImportStatus(Guid asyncJobId, Guid importJobId, PluginViewModel pluginViewModel)
        {
            InitializeComponent();
            this.asyncJobId = asyncJobId;
            this.importJobId = importJobId;
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(WorkAsync);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(WorkAsyncEnded);
            this.Bind(t => t.OrganizationService, pluginViewModel, s => s.OrganizationService, formattingEnabled: true);
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
                btnCopyMessage.Visible = true;
                lblJobStatus.ForeColor = Color.Red;
            }

            if (importJob != null)
            {
                progressBar.Value = importJob.Progress.HasValue ? (int)importJob.Progress : 0;
                lblSolutionName.Text = importJob.SolutionName;
            }
          

            if (asyncOperation.StatusCode != AsyncOperation.OptionSets.StatusCode.Canceled &&
               asyncOperation.StatusCode != AsyncOperation.OptionSets.StatusCode.Failed &&
               asyncOperation.StatusCode != AsyncOperation.OptionSets.StatusCode.Succeeded)
            {
                this.timer.Start();
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            timer.Stop();
            timer.Dispose();
            backgroundWorker.Dispose();
        }

        private void BtnCopyMessage_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(errorDetails);
        }
    }
}
