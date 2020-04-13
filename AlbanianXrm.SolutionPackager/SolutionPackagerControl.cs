using AlbanianXrm.SolutionPackager.Properties;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace AlbanianXrm.SolutionPackager
{
    internal partial class SolutionPackagerControl : PluginControlBase, IGitHubPlugin, INoConnectionRequired
    {
        /// <summary>
        /// GitHub repository 
        /// </summary>
        public string RepositoryName => "solution-packager";

        /// <summary>
        /// GitHub UserName
        /// </summary>
        public string UserName => "albanian-xrm";

        private readonly AsyncWorkQueue asyncWorkQueue;
        private readonly PluginViewModel pluginViewModel;
        private readonly CoreToolsDownloader coreToolsDownloader;
        private readonly CrmSolutionManager crmSolutionManager;
        private readonly SolutionPackagerCaller solutionPackagerCaller;

        public SolutionPackagerControl()
        {
            InitializeComponent();

            pluginViewModel = new PluginViewModel();
            asyncWorkQueue = new AsyncWorkQueue(this, pluginViewModel);
            coreToolsDownloader = new CoreToolsDownloader(asyncWorkQueue, txtCoreTools);
            solutionPackagerCaller = new SolutionPackagerCaller(asyncWorkQueue, txtOutput);
            crmSolutionManager = new CrmSolutionManager(this, asyncWorkQueue, solutionPackagerCaller, cmbCrmSolutions);

            localOrCrm.DataBindings.Add(nameof(localOrCrm.Enabled), pluginViewModel, nameof(pluginViewModel.HasConnection));
            grpExportSolution.DataBindings.Add(nameof(grpExportSolution.Visible), pluginViewModel, nameof(pluginViewModel.LocalOrCrm));

            btnRefreshSolutions.DataBindings.Add(nameof(btnRefreshSolutions.Enabled), pluginViewModel, nameof(pluginViewModel.LocalOrCrm));
            tabsExtractOrPack.DataBindings.Add(nameof(tabsExtractOrPack.Enabled), pluginViewModel, nameof(pluginViewModel.AllowRequests));
        }

        #region Extract
        private void LocalOrCrm_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            pluginViewModel.LocalOrCrm = localOrCrm.Checked;
        }

        private void BtnRefreshSolutions_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            crmSolutionManager.RefreshSolutionList();
        }

        private void BtnOpenZip_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (localOrCrm.Checked)
            {
                var result = selectFolder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtZipPath.Text = selectFolder.SelectedPath;
                }
            }
            else
            {
                var result = openZipFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtZipPath.Text = openZipFile.FileName;
                }
            }
        }

        private void BtnOutputFolder_Click(object sender, EventArgs e)
        {
            var result = selectFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputFolder.Text = selectFolder.SelectedPath;
            }
        }

        private void BtnExtract_Click(object sender, EventArgs e)
        {
            int nrErrors = 0;
            if (txtOutputFolder.Text.Length == 0)
            {
                errorProvider.SetError(txtOutputFolder, Resources.OUTPUT_FOLDER_NOT_SPECIFIED);
                nrErrors += 1;
            }
            if (localOrCrm.Checked)
            {
                if (cmbCrmSolutions.SelectedIndex < 0)
                {
                    errorProvider.SetError(cmbCrmSolutions, Resources.NO_SOLUTION_SELECTED);
                    nrErrors += 1;
                }
            }
            else
            {
                if (!File.Exists(txtZipPath.Text))
                {
                    errorProvider.SetError(txtZipPath, Resources.ZIP_FILE_DOES_NOT_EXIST);
                    nrErrors += 1;
                }
            }
            if (nrErrors > 0)
            {
                errorProvider.SetError(btnExtract, nrErrors == 1 ? Resources.EXPORT_ERROR : string.Format(CultureInfo.InvariantCulture, Resources.EXPORT_ERRORS, nrErrors));
                return;
            }

            var parameters = new SolutionPackagerCaller.Parameters()
            {
                ZipFile = txtZipPath.Text,
                OutputFolder = txtOutputFolder.Text,
                AllowWrite = chkAllowWrite.Checked,
                AllowDelete = radAllowDeleteYes.Checked ? true : (radAllowDeleteNo.Checked ? false : default(bool?))
            };

            if (localOrCrm.Checked)
            {
                crmSolutionManager.DownloadSolution(
                   new CrmSolutionManager.DownloadSolutionParams(
                       cmbCrmSolutions.SelectedItem as Models.Solution,
                       zipDirectory: txtZipPath.Text,
                       solutionPackagerParameters: parameters,
                       managed: radManaged.Checked,
                       exportAutoNumberingSettings: chkExportAutoNumbering.Checked,
                       exportCalendarSettings: chkExportCalendar.Checked,
                       exportCustomizationSettings: chkExportCustomization.Checked,
                       exportEmailTrackingSettings: chkExportEmailTracking.Checked,
                       exportExternalApplications: chkExportExternalApplications.Checked,
                       exportGeneralSettings: chkExportGeneralSettings.Checked,
                       exportIsvConfig: chkExportISVConfig.Checked,
                       exportMarketingSettings: chkExportMarketing.Checked,
                       exportOutlookSynchronizationSettings: chkExportOutlookSynchronization.Checked,
                       exportRelationshipRoles: chkExportRelationshipRoles.Checked,
                       exportSales: chkExportSales.Checked));
            }
            else
            {
                solutionPackagerCaller.ExtractSolution(parameters);
            }
        }
        #endregion

        #region Tool Events
        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            pluginViewModel.HasConnection = detail != null;
        }
        #endregion

        #region Settings
        private void BtnCoreTools_Click(object sender, EventArgs e)
        {
            coreToolsDownloader.DownloadCoreTools(txtNuGetFeed.Text);
        }

        private void BtnNuGetFeed_Click(object sender, EventArgs e)
        {
            txtNuGetFeed.Text = "https://packages.nuget.org/api/v2";
        }

        #endregion

        private void TabsExtractOrPack_Selected(object sender, TabControlEventArgs e)
        {
            if (e.Action == TabControlAction.Selected && e.TabPage == tabSettings)
            {
                txtCoreTools.Text = CoreToolsDownloader.GetSolutionPackagerVersion()?.ToString() ?? Resources.SOLUTIONPACKAGER_MISSING;
            }
        }
    }
}
