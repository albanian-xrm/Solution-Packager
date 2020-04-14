using AlbanianXrm.SolutionPackager.Models;
using AlbanianXrm.SolutionPackager.Properties;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace AlbanianXrm.SolutionPackager
{
    internal class CrmSolutionManager
    {
        private readonly SolutionPackagerControl solutionPackagerControl;
        private readonly AsyncWorkQueue asyncWorkQueue;
        private readonly SolutionPackagerCaller solutionPackagerCaller;
        private readonly ComboBox cmbCrmSolutions;

        public CrmSolutionManager(SolutionPackagerControl solutionPackagerControl, AsyncWorkQueue asyncWorkQueue, SolutionPackagerCaller solutionPackagerCaller, ComboBox cmbCrmSolutions)
        {
            this.solutionPackagerControl = solutionPackagerControl ?? throw new ArgumentNullException(nameof(solutionPackagerControl));
            this.asyncWorkQueue = asyncWorkQueue ?? throw new ArgumentNullException(nameof(asyncWorkQueue));
            this.solutionPackagerCaller = solutionPackagerCaller ?? throw new ArgumentNullException(nameof(solutionPackagerCaller));
            this.cmbCrmSolutions = cmbCrmSolutions ?? throw new ArgumentNullException(nameof(cmbCrmSolutions));
        }

        public void DownloadSolution(DownloadSolutionParams @params)
        {
            asyncWorkQueue.Enqueue(new WorkAsyncInfo
            {
                Message = string.Format(CultureInfo.InvariantCulture, Resources.DOWNLOADING_SOLUTION, @params.Solution.FriendlyName),
                AsyncArgument = @params,
                Work = DownloadSolution,
                PostWorkCallBack = DownloadSolutionCompleted
            });
        }

        private void DownloadSolution(BackgroundWorker worker, DoWorkEventArgs args)
        {
            var @params = args.Argument as DownloadSolutionParams ?? throw new ArgumentNullException(nameof(args.Argument));
            ExportSolutionRequest request = new ExportSolutionRequest()
            {
                SolutionName = @params.Solution.UniqueName,
                Managed = @params.Managed,
                ExportAutoNumberingSettings = @params.ExportAutoNumberingSettings,
                ExportCalendarSettings = @params.ExportCalendarSettings,
                ExportCustomizationSettings = @params.ExportCustomizationSettings,
                ExportEmailTrackingSettings = @params.ExportEmailTrackingSettings,
                ExportExternalApplications = @params.ExportExternalApplications,
                ExportGeneralSettings = @params.ExportGeneralSettings,
                ExportIsvConfig = @params.ExportIsvConfig,
                ExportMarketingSettings = @params.ExportMarketingSettings,
                ExportOutlookSynchronizationSettings = @params.ExportOutlookSynchronizationSettings,
                ExportRelationshipRoles = @params.ExportRelationshipRoles,
                ExportSales = @params.ExportSales
            };
            var response = solutionPackagerControl.Service.Execute(request) as ExportSolutionResponse;

            string filePath = Path.Combine(@params.ZipDirectory, $"{@params.Solution.UniqueName}_{@params.Solution.Version.ToString().Replace(".", "_")}.zip");

            using (FileStream writer = File.Create(filePath))
            {
                writer.Write(response.ExportSolutionFile, 0, response.ExportSolutionFile.Length);
            }

            @params.SolutionPackagerParameters.ZipFile = new FileInfo(filePath).FullName;

            args.Result = @params.SolutionPackagerParameters;

        }

        private void DownloadSolutionCompleted(RunWorkerCompletedEventArgs args)
        {
            if (args.Error is FaultException<OrganizationServiceFault> crmError)
            {
                MessageBox.Show(crmError.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (args.Error != null)
            {
                MessageBox.Show(args.Error.ToString(), Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (args.Result is string errorMessage)
            {
                MessageBox.Show(errorMessage, Resources.MBOX_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (args.Result is SolutionPackagerCaller.Parameters @params)
            {
                solutionPackagerCaller.ExtractSolution(@params);
            }
        }

        public void RefreshSolutionList()
        {
            asyncWorkQueue.Enqueue(new WorkAsyncInfo
            {
                Message = Resources.REFRESHING_SOLUTION_LIST,
                Work = RefreshSolutionList,
                PostWorkCallBack = RefreshSolutionListCompleted
            });
        }

        private void RefreshSolutionList(BackgroundWorker worker, DoWorkEventArgs args)
        {
            var query = new QueryExpression(Solution.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(Solution.Fields.FriendlyName, Solution.Fields.UniqueName, Solution.Fields.Version)
            };
            query.Criteria.AddCondition(Solution.Fields.IsManaged, ConditionOperator.Equal, false);
            query.Criteria.AddCondition(Solution.Fields.IsVisible, ConditionOperator.Equal, true);
            args.Result = solutionPackagerControl.Service.RetrieveMultiple(query).Entities.Select(solution => solution.ToEntity<Solution>()).ToArray<object>();
        }

        private void RefreshSolutionListCompleted(RunWorkerCompletedEventArgs args)
        {
            if (args.Error != null)
            {
                MessageBox.Show(args.Error.ToString(), Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (args.Result is string errorMessage)
            {
                MessageBox.Show(errorMessage, Resources.MBOX_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (args.Result is object[] solutions)
            {
                cmbCrmSolutions.BeginUpdate();
                cmbCrmSolutions.Items.Clear();
                cmbCrmSolutions.Items.AddRange(solutions);
                cmbCrmSolutions.EndUpdate();
            }
        }

        public class DownloadSolutionParams
        {
            public DownloadSolutionParams(
                Solution solution,
                string zipDirectory,
                SolutionPackagerCaller.Parameters solutionPackagerParameters,
                bool managed,
                bool exportAutoNumberingSettings,
                bool exportCalendarSettings,
                bool exportCustomizationSettings,
                bool exportEmailTrackingSettings,
                bool exportExternalApplications,
                bool exportGeneralSettings,
                bool exportIsvConfig,
                bool exportMarketingSettings,
                bool exportOutlookSynchronizationSettings,
                bool exportRelationshipRoles,
                bool exportSales
                )
            {
                Solution = solution ?? throw new ArgumentNullException(nameof(solution));
                ZipDirectory = zipDirectory ?? throw new ArgumentNullException(nameof(zipDirectory));
                SolutionPackagerParameters = solutionPackagerParameters ?? throw new ArgumentNullException(nameof(solutionPackagerParameters));
                Managed = managed;
                ExportAutoNumberingSettings = exportAutoNumberingSettings;
                ExportCalendarSettings = exportCalendarSettings;
                ExportCustomizationSettings = exportCustomizationSettings;
                ExportEmailTrackingSettings = exportEmailTrackingSettings;
                ExportExternalApplications = exportExternalApplications;
                ExportGeneralSettings = exportGeneralSettings;
                ExportIsvConfig = exportIsvConfig;
                ExportMarketingSettings = exportMarketingSettings;
                ExportOutlookSynchronizationSettings = exportOutlookSynchronizationSettings;
                ExportRelationshipRoles = exportRelationshipRoles;
                ExportSales = exportSales;
            }

            public Solution Solution { get; private set; }
            public string ZipDirectory { get; private set; }
            public SolutionPackagerCaller.Parameters SolutionPackagerParameters { get; private set; }
            public bool Managed { get; private set; }
            public bool ExportAutoNumberingSettings { get; private set; }
            public bool ExportCalendarSettings { get; private set; }
            public bool ExportCustomizationSettings { get; private set; }
            public bool ExportEmailTrackingSettings { get; private set; }
            public bool ExportExternalApplications { get; private set; }
            public bool ExportGeneralSettings { get; private set; }
            public bool ExportIsvConfig { get; private set; }
            public bool ExportMarketingSettings { get; private set; }
            public bool ExportOutlookSynchronizationSettings { get; private set; }
            public bool ExportRelationshipRoles { get; private set; }
            public bool ExportSales { get; private set; }
        }
    }
}
