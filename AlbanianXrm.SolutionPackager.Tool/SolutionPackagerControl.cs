using AlbanianXrm.SolutionPackager.Extensions;
using AlbanianXrm.SolutionPackager.Properties;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.ComponentModel;
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

        private readonly string[] packageTypes = new string[] { null, "Unmanaged", "Managed", "Both" };
        private readonly string[] errorLevels = new string[] { "Off", "Error", "Warning", "Info", "Verbose" };

        public SolutionPackagerControl()
        {
            InitializeComponent();

            pluginViewModel = new PluginViewModel();
            asyncWorkQueue = new AsyncWorkQueue(this, pluginViewModel);
            coreToolsDownloader = new CoreToolsDownloader(asyncWorkQueue, pluginViewModel);
            solutionPackagerCaller = new SolutionPackagerCaller(this, asyncWorkQueue, txtOutput);
            crmSolutionManager = new CrmSolutionManager(this, asyncWorkQueue, solutionPackagerCaller, cmbCrmSolutions);

            localOrCrm.DataBindings.Add(nameof(localOrCrm.Enabled), pluginViewModel, nameof(pluginViewModel.HasConnection));
            grpExportSolution.DataBindings.Add(nameof(grpExportSolution.Visible), pluginViewModel, nameof(pluginViewModel.LocalOrCrm));

            btnRefreshSolutions.DataBindings.Add(nameof(btnRefreshSolutions.Enabled), pluginViewModel, nameof(pluginViewModel.LocalOrCrm));
            tabsExtractOrPack.DataBindings.Add(nameof(tabsExtractOrPack.Enabled), pluginViewModel, nameof(pluginViewModel.AllowRequests));

            txtCoreTools.DataBindings.Add(nameof(txtCoreTools.Text), pluginViewModel, nameof(pluginViewModel.SolutionPackagerVersion));

            pluginViewModel.PropertyChanged += PluginViewModel_PropertyChanged;

            cmbLanguage.Items.AddRange(new object[] { CultureInfo.GetCultureInfo("en"), CultureInfo.GetCultureInfo("it") });
            cmbLanguage.SelectedIndex = 0;
            cmbPackageType.SelectedIndex = 0;
            cmbErrorLevel.SelectedIndex = 3;
        }

        private void PluginViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(pluginViewModel.CultureInfo))
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(SolutionPackagerControl));
                foreach (Control c in this.GetAllControls())
                {
                    resources.ApplyResources(c, c.Name, Resources.Culture);
                }
            }
        }

        private void SolutionPackagerControl_Load(object sender, EventArgs e)
        {
            Settings settings;
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out settings))
            {
                LogWarning(Resources.SETTINGS_NOT_FOUND);
                return;
            }
            pluginViewModel.Settings = settings;

            var selection = cmbLanguage.Items.IndexOf(CultureInfo.GetCultureInfo(settings.Language));
            if (selection >= 0)
            {
                cmbLanguage.SelectedIndex = selection;
            }
            LogInfo(Resources.SETTINGS_FOUND);
        }

        /// <summary>
        /// Allows for the plugin to prevent the form from closing, or preform some action before closing
        /// By default, if the Form is being closed, or a close all or all except active is being called, it won't prompt the user to ensure they wanted to close
        /// </summary>
        /// <param name="info"></param>
        public override void ClosingPlugin(PluginCloseInfo info)
        {
            if (info.Silent ||
                info.FormReason != CloseReason.None ||
                info.ToolBoxReason == ToolBoxCloseReason.CloseAll ||
                info.ToolBoxReason == ToolBoxCloseReason.CloseAllExceptActive)
            {
                return;
            }

            info.Cancel = MessageBox.Show(Resources.QUESTION_CLOSE_TOOL, Resources.QUESTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolutionPackagerControl_OnCloseTool(object sender, EventArgs e)
        {
            LogInfo(Resources.SETTINGS_SAVING);
            SettingsManager.Instance.Save(GetType(), pluginViewModel.Settings);
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
            if (CoreToolsDownloader.GetSolutionPackagerVersion() == null)
            {
                errorProvider.SetError(tabSettings, Resources.SOLUTIONPACKAGER_MISSING);
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
                PackageType = packageTypes[cmbPackageType.SelectedIndex],
                AllowWrite = chkAllowWrite.Checked,
                AllowDelete = radAllowDeleteYes.Checked ? true : (radAllowDeleteNo.Checked ? false : default(bool?)),
                Clobber = chkClobber.Checked,
                ErrorLevel = errorLevels[cmbErrorLevel.SelectedIndex],
                NoLogo = !chkBanner.Checked,
                Localize = chkLocalize.Checked,
                FormatXml = chkFormatDocument.Checked
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

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pluginViewModel.CultureInfo = cmbLanguage.Items[cmbLanguage.SelectedIndex] as CultureInfo;
        }
        #endregion

        private void TabsExtractOrPack_Selected(object sender, TabControlEventArgs e)
        {
            if (e.Action == TabControlAction.Selected && e.TabPage == tabSettings)
            {
                pluginViewModel.SolutionPackagerVersion = CoreToolsDownloader.GetSolutionPackagerVersion()?.ToString();
            }
        }


    }
}
