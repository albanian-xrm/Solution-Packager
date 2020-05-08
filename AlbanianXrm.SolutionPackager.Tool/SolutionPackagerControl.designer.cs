namespace AlbanianXrm.SolutionPackager
{
    internal partial class SolutionPackagerControl
    {
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionPackagerControl));
            this.tabsExtractOrPack = new System.Windows.Forms.TabControl();
            this.tabExtract = new System.Windows.Forms.TabPage();
            this.tlpExtract = new System.Windows.Forms.TableLayoutPanel();
            this.localOrCrm = new System.Windows.Forms.CheckBox();
            this.grpExportSolution = new System.Windows.Forms.GroupBox();
            this.lblExportAs = new System.Windows.Forms.Label();
            this.radManaged = new System.Windows.Forms.RadioButton();
            this.radUnmanaged = new System.Windows.Forms.RadioButton();
            this.chkExportRelationshipRoles = new System.Windows.Forms.CheckBox();
            this.chkExportSales = new System.Windows.Forms.CheckBox();
            this.chkExportOutlookSynchronization = new System.Windows.Forms.CheckBox();
            this.chkExportMarketing = new System.Windows.Forms.CheckBox();
            this.chkExportISVConfig = new System.Windows.Forms.CheckBox();
            this.chkExportGeneralSettings = new System.Windows.Forms.CheckBox();
            this.chkExportExternalApplications = new System.Windows.Forms.CheckBox();
            this.chkExportEmailTracking = new System.Windows.Forms.CheckBox();
            this.chkExportCustomization = new System.Windows.Forms.CheckBox();
            this.chkExportCalendar = new System.Windows.Forms.CheckBox();
            this.chkExportAutoNumbering = new System.Windows.Forms.CheckBox();
            this.lblOnlineSolution = new System.Windows.Forms.Label();
            this.cmbCrmSolutions = new System.Windows.Forms.ComboBox();
            this.btnRefreshSolutions = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.flpExtractLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.lblExtractZipPath = new System.Windows.Forms.Label();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.lblPackageType = new System.Windows.Forms.Label();
            this.lblPackWrite = new System.Windows.Forms.Label();
            this.lblAllowDelete = new System.Windows.Forms.Label();
            this.lblExtractClobber = new System.Windows.Forms.Label();
            this.lblErrorLevel = new System.Windows.Forms.Label();
            this.lblExtractMap = new System.Windows.Forms.Label();
            this.lblExtractLogo = new System.Windows.Forms.Label();
            this.lblExtractLog = new System.Windows.Forms.Label();
            this.lblExtractArguments = new System.Windows.Forms.Label();
            this.lblExtractSourceLocale = new System.Windows.Forms.Label();
            this.lblExtractLocalize = new System.Windows.Forms.Label();
            this.lblExtractFormat = new System.Windows.Forms.Label();
            this.flpExtractControls = new System.Windows.Forms.FlowLayoutPanel();
            this.txtZipPath = new System.Windows.Forms.RichTextBox();
            this.txtOutputFolder = new System.Windows.Forms.RichTextBox();
            this.cmbPackageType = new System.Windows.Forms.ComboBox();
            this.chkAllowWrite = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radAllowDeletePrompt = new System.Windows.Forms.RadioButton();
            this.radAllowDeleteYes = new System.Windows.Forms.RadioButton();
            this.radAllowDeleteNo = new System.Windows.Forms.RadioButton();
            this.chkClobber = new System.Windows.Forms.CheckBox();
            this.cmbErrorLevel = new System.Windows.Forms.ComboBox();
            this.txtExtractMap = new System.Windows.Forms.RichTextBox();
            this.chkExtractNoLogo = new System.Windows.Forms.CheckBox();
            this.txtExtractLog = new System.Windows.Forms.RichTextBox();
            this.txtExtractArguments = new System.Windows.Forms.RichTextBox();
            this.cmbExtractSourceLocale = new System.Windows.Forms.ComboBox();
            this.chkLocalize = new System.Windows.Forms.CheckBox();
            this.chkFormatDocument = new System.Windows.Forms.CheckBox();
            this.flpExtractButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenZip = new System.Windows.Forms.Button();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.btnExtractMapFile = new System.Windows.Forms.Button();
            this.btnExtractLog = new System.Windows.Forms.Button();
            this.btnExtractArguments = new System.Windows.Forms.Button();
            this.tabPack = new System.Windows.Forms.TabPage();
            this.tlpPack = new System.Windows.Forms.TableLayoutPanel();
            this.btnPack = new System.Windows.Forms.Button();
            this.flpPackLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInputFolder = new System.Windows.Forms.Label();
            this.lblOutputZip = new System.Windows.Forms.Label();
            this.lblPackageTypePack = new System.Windows.Forms.Label();
            this.lblErrorLevelPack = new System.Windows.Forms.Label();
            this.lblPackMap = new System.Windows.Forms.Label();
            this.lblNoLogoPack = new System.Windows.Forms.Label();
            this.lblLogPack = new System.Windows.Forms.Label();
            this.lblArgumentsPack = new System.Windows.Forms.Label();
            this.lblLocalizePack = new System.Windows.Forms.Label();
            this.flpPackControls = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPackFolder = new System.Windows.Forms.RichTextBox();
            this.txtPackZip = new System.Windows.Forms.RichTextBox();
            this.cmbPackPackageType = new System.Windows.Forms.ComboBox();
            this.cmbPackErrorLevel = new System.Windows.Forms.ComboBox();
            this.txtPackMap = new System.Windows.Forms.RichTextBox();
            this.chkPackNoLogo = new System.Windows.Forms.CheckBox();
            this.txtPackLog = new System.Windows.Forms.RichTextBox();
            this.txtPackArguments = new System.Windows.Forms.RichTextBox();
            this.chkPackLocalize = new System.Windows.Forms.CheckBox();
            this.flpPackButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInputFolder = new System.Windows.Forms.Button();
            this.btnOutputZip = new System.Windows.Forms.Button();
            this.btnPackMap = new System.Windows.Forms.Button();
            this.btnLogPack = new System.Windows.Forms.Button();
            this.btnArgumentsPack = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.flpSettingsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCoreTools = new System.Windows.Forms.Button();
            this.btnNuGetFeed = new System.Windows.Forms.Button();
            this.flpSettingsLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCoreToolsVersion = new System.Windows.Forms.Label();
            this.lblNuGetFeed = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.flpSettingsControls = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCoreTools = new System.Windows.Forms.RichTextBox();
            this.txtNuGetFeed = new System.Windows.Forms.RichTextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openZipFile = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabsExtractOrPack.SuspendLayout();
            this.tabExtract.SuspendLayout();
            this.tlpExtract.SuspendLayout();
            this.grpExportSolution.SuspendLayout();
            this.flpExtractLabels.SuspendLayout();
            this.flpExtractControls.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpExtractButtons.SuspendLayout();
            this.tabPack.SuspendLayout();
            this.tlpPack.SuspendLayout();
            this.flpPackLabels.SuspendLayout();
            this.flpPackControls.SuspendLayout();
            this.flpPackButtons.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tlpSettings.SuspendLayout();
            this.flpSettingsButtons.SuspendLayout();
            this.flpSettingsLabels.SuspendLayout();
            this.flpSettingsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsExtractOrPack
            // 
            this.tabsExtractOrPack.Controls.Add(this.tabExtract);
            this.tabsExtractOrPack.Controls.Add(this.tabPack);
            this.tabsExtractOrPack.Controls.Add(this.tabSettings);
            resources.ApplyResources(this.tabsExtractOrPack, "tabsExtractOrPack");
            this.tabsExtractOrPack.Name = "tabsExtractOrPack";
            this.tabsExtractOrPack.SelectedIndex = 0;
            this.tabsExtractOrPack.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabsExtractOrPack_Selected);
            // 
            // tabExtract
            // 
            this.tabExtract.Controls.Add(this.tlpExtract);
            resources.ApplyResources(this.tabExtract, "tabExtract");
            this.tabExtract.Name = "tabExtract";
            this.tabExtract.UseVisualStyleBackColor = true;
            // 
            // tlpExtract
            // 
            resources.ApplyResources(this.tlpExtract, "tlpExtract");
            this.tlpExtract.Controls.Add(this.localOrCrm, 0, 0);
            this.tlpExtract.Controls.Add(this.grpExportSolution, 0, 3);
            this.tlpExtract.Controls.Add(this.btnExtract, 1, 2);
            this.tlpExtract.Controls.Add(this.flpExtractLabels, 0, 1);
            this.tlpExtract.Controls.Add(this.flpExtractControls, 1, 1);
            this.tlpExtract.Controls.Add(this.flpExtractButtons, 2, 1);
            this.tlpExtract.Name = "tlpExtract";
            // 
            // localOrCrm
            // 
            resources.ApplyResources(this.localOrCrm, "localOrCrm");
            this.tlpExtract.SetColumnSpan(this.localOrCrm, 2);
            this.localOrCrm.Name = "localOrCrm";
            this.localOrCrm.UseVisualStyleBackColor = true;
            this.localOrCrm.CheckedChanged += new System.EventHandler(this.LocalOrCrm_CheckedChanged);
            // 
            // grpExportSolution
            // 
            this.tlpExtract.SetColumnSpan(this.grpExportSolution, 3);
            this.grpExportSolution.Controls.Add(this.lblExportAs);
            this.grpExportSolution.Controls.Add(this.radManaged);
            this.grpExportSolution.Controls.Add(this.radUnmanaged);
            this.grpExportSolution.Controls.Add(this.chkExportRelationshipRoles);
            this.grpExportSolution.Controls.Add(this.chkExportSales);
            this.grpExportSolution.Controls.Add(this.chkExportOutlookSynchronization);
            this.grpExportSolution.Controls.Add(this.chkExportMarketing);
            this.grpExportSolution.Controls.Add(this.chkExportISVConfig);
            this.grpExportSolution.Controls.Add(this.chkExportGeneralSettings);
            this.grpExportSolution.Controls.Add(this.chkExportExternalApplications);
            this.grpExportSolution.Controls.Add(this.chkExportEmailTracking);
            this.grpExportSolution.Controls.Add(this.chkExportCustomization);
            this.grpExportSolution.Controls.Add(this.chkExportCalendar);
            this.grpExportSolution.Controls.Add(this.chkExportAutoNumbering);
            this.grpExportSolution.Controls.Add(this.lblOnlineSolution);
            this.grpExportSolution.Controls.Add(this.cmbCrmSolutions);
            this.grpExportSolution.Controls.Add(this.btnRefreshSolutions);
            resources.ApplyResources(this.grpExportSolution, "grpExportSolution");
            this.grpExportSolution.Name = "grpExportSolution";
            this.grpExportSolution.TabStop = false;
            // 
            // lblExportAs
            // 
            resources.ApplyResources(this.lblExportAs, "lblExportAs");
            this.lblExportAs.Name = "lblExportAs";
            // 
            // radManaged
            // 
            resources.ApplyResources(this.radManaged, "radManaged");
            this.radManaged.Name = "radManaged";
            this.radManaged.UseVisualStyleBackColor = true;
            // 
            // radUnmanaged
            // 
            resources.ApplyResources(this.radUnmanaged, "radUnmanaged");
            this.radUnmanaged.Checked = true;
            this.radUnmanaged.Name = "radUnmanaged";
            this.radUnmanaged.TabStop = true;
            this.radUnmanaged.UseVisualStyleBackColor = true;
            // 
            // chkExportRelationshipRoles
            // 
            resources.ApplyResources(this.chkExportRelationshipRoles, "chkExportRelationshipRoles");
            this.chkExportRelationshipRoles.Name = "chkExportRelationshipRoles";
            this.chkExportRelationshipRoles.UseVisualStyleBackColor = true;
            // 
            // chkExportSales
            // 
            resources.ApplyResources(this.chkExportSales, "chkExportSales");
            this.chkExportSales.Name = "chkExportSales";
            this.chkExportSales.UseVisualStyleBackColor = true;
            // 
            // chkExportOutlookSynchronization
            // 
            resources.ApplyResources(this.chkExportOutlookSynchronization, "chkExportOutlookSynchronization");
            this.chkExportOutlookSynchronization.Name = "chkExportOutlookSynchronization";
            this.chkExportOutlookSynchronization.UseVisualStyleBackColor = true;
            // 
            // chkExportMarketing
            // 
            resources.ApplyResources(this.chkExportMarketing, "chkExportMarketing");
            this.chkExportMarketing.Name = "chkExportMarketing";
            this.chkExportMarketing.UseVisualStyleBackColor = true;
            // 
            // chkExportISVConfig
            // 
            resources.ApplyResources(this.chkExportISVConfig, "chkExportISVConfig");
            this.chkExportISVConfig.Name = "chkExportISVConfig";
            this.chkExportISVConfig.UseVisualStyleBackColor = true;
            // 
            // chkExportGeneralSettings
            // 
            resources.ApplyResources(this.chkExportGeneralSettings, "chkExportGeneralSettings");
            this.chkExportGeneralSettings.Name = "chkExportGeneralSettings";
            this.chkExportGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // chkExportExternalApplications
            // 
            resources.ApplyResources(this.chkExportExternalApplications, "chkExportExternalApplications");
            this.chkExportExternalApplications.Name = "chkExportExternalApplications";
            this.chkExportExternalApplications.UseVisualStyleBackColor = true;
            // 
            // chkExportEmailTracking
            // 
            resources.ApplyResources(this.chkExportEmailTracking, "chkExportEmailTracking");
            this.chkExportEmailTracking.Name = "chkExportEmailTracking";
            this.chkExportEmailTracking.UseVisualStyleBackColor = true;
            // 
            // chkExportCustomization
            // 
            resources.ApplyResources(this.chkExportCustomization, "chkExportCustomization");
            this.chkExportCustomization.Name = "chkExportCustomization";
            this.chkExportCustomization.UseVisualStyleBackColor = true;
            // 
            // chkExportCalendar
            // 
            resources.ApplyResources(this.chkExportCalendar, "chkExportCalendar");
            this.chkExportCalendar.Name = "chkExportCalendar";
            this.chkExportCalendar.UseVisualStyleBackColor = true;
            // 
            // chkExportAutoNumbering
            // 
            resources.ApplyResources(this.chkExportAutoNumbering, "chkExportAutoNumbering");
            this.chkExportAutoNumbering.Name = "chkExportAutoNumbering";
            this.chkExportAutoNumbering.UseVisualStyleBackColor = true;
            // 
            // lblOnlineSolution
            // 
            resources.ApplyResources(this.lblOnlineSolution, "lblOnlineSolution");
            this.lblOnlineSolution.Name = "lblOnlineSolution";
            // 
            // cmbCrmSolutions
            // 
            this.cmbCrmSolutions.DisplayMember = "FriendlyName";
            this.cmbCrmSolutions.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCrmSolutions, "cmbCrmSolutions");
            this.cmbCrmSolutions.Name = "cmbCrmSolutions";
            this.cmbCrmSolutions.ValueMember = "SolutionId";
            // 
            // btnRefreshSolutions
            // 
            this.btnRefreshSolutions.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Solutions;
            resources.ApplyResources(this.btnRefreshSolutions, "btnRefreshSolutions");
            this.btnRefreshSolutions.Name = "btnRefreshSolutions";
            this.btnRefreshSolutions.UseVisualStyleBackColor = true;
            this.btnRefreshSolutions.Click += new System.EventHandler(this.BtnRefreshSolutions_Click);
            // 
            // btnExtract
            // 
            resources.ApplyResources(this.btnExtract, "btnExtract");
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // flpExtractLabels
            // 
            this.flpExtractLabels.Controls.Add(this.lblExtractZipPath);
            this.flpExtractLabels.Controls.Add(this.lblOutputFolder);
            this.flpExtractLabels.Controls.Add(this.lblPackageType);
            this.flpExtractLabels.Controls.Add(this.lblPackWrite);
            this.flpExtractLabels.Controls.Add(this.lblAllowDelete);
            this.flpExtractLabels.Controls.Add(this.lblExtractClobber);
            this.flpExtractLabels.Controls.Add(this.lblErrorLevel);
            this.flpExtractLabels.Controls.Add(this.lblExtractMap);
            this.flpExtractLabels.Controls.Add(this.lblExtractLogo);
            this.flpExtractLabels.Controls.Add(this.lblExtractLog);
            this.flpExtractLabels.Controls.Add(this.lblExtractArguments);
            this.flpExtractLabels.Controls.Add(this.lblExtractSourceLocale);
            this.flpExtractLabels.Controls.Add(this.lblExtractLocalize);
            this.flpExtractLabels.Controls.Add(this.lblExtractFormat);
            resources.ApplyResources(this.flpExtractLabels, "flpExtractLabels");
            this.flpExtractLabels.Name = "flpExtractLabels";
            // 
            // lblExtractZipPath
            // 
            resources.ApplyResources(this.lblExtractZipPath, "lblExtractZipPath");
            this.lblExtractZipPath.Name = "lblExtractZipPath";
            // 
            // lblOutputFolder
            // 
            resources.ApplyResources(this.lblOutputFolder, "lblOutputFolder");
            this.lblOutputFolder.Name = "lblOutputFolder";
            // 
            // lblPackageType
            // 
            resources.ApplyResources(this.lblPackageType, "lblPackageType");
            this.lblPackageType.Name = "lblPackageType";
            // 
            // lblPackWrite
            // 
            resources.ApplyResources(this.lblPackWrite, "lblPackWrite");
            this.lblPackWrite.Name = "lblPackWrite";
            // 
            // lblAllowDelete
            // 
            resources.ApplyResources(this.lblAllowDelete, "lblAllowDelete");
            this.lblAllowDelete.Name = "lblAllowDelete";
            // 
            // lblExtractClobber
            // 
            resources.ApplyResources(this.lblExtractClobber, "lblExtractClobber");
            this.lblExtractClobber.Name = "lblExtractClobber";
            // 
            // lblErrorLevel
            // 
            resources.ApplyResources(this.lblErrorLevel, "lblErrorLevel");
            this.lblErrorLevel.Name = "lblErrorLevel";
            // 
            // lblExtractMap
            // 
            resources.ApplyResources(this.lblExtractMap, "lblExtractMap");
            this.lblExtractMap.Name = "lblExtractMap";
            // 
            // lblExtractLogo
            // 
            resources.ApplyResources(this.lblExtractLogo, "lblExtractLogo");
            this.lblExtractLogo.Name = "lblExtractLogo";
            // 
            // lblExtractLog
            // 
            resources.ApplyResources(this.lblExtractLog, "lblExtractLog");
            this.lblExtractLog.Name = "lblExtractLog";
            // 
            // lblExtractArguments
            // 
            resources.ApplyResources(this.lblExtractArguments, "lblExtractArguments");
            this.lblExtractArguments.Name = "lblExtractArguments";
            // 
            // lblExtractSourceLocale
            // 
            resources.ApplyResources(this.lblExtractSourceLocale, "lblExtractSourceLocale");
            this.lblExtractSourceLocale.Name = "lblExtractSourceLocale";
            // 
            // lblExtractLocalize
            // 
            resources.ApplyResources(this.lblExtractLocalize, "lblExtractLocalize");
            this.lblExtractLocalize.Name = "lblExtractLocalize";
            // 
            // lblExtractFormat
            // 
            resources.ApplyResources(this.lblExtractFormat, "lblExtractFormat");
            this.lblExtractFormat.Name = "lblExtractFormat";
            // 
            // flpExtractControls
            // 
            this.flpExtractControls.Controls.Add(this.txtZipPath);
            this.flpExtractControls.Controls.Add(this.txtOutputFolder);
            this.flpExtractControls.Controls.Add(this.cmbPackageType);
            this.flpExtractControls.Controls.Add(this.chkAllowWrite);
            this.flpExtractControls.Controls.Add(this.flowLayoutPanel1);
            this.flpExtractControls.Controls.Add(this.chkClobber);
            this.flpExtractControls.Controls.Add(this.cmbErrorLevel);
            this.flpExtractControls.Controls.Add(this.txtExtractMap);
            this.flpExtractControls.Controls.Add(this.chkExtractNoLogo);
            this.flpExtractControls.Controls.Add(this.txtExtractLog);
            this.flpExtractControls.Controls.Add(this.txtExtractArguments);
            this.flpExtractControls.Controls.Add(this.cmbExtractSourceLocale);
            this.flpExtractControls.Controls.Add(this.chkLocalize);
            this.flpExtractControls.Controls.Add(this.chkFormatDocument);
            resources.ApplyResources(this.flpExtractControls, "flpExtractControls");
            this.flpExtractControls.Name = "flpExtractControls";
            // 
            // txtZipPath
            // 
            resources.ApplyResources(this.txtZipPath, "txtZipPath");
            this.txtZipPath.Name = "txtZipPath";
            this.txtZipPath.ReadOnly = true;
            this.txtZipPath.ShortcutsEnabled = false;
            this.txtZipPath.TabStop = false;
            // 
            // txtOutputFolder
            // 
            resources.ApplyResources(this.txtOutputFolder, "txtOutputFolder");
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.ShortcutsEnabled = false;
            this.txtOutputFolder.TabStop = false;
            // 
            // cmbPackageType
            // 
            this.cmbPackageType.DisplayMember = "FriendlyName";
            this.cmbPackageType.FormattingEnabled = true;
            this.cmbPackageType.Items.AddRange(new object[] {
            resources.GetString("cmbPackageType.Items"),
            resources.GetString("cmbPackageType.Items1"),
            resources.GetString("cmbPackageType.Items2"),
            resources.GetString("cmbPackageType.Items3")});
            resources.ApplyResources(this.cmbPackageType, "cmbPackageType");
            this.cmbPackageType.Name = "cmbPackageType";
            this.cmbPackageType.ValueMember = "SolutionId";
            // 
            // chkAllowWrite
            // 
            resources.ApplyResources(this.chkAllowWrite, "chkAllowWrite");
            this.chkAllowWrite.Checked = true;
            this.chkAllowWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowWrite.Name = "chkAllowWrite";
            this.chkAllowWrite.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radAllowDeletePrompt);
            this.flowLayoutPanel1.Controls.Add(this.radAllowDeleteYes);
            this.flowLayoutPanel1.Controls.Add(this.radAllowDeleteNo);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // radAllowDeletePrompt
            // 
            resources.ApplyResources(this.radAllowDeletePrompt, "radAllowDeletePrompt");
            this.radAllowDeletePrompt.Checked = true;
            this.radAllowDeletePrompt.Name = "radAllowDeletePrompt";
            this.radAllowDeletePrompt.TabStop = true;
            this.radAllowDeletePrompt.UseVisualStyleBackColor = true;
            // 
            // radAllowDeleteYes
            // 
            resources.ApplyResources(this.radAllowDeleteYes, "radAllowDeleteYes");
            this.radAllowDeleteYes.Name = "radAllowDeleteYes";
            this.radAllowDeleteYes.TabStop = true;
            this.radAllowDeleteYes.UseVisualStyleBackColor = true;
            // 
            // radAllowDeleteNo
            // 
            resources.ApplyResources(this.radAllowDeleteNo, "radAllowDeleteNo");
            this.radAllowDeleteNo.Name = "radAllowDeleteNo";
            this.radAllowDeleteNo.TabStop = true;
            this.radAllowDeleteNo.UseVisualStyleBackColor = true;
            // 
            // chkClobber
            // 
            resources.ApplyResources(this.chkClobber, "chkClobber");
            this.chkClobber.Name = "chkClobber";
            this.chkClobber.UseVisualStyleBackColor = true;
            // 
            // cmbErrorLevel
            // 
            this.cmbErrorLevel.DisplayMember = "FriendlyName";
            this.cmbErrorLevel.FormattingEnabled = true;
            this.cmbErrorLevel.Items.AddRange(new object[] {
            resources.GetString("cmbErrorLevel.Items"),
            resources.GetString("cmbErrorLevel.Items1"),
            resources.GetString("cmbErrorLevel.Items2"),
            resources.GetString("cmbErrorLevel.Items3"),
            resources.GetString("cmbErrorLevel.Items4")});
            resources.ApplyResources(this.cmbErrorLevel, "cmbErrorLevel");
            this.cmbErrorLevel.Name = "cmbErrorLevel";
            this.cmbErrorLevel.ValueMember = "SolutionId";
            // 
            // txtExtractMap
            // 
            resources.ApplyResources(this.txtExtractMap, "txtExtractMap");
            this.txtExtractMap.Name = "txtExtractMap";
            this.txtExtractMap.ReadOnly = true;
            this.txtExtractMap.ShortcutsEnabled = false;
            this.txtExtractMap.TabStop = false;
            // 
            // chkExtractNoLogo
            // 
            resources.ApplyResources(this.chkExtractNoLogo, "chkExtractNoLogo");
            this.chkExtractNoLogo.Name = "chkExtractNoLogo";
            this.chkExtractNoLogo.UseVisualStyleBackColor = true;
            // 
            // txtExtractLog
            // 
            resources.ApplyResources(this.txtExtractLog, "txtExtractLog");
            this.txtExtractLog.Name = "txtExtractLog";
            this.txtExtractLog.ReadOnly = true;
            this.txtExtractLog.ShortcutsEnabled = false;
            this.txtExtractLog.TabStop = false;
            // 
            // txtExtractArguments
            // 
            resources.ApplyResources(this.txtExtractArguments, "txtExtractArguments");
            this.txtExtractArguments.Name = "txtExtractArguments";
            this.txtExtractArguments.ReadOnly = true;
            this.txtExtractArguments.ShortcutsEnabled = false;
            this.txtExtractArguments.TabStop = false;
            // 
            // cmbExtractSourceLocale
            // 
            this.cmbExtractSourceLocale.DisplayMember = "FriendlyName";
            this.cmbExtractSourceLocale.FormattingEnabled = true;
            this.cmbExtractSourceLocale.Items.AddRange(new object[] {
            resources.GetString("cmbExtractSourceLocale.Items"),
            resources.GetString("cmbExtractSourceLocale.Items1"),
            resources.GetString("cmbExtractSourceLocale.Items2"),
            resources.GetString("cmbExtractSourceLocale.Items3"),
            resources.GetString("cmbExtractSourceLocale.Items4"),
            resources.GetString("cmbExtractSourceLocale.Items5"),
            resources.GetString("cmbExtractSourceLocale.Items6"),
            resources.GetString("cmbExtractSourceLocale.Items7"),
            resources.GetString("cmbExtractSourceLocale.Items8"),
            resources.GetString("cmbExtractSourceLocale.Items9"),
            resources.GetString("cmbExtractSourceLocale.Items10"),
            resources.GetString("cmbExtractSourceLocale.Items11"),
            resources.GetString("cmbExtractSourceLocale.Items12"),
            resources.GetString("cmbExtractSourceLocale.Items13"),
            resources.GetString("cmbExtractSourceLocale.Items14"),
            resources.GetString("cmbExtractSourceLocale.Items15"),
            resources.GetString("cmbExtractSourceLocale.Items16"),
            resources.GetString("cmbExtractSourceLocale.Items17"),
            resources.GetString("cmbExtractSourceLocale.Items18"),
            resources.GetString("cmbExtractSourceLocale.Items19"),
            resources.GetString("cmbExtractSourceLocale.Items20"),
            resources.GetString("cmbExtractSourceLocale.Items21"),
            resources.GetString("cmbExtractSourceLocale.Items22"),
            resources.GetString("cmbExtractSourceLocale.Items23"),
            resources.GetString("cmbExtractSourceLocale.Items24"),
            resources.GetString("cmbExtractSourceLocale.Items25"),
            resources.GetString("cmbExtractSourceLocale.Items26"),
            resources.GetString("cmbExtractSourceLocale.Items27"),
            resources.GetString("cmbExtractSourceLocale.Items28"),
            resources.GetString("cmbExtractSourceLocale.Items29"),
            resources.GetString("cmbExtractSourceLocale.Items30"),
            resources.GetString("cmbExtractSourceLocale.Items31"),
            resources.GetString("cmbExtractSourceLocale.Items32"),
            resources.GetString("cmbExtractSourceLocale.Items33"),
            resources.GetString("cmbExtractSourceLocale.Items34"),
            resources.GetString("cmbExtractSourceLocale.Items35"),
            resources.GetString("cmbExtractSourceLocale.Items36"),
            resources.GetString("cmbExtractSourceLocale.Items37"),
            resources.GetString("cmbExtractSourceLocale.Items38"),
            resources.GetString("cmbExtractSourceLocale.Items39"),
            resources.GetString("cmbExtractSourceLocale.Items40"),
            resources.GetString("cmbExtractSourceLocale.Items41"),
            resources.GetString("cmbExtractSourceLocale.Items42"),
            resources.GetString("cmbExtractSourceLocale.Items43"),
            resources.GetString("cmbExtractSourceLocale.Items44"),
            resources.GetString("cmbExtractSourceLocale.Items45"),
            resources.GetString("cmbExtractSourceLocale.Items46")});
            resources.ApplyResources(this.cmbExtractSourceLocale, "cmbExtractSourceLocale");
            this.cmbExtractSourceLocale.Name = "cmbExtractSourceLocale";
            this.cmbExtractSourceLocale.ValueMember = "SolutionId";
            // 
            // chkLocalize
            // 
            resources.ApplyResources(this.chkLocalize, "chkLocalize");
            this.chkLocalize.Name = "chkLocalize";
            this.toolTip.SetToolTip(this.chkLocalize, resources.GetString("chkLocalize.ToolTip"));
            this.chkLocalize.UseVisualStyleBackColor = true;
            // 
            // chkFormatDocument
            // 
            resources.ApplyResources(this.chkFormatDocument, "chkFormatDocument");
            this.chkFormatDocument.Checked = true;
            this.chkFormatDocument.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFormatDocument.Name = "chkFormatDocument";
            this.toolTip.SetToolTip(this.chkFormatDocument, resources.GetString("chkFormatDocument.ToolTip"));
            this.chkFormatDocument.UseVisualStyleBackColor = true;
            // 
            // flpExtractButtons
            // 
            this.flpExtractButtons.Controls.Add(this.btnOpenZip);
            this.flpExtractButtons.Controls.Add(this.btnOutputFolder);
            this.flpExtractButtons.Controls.Add(this.btnExtractMapFile);
            this.flpExtractButtons.Controls.Add(this.btnExtractLog);
            this.flpExtractButtons.Controls.Add(this.btnExtractArguments);
            resources.ApplyResources(this.flpExtractButtons, "flpExtractButtons");
            this.flpExtractButtons.Name = "flpExtractButtons";
            // 
            // btnOpenZip
            // 
            this.btnOpenZip.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            resources.ApplyResources(this.btnOpenZip, "btnOpenZip");
            this.btnOpenZip.Name = "btnOpenZip";
            this.btnOpenZip.UseVisualStyleBackColor = true;
            this.btnOpenZip.Click += new System.EventHandler(this.BtnOpenZip_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Folder;
            resources.ApplyResources(this.btnOutputFolder, "btnOutputFolder");
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.BtnOutputFolder_Click);
            // 
            // btnExtractMapFile
            // 
            this.btnExtractMapFile.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Code;
            resources.ApplyResources(this.btnExtractMapFile, "btnExtractMapFile");
            this.btnExtractMapFile.Name = "btnExtractMapFile";
            this.btnExtractMapFile.UseVisualStyleBackColor = true;
            // 
            // btnExtractLog
            // 
            this.btnExtractLog.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Log;
            resources.ApplyResources(this.btnExtractLog, "btnExtractLog");
            this.btnExtractLog.Name = "btnExtractLog";
            this.btnExtractLog.UseVisualStyleBackColor = true;
            // 
            // btnExtractArguments
            // 
            this.btnExtractArguments.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Command;
            resources.ApplyResources(this.btnExtractArguments, "btnExtractArguments");
            this.btnExtractArguments.Name = "btnExtractArguments";
            this.btnExtractArguments.UseVisualStyleBackColor = true;
            // 
            // tabPack
            // 
            this.tabPack.Controls.Add(this.tlpPack);
            resources.ApplyResources(this.tabPack, "tabPack");
            this.tabPack.Name = "tabPack";
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // tlpPack
            // 
            resources.ApplyResources(this.tlpPack, "tlpPack");
            this.tlpPack.Controls.Add(this.btnPack, 1, 1);
            this.tlpPack.Controls.Add(this.flpPackLabels, 0, 0);
            this.tlpPack.Controls.Add(this.flpPackControls, 1, 0);
            this.tlpPack.Controls.Add(this.flpPackButtons, 2, 0);
            this.tlpPack.Name = "tlpPack";
            // 
            // btnPack
            // 
            resources.ApplyResources(this.btnPack, "btnPack");
            this.btnPack.Name = "btnPack";
            this.btnPack.UseVisualStyleBackColor = true;
            // 
            // flpPackLabels
            // 
            this.flpPackLabels.Controls.Add(this.lblInputFolder);
            this.flpPackLabels.Controls.Add(this.lblOutputZip);
            this.flpPackLabels.Controls.Add(this.lblPackageTypePack);
            this.flpPackLabels.Controls.Add(this.lblErrorLevelPack);
            this.flpPackLabels.Controls.Add(this.lblPackMap);
            this.flpPackLabels.Controls.Add(this.lblNoLogoPack);
            this.flpPackLabels.Controls.Add(this.lblLogPack);
            this.flpPackLabels.Controls.Add(this.lblArgumentsPack);
            this.flpPackLabels.Controls.Add(this.lblLocalizePack);
            resources.ApplyResources(this.flpPackLabels, "flpPackLabels");
            this.flpPackLabels.Name = "flpPackLabels";
            // 
            // lblInputFolder
            // 
            resources.ApplyResources(this.lblInputFolder, "lblInputFolder");
            this.lblInputFolder.Name = "lblInputFolder";
            // 
            // lblOutputZip
            // 
            resources.ApplyResources(this.lblOutputZip, "lblOutputZip");
            this.lblOutputZip.Name = "lblOutputZip";
            // 
            // lblPackageTypePack
            // 
            resources.ApplyResources(this.lblPackageTypePack, "lblPackageTypePack");
            this.lblPackageTypePack.Name = "lblPackageTypePack";
            // 
            // lblErrorLevelPack
            // 
            resources.ApplyResources(this.lblErrorLevelPack, "lblErrorLevelPack");
            this.lblErrorLevelPack.Name = "lblErrorLevelPack";
            // 
            // lblPackMap
            // 
            resources.ApplyResources(this.lblPackMap, "lblPackMap");
            this.lblPackMap.Name = "lblPackMap";
            // 
            // lblNoLogoPack
            // 
            resources.ApplyResources(this.lblNoLogoPack, "lblNoLogoPack");
            this.lblNoLogoPack.Name = "lblNoLogoPack";
            // 
            // lblLogPack
            // 
            resources.ApplyResources(this.lblLogPack, "lblLogPack");
            this.lblLogPack.Name = "lblLogPack";
            // 
            // lblArgumentsPack
            // 
            resources.ApplyResources(this.lblArgumentsPack, "lblArgumentsPack");
            this.lblArgumentsPack.Name = "lblArgumentsPack";
            // 
            // lblLocalizePack
            // 
            resources.ApplyResources(this.lblLocalizePack, "lblLocalizePack");
            this.lblLocalizePack.Name = "lblLocalizePack";
            // 
            // flpPackControls
            // 
            this.flpPackControls.Controls.Add(this.txtPackFolder);
            this.flpPackControls.Controls.Add(this.txtPackZip);
            this.flpPackControls.Controls.Add(this.cmbPackPackageType);
            this.flpPackControls.Controls.Add(this.cmbPackErrorLevel);
            this.flpPackControls.Controls.Add(this.txtPackMap);
            this.flpPackControls.Controls.Add(this.chkPackNoLogo);
            this.flpPackControls.Controls.Add(this.txtPackLog);
            this.flpPackControls.Controls.Add(this.txtPackArguments);
            this.flpPackControls.Controls.Add(this.chkPackLocalize);
            resources.ApplyResources(this.flpPackControls, "flpPackControls");
            this.flpPackControls.Name = "flpPackControls";
            // 
            // txtPackFolder
            // 
            resources.ApplyResources(this.txtPackFolder, "txtPackFolder");
            this.txtPackFolder.Name = "txtPackFolder";
            this.txtPackFolder.ReadOnly = true;
            this.txtPackFolder.ShortcutsEnabled = false;
            this.txtPackFolder.TabStop = false;
            // 
            // txtPackZip
            // 
            resources.ApplyResources(this.txtPackZip, "txtPackZip");
            this.txtPackZip.Name = "txtPackZip";
            this.txtPackZip.ReadOnly = true;
            this.txtPackZip.ShortcutsEnabled = false;
            this.txtPackZip.TabStop = false;
            // 
            // cmbPackPackageType
            // 
            this.cmbPackPackageType.DisplayMember = "FriendlyName";
            this.cmbPackPackageType.FormattingEnabled = true;
            this.cmbPackPackageType.Items.AddRange(new object[] {
            resources.GetString("cmbPackPackageType.Items"),
            resources.GetString("cmbPackPackageType.Items1"),
            resources.GetString("cmbPackPackageType.Items2"),
            resources.GetString("cmbPackPackageType.Items3")});
            resources.ApplyResources(this.cmbPackPackageType, "cmbPackPackageType");
            this.cmbPackPackageType.Name = "cmbPackPackageType";
            this.cmbPackPackageType.ValueMember = "SolutionId";
            // 
            // cmbPackErrorLevel
            // 
            this.cmbPackErrorLevel.DisplayMember = "FriendlyName";
            this.cmbPackErrorLevel.FormattingEnabled = true;
            this.cmbPackErrorLevel.Items.AddRange(new object[] {
            resources.GetString("cmbPackErrorLevel.Items"),
            resources.GetString("cmbPackErrorLevel.Items1"),
            resources.GetString("cmbPackErrorLevel.Items2"),
            resources.GetString("cmbPackErrorLevel.Items3"),
            resources.GetString("cmbPackErrorLevel.Items4")});
            resources.ApplyResources(this.cmbPackErrorLevel, "cmbPackErrorLevel");
            this.cmbPackErrorLevel.Name = "cmbPackErrorLevel";
            this.cmbPackErrorLevel.ValueMember = "SolutionId";
            // 
            // txtPackMap
            // 
            resources.ApplyResources(this.txtPackMap, "txtPackMap");
            this.txtPackMap.Name = "txtPackMap";
            this.txtPackMap.ReadOnly = true;
            this.txtPackMap.ShortcutsEnabled = false;
            this.txtPackMap.TabStop = false;
            // 
            // chkPackNoLogo
            // 
            resources.ApplyResources(this.chkPackNoLogo, "chkPackNoLogo");
            this.chkPackNoLogo.Name = "chkPackNoLogo";
            this.chkPackNoLogo.UseVisualStyleBackColor = true;
            // 
            // txtPackLog
            // 
            resources.ApplyResources(this.txtPackLog, "txtPackLog");
            this.txtPackLog.Name = "txtPackLog";
            this.txtPackLog.ReadOnly = true;
            this.txtPackLog.ShortcutsEnabled = false;
            this.txtPackLog.TabStop = false;
            // 
            // txtPackArguments
            // 
            resources.ApplyResources(this.txtPackArguments, "txtPackArguments");
            this.txtPackArguments.Name = "txtPackArguments";
            this.txtPackArguments.ReadOnly = true;
            this.txtPackArguments.ShortcutsEnabled = false;
            this.txtPackArguments.TabStop = false;
            // 
            // chkPackLocalize
            // 
            resources.ApplyResources(this.chkPackLocalize, "chkPackLocalize");
            this.chkPackLocalize.Name = "chkPackLocalize";
            this.chkPackLocalize.UseVisualStyleBackColor = true;
            // 
            // flpPackButtons
            // 
            this.flpPackButtons.Controls.Add(this.btnInputFolder);
            this.flpPackButtons.Controls.Add(this.btnOutputZip);
            this.flpPackButtons.Controls.Add(this.btnPackMap);
            this.flpPackButtons.Controls.Add(this.btnLogPack);
            this.flpPackButtons.Controls.Add(this.btnArgumentsPack);
            resources.ApplyResources(this.flpPackButtons, "flpPackButtons");
            this.flpPackButtons.Name = "flpPackButtons";
            // 
            // btnInputFolder
            // 
            this.btnInputFolder.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Folder;
            resources.ApplyResources(this.btnInputFolder, "btnInputFolder");
            this.btnInputFolder.Name = "btnInputFolder";
            this.btnInputFolder.UseVisualStyleBackColor = true;
            // 
            // btnOutputZip
            // 
            this.btnOutputZip.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            resources.ApplyResources(this.btnOutputZip, "btnOutputZip");
            this.btnOutputZip.Name = "btnOutputZip";
            this.btnOutputZip.UseVisualStyleBackColor = true;
            // 
            // btnPackMap
            // 
            this.btnPackMap.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Code;
            resources.ApplyResources(this.btnPackMap, "btnPackMap");
            this.btnPackMap.Name = "btnPackMap";
            this.btnPackMap.UseVisualStyleBackColor = true;
            // 
            // btnLogPack
            // 
            this.btnLogPack.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Log;
            resources.ApplyResources(this.btnLogPack, "btnLogPack");
            this.btnLogPack.Name = "btnLogPack";
            this.btnLogPack.UseVisualStyleBackColor = true;
            // 
            // btnArgumentsPack
            // 
            this.btnArgumentsPack.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Command;
            resources.ApplyResources(this.btnArgumentsPack, "btnArgumentsPack");
            this.btnArgumentsPack.Name = "btnArgumentsPack";
            this.btnArgumentsPack.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tlpSettings);
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tlpSettings
            // 
            resources.ApplyResources(this.tlpSettings, "tlpSettings");
            this.tlpSettings.Controls.Add(this.btnSaveSettings, 1, 1);
            this.tlpSettings.Controls.Add(this.flpSettingsButtons, 2, 0);
            this.tlpSettings.Controls.Add(this.flpSettingsLabels, 0, 0);
            this.tlpSettings.Controls.Add(this.flpSettingsControls, 1, 0);
            this.tlpSettings.Name = "tlpSettings";
            // 
            // btnSaveSettings
            // 
            resources.ApplyResources(this.btnSaveSettings, "btnSaveSettings");
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // flpSettingsButtons
            // 
            this.flpSettingsButtons.Controls.Add(this.btnCoreTools);
            this.flpSettingsButtons.Controls.Add(this.btnNuGetFeed);
            resources.ApplyResources(this.flpSettingsButtons, "flpSettingsButtons");
            this.flpSettingsButtons.Name = "flpSettingsButtons";
            // 
            // btnCoreTools
            // 
            this.btnCoreTools.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Solutions;
            resources.ApplyResources(this.btnCoreTools, "btnCoreTools");
            this.btnCoreTools.Name = "btnCoreTools";
            this.btnCoreTools.UseVisualStyleBackColor = true;
            this.btnCoreTools.Click += new System.EventHandler(this.BtnCoreTools_Click);
            // 
            // btnNuGetFeed
            // 
            this.btnNuGetFeed.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Refresh;
            resources.ApplyResources(this.btnNuGetFeed, "btnNuGetFeed");
            this.btnNuGetFeed.Name = "btnNuGetFeed";
            this.btnNuGetFeed.UseVisualStyleBackColor = true;
            this.btnNuGetFeed.Click += new System.EventHandler(this.BtnNuGetFeed_Click);
            // 
            // flpSettingsLabels
            // 
            this.flpSettingsLabels.Controls.Add(this.lblCoreToolsVersion);
            this.flpSettingsLabels.Controls.Add(this.lblNuGetFeed);
            this.flpSettingsLabels.Controls.Add(this.lblLanguage);
            resources.ApplyResources(this.flpSettingsLabels, "flpSettingsLabels");
            this.flpSettingsLabels.Name = "flpSettingsLabels";
            // 
            // lblCoreToolsVersion
            // 
            resources.ApplyResources(this.lblCoreToolsVersion, "lblCoreToolsVersion");
            this.lblCoreToolsVersion.Name = "lblCoreToolsVersion";
            // 
            // lblNuGetFeed
            // 
            resources.ApplyResources(this.lblNuGetFeed, "lblNuGetFeed");
            this.lblNuGetFeed.Name = "lblNuGetFeed";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // flpSettingsControls
            // 
            this.flpSettingsControls.Controls.Add(this.txtCoreTools);
            this.flpSettingsControls.Controls.Add(this.txtNuGetFeed);
            this.flpSettingsControls.Controls.Add(this.cmbLanguage);
            resources.ApplyResources(this.flpSettingsControls, "flpSettingsControls");
            this.flpSettingsControls.Name = "flpSettingsControls";
            // 
            // txtCoreTools
            // 
            resources.ApplyResources(this.txtCoreTools, "txtCoreTools");
            this.txtCoreTools.Name = "txtCoreTools";
            this.txtCoreTools.ReadOnly = true;
            this.txtCoreTools.ShortcutsEnabled = false;
            this.txtCoreTools.TabStop = false;
            // 
            // txtNuGetFeed
            // 
            resources.ApplyResources(this.txtNuGetFeed, "txtNuGetFeed");
            this.txtNuGetFeed.Name = "txtNuGetFeed";
            this.txtNuGetFeed.ShortcutsEnabled = false;
            this.txtNuGetFeed.TabStop = false;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DisplayMember = "DisplayName";
            this.cmbLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.ValueMember = "Name";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguage_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openZipFile
            // 
            this.openZipFile.FileName = "openFileDialog1";
            resources.ApplyResources(this.openZipFile, "openZipFile");
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabsExtractOrPack);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtOutput);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txtOutput, "txtOutput");
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            // 
            // SolutionPackagerControl
            // 
            this.Controls.Add(this.splitContainer);
            this.Name = "SolutionPackagerControl";
            resources.ApplyResources(this, "$this");
            this.Load += new System.EventHandler(this.SolutionPackagerControl_Load);
            this.tabsExtractOrPack.ResumeLayout(false);
            this.tabExtract.ResumeLayout(false);
            this.tlpExtract.ResumeLayout(false);
            this.tlpExtract.PerformLayout();
            this.grpExportSolution.ResumeLayout(false);
            this.grpExportSolution.PerformLayout();
            this.flpExtractLabels.ResumeLayout(false);
            this.flpExtractLabels.PerformLayout();
            this.flpExtractControls.ResumeLayout(false);
            this.flpExtractControls.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flpExtractButtons.ResumeLayout(false);
            this.tabPack.ResumeLayout(false);
            this.tlpPack.ResumeLayout(false);
            this.flpPackLabels.ResumeLayout(false);
            this.flpPackLabels.PerformLayout();
            this.flpPackControls.ResumeLayout(false);
            this.flpPackControls.PerformLayout();
            this.flpPackButtons.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tlpSettings.ResumeLayout(false);
            this.flpSettingsButtons.ResumeLayout(false);
            this.flpSettingsLabels.ResumeLayout(false);
            this.flpSettingsLabels.PerformLayout();
            this.flpSettingsControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.TabControl tabsExtractOrPack;
        private System.Windows.Forms.TabPage tabExtract;
        private System.Windows.Forms.CheckBox localOrCrm;

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RichTextBox txtZipPath;
        private System.Windows.Forms.Label lblExtractZipPath;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.Label lblOnlineSolution;
        private System.Windows.Forms.ComboBox cmbCrmSolutions;
        private System.Windows.Forms.RichTextBox txtOutputFolder;
        private System.Windows.Forms.Button btnOpenZip;
        private System.Windows.Forms.Button btnRefreshSolutions;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabPack;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private System.Windows.Forms.OpenFileDialog openZipFile;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.GroupBox grpExportSolution;
        private System.Windows.Forms.CheckBox chkExportAutoNumbering;
        private System.Windows.Forms.CheckBox chkExportCalendar;
        private System.Windows.Forms.CheckBox chkExportEmailTracking;
        private System.Windows.Forms.CheckBox chkExportCustomization;
        private System.Windows.Forms.CheckBox chkExportExternalApplications;
        private System.Windows.Forms.CheckBox chkExportRelationshipRoles;
        private System.Windows.Forms.CheckBox chkExportSales;
        private System.Windows.Forms.CheckBox chkExportOutlookSynchronization;
        private System.Windows.Forms.CheckBox chkExportMarketing;
        private System.Windows.Forms.CheckBox chkExportISVConfig;
        private System.Windows.Forms.CheckBox chkExportGeneralSettings;
        private System.Windows.Forms.Label lblExportAs;
        private System.Windows.Forms.RadioButton radManaged;
        private System.Windows.Forms.RadioButton radUnmanaged;
        private System.Windows.Forms.CheckBox chkAllowWrite;
        private System.Windows.Forms.Label lblAllowDelete;
        private System.Windows.Forms.RadioButton radAllowDeletePrompt;
        private System.Windows.Forms.RadioButton radAllowDeleteYes;
        private System.Windows.Forms.RadioButton radAllowDeleteNo;
        private System.Windows.Forms.Label lblPackageType;
        private System.Windows.Forms.ComboBox cmbPackageType;
        private System.Windows.Forms.CheckBox chkClobber;
        private System.Windows.Forms.CheckBox chkExtractNoLogo;
        private System.Windows.Forms.Label lblErrorLevel;
        private System.Windows.Forms.ComboBox cmbErrorLevel;
        private System.Windows.Forms.CheckBox chkLocalize;
        private System.Windows.Forms.CheckBox chkFormatDocument;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tlpPack;
        private System.Windows.Forms.FlowLayoutPanel flpPackLabels;
        private System.Windows.Forms.Label lblInputFolder;
        private System.Windows.Forms.FlowLayoutPanel flpPackControls;
        private System.Windows.Forms.FlowLayoutPanel flpPackButtons;
        private System.Windows.Forms.RichTextBox txtPackFolder;
        private System.Windows.Forms.Button btnInputFolder;
        private System.Windows.Forms.Button btnOutputZip;
        private System.Windows.Forms.Label lblOutputZip;
        private System.Windows.Forms.RichTextBox txtPackZip;
        private System.Windows.Forms.ComboBox cmbPackPackageType;
        private System.Windows.Forms.Label lblPackageTypePack;
        private System.Windows.Forms.ComboBox cmbPackErrorLevel;
        private System.Windows.Forms.Label lblErrorLevelPack;
        private System.Windows.Forms.Label lblNoLogoPack;
        private System.Windows.Forms.CheckBox chkPackNoLogo;
        private System.Windows.Forms.Label lblLogPack;
        private System.Windows.Forms.RichTextBox txtPackLog;
        private System.Windows.Forms.Button btnLogPack;
        private System.Windows.Forms.RichTextBox txtPackArguments;
        private System.Windows.Forms.Label lblArgumentsPack;
        private System.Windows.Forms.Button btnArgumentsPack;
        private System.Windows.Forms.Label lblLocalizePack;
        private System.Windows.Forms.CheckBox chkPackLocalize;
        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.FlowLayoutPanel flpSettingsButtons;
        private System.Windows.Forms.FlowLayoutPanel flpSettingsLabels;
        private System.Windows.Forms.FlowLayoutPanel flpSettingsControls;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCoreTools;
        private System.Windows.Forms.Label lblCoreToolsVersion;
        private System.Windows.Forms.Label lblNuGetFeed;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.RichTextBox txtCoreTools;
        private System.Windows.Forms.RichTextBox txtNuGetFeed;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnNuGetFeed;
        private System.Windows.Forms.RichTextBox txtPackMap;
        private System.Windows.Forms.Label lblPackMap;
        private System.Windows.Forms.Button btnPackMap;
        private System.Windows.Forms.TableLayoutPanel tlpExtract;
        private System.Windows.Forms.FlowLayoutPanel flpExtractLabels;
        private System.Windows.Forms.FlowLayoutPanel flpExtractControls;
        private System.Windows.Forms.Label lblPackWrite;
        private System.Windows.Forms.Label lblExtractClobber;
        private System.Windows.Forms.FlowLayoutPanel flpExtractButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblExtractMap;
        private System.Windows.Forms.RichTextBox txtExtractMap;
        private System.Windows.Forms.Label lblExtractLogo;
        private System.Windows.Forms.Label lblExtractLocalize;
        private System.Windows.Forms.Label lblExtractFormat;
        private System.Windows.Forms.RichTextBox txtExtractLog;
        private System.Windows.Forms.RichTextBox txtExtractArguments;
        private System.Windows.Forms.Label lblExtractLog;
        private System.Windows.Forms.Label lblExtractArguments;
        private System.Windows.Forms.Label lblExtractSourceLocale;
        private System.Windows.Forms.ComboBox cmbExtractSourceLocale;
        private System.Windows.Forms.Button btnExtractMapFile;
        private System.Windows.Forms.Button btnExtractLog;
        private System.Windows.Forms.Button btnExtractArguments;
    }
}
