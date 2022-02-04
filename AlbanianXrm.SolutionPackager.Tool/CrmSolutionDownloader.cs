using AlbanianXrm.BackgroundWorker;
using AlbanianXrm.SolutionPackager.Models;
using AlbanianXrm.SolutionPackager.Properties;
using AlbanianXrm.XrmToolBox.Shared.Extensions;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager
{
    internal class CrmSolutionDownloader
    {
        private readonly SolutionPackagerControl solutionPackagerControl;
        private readonly AlBackgroundWorkHandler asyncWorkQueue;
        private readonly SolutionPackagerCaller solutionPackagerCaller;
        private readonly ComboBox cmbCrmSolutions;

        public CrmSolutionDownloader(SolutionPackagerControl solutionPackagerControl, AlBackgroundWorkHandler asyncWorkQueue, SolutionPackagerCaller solutionPackagerCaller, ComboBox cmbCrmSolutions)
        {
            this.solutionPackagerControl = solutionPackagerControl ?? throw new ArgumentNullException(nameof(solutionPackagerControl));
            this.asyncWorkQueue = asyncWorkQueue ?? throw new ArgumentNullException(nameof(asyncWorkQueue));
            this.solutionPackagerCaller = solutionPackagerCaller ?? throw new ArgumentNullException(nameof(solutionPackagerCaller));
            this.cmbCrmSolutions = cmbCrmSolutions ?? throw new ArgumentNullException(nameof(cmbCrmSolutions));
        }

        public void DownloadSolution(Parameters @params)
        {
            asyncWorkQueue.EnqueueBackgroundWork(
                   AlBackgroundWorkerFactory.NewWorker(DownloadSolutionInner, @params, DownloadSolutionCompleted)
                                            .WithViewModel(solutionPackagerControl.toolViewModel)
                                            .WithMessage(solutionPackagerControl, string.Format(CultureInfo.InvariantCulture, Resources.DOWNLOADING_SOLUTION, @params.Solution.FriendlyName)));
        }

        private SolutionPackagerCaller.Parameters DownloadSolutionInner(Parameters @params)
        {
            foreach (var managed in @params.Managed)
            {
                ExportSolutionRequest request = new ExportSolutionRequest()
                {
                    SolutionName = @params.Solution.UniqueName,
                    Managed = managed,
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

                string filePath = Path.Combine(@params.ZipDirectory, $"{@params.Solution.UniqueName}_{@params.Solution.Version.ToString().Replace(".", "_")}{(managed ? "_managed" : "")}.zip");

                using (FileStream writer = File.Create(filePath))
                {
                    writer.Write(response.ExportSolutionFile, 0, response.ExportSolutionFile.Length);
                }

                @params.SolutionPackagerParameters.ZipFile = new FileInfo(filePath).FullName;
            }

            return @params.SolutionPackagerParameters;
        }

        private void DownloadSolutionCompleted(Parameters args, SolutionPackagerCaller.Parameters value, Exception exception)
        {
            if (exception is FaultException<OrganizationServiceFault> crmError)
            {
                solutionPackagerControl.WriteErrorLog("The following error occurred while downloading the solution:\r\n{0}", crmError);
                MessageBox.Show(crmError.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (exception != null)
            {
                solutionPackagerControl.WriteErrorLog("The following error occurred while downloading the solution:\r\n{0}", exception);
                MessageBox.Show(exception.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                solutionPackagerCaller.ManageSolution(value);
            }
        }

        public void RefreshSolutionList()
        {
            asyncWorkQueue.EnqueueBackgroundWork(
                AlBackgroundWorkerFactory.NewWorker(RefreshSolutionListInner, RefreshSolutionListCompleted)
                                         .WithViewModel(solutionPackagerControl.toolViewModel)
                                         .WithMessage(solutionPackagerControl, Resources.REFRESHING_SOLUTION_LIST));
        }

        private object[] RefreshSolutionListInner()
        {
            var query = new QueryExpression(Solution.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(Solution.Fields.FriendlyName, Solution.Fields.UniqueName, Solution.Fields.Version)
            };
            query.Criteria.AddCondition(Solution.Fields.IsManaged, ConditionOperator.Equal, false);
            query.Criteria.AddCondition(Solution.Fields.IsVisible, ConditionOperator.Equal, true);
            return solutionPackagerControl.Service.RetrieveMultiple(query).Entities.Select(solution => solution.ToEntity<Solution>()).ToArray<object>();
        }

        private void RefreshSolutionListCompleted(object[] value, Exception exception)
        {
            if (exception != null)
            {
                solutionPackagerControl.WriteErrorLog("The following error occurred while refreshing the solution list:\r\n{0}", exception);
                MessageBox.Show(exception.Message, Resources.MBOX_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmbCrmSolutions.BeginUpdate();
                cmbCrmSolutions.Items.Clear();
                cmbCrmSolutions.Items.AddRange(value);
                cmbCrmSolutions.EndUpdate();
            }
        }

        public class Parameters
        {
            public Parameters(
                Solution solution,
                string zipDirectory,
                SolutionPackagerCaller.Parameters solutionPackagerParameters,
                bool[] managed,
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
            public bool[] Managed { get; private set; }
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
