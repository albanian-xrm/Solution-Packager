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
            this.chkFormatDocument = new System.Windows.Forms.CheckBox();
            this.chkLocalize = new System.Windows.Forms.CheckBox();
            this.lblErrorLevel = new System.Windows.Forms.Label();
            this.cmbErrorLevel = new System.Windows.Forms.ComboBox();
            this.chkBanner = new System.Windows.Forms.CheckBox();
            this.chkClobber = new System.Windows.Forms.CheckBox();
            this.lblPackageType = new System.Windows.Forms.Label();
            this.deleteContainter = new System.Windows.Forms.Panel();
            this.radAllowDeletePrompt = new System.Windows.Forms.RadioButton();
            this.radAllowDeleteYes = new System.Windows.Forms.RadioButton();
            this.radAllowDeleteNo = new System.Windows.Forms.RadioButton();
            this.lblAllowDelete = new System.Windows.Forms.Label();
            this.cmbPackageType = new System.Windows.Forms.ComboBox();
            this.chkAllowWrite = new System.Windows.Forms.CheckBox();
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
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.btnOpenZip = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.RichTextBox();
            this.lblExtractZipPath = new System.Windows.Forms.Label();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.txtZipPath = new System.Windows.Forms.RichTextBox();
            this.localOrCrm = new System.Windows.Forms.CheckBox();
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
            this.deleteContainter.SuspendLayout();
            this.grpExportSolution.SuspendLayout();
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
            this.tabExtract.Controls.Add(this.chkFormatDocument);
            this.tabExtract.Controls.Add(this.chkLocalize);
            this.tabExtract.Controls.Add(this.lblErrorLevel);
            this.tabExtract.Controls.Add(this.cmbErrorLevel);
            this.tabExtract.Controls.Add(this.chkBanner);
            this.tabExtract.Controls.Add(this.chkClobber);
            this.tabExtract.Controls.Add(this.lblPackageType);
            this.tabExtract.Controls.Add(this.deleteContainter);
            this.tabExtract.Controls.Add(this.cmbPackageType);
            this.tabExtract.Controls.Add(this.chkAllowWrite);
            this.tabExtract.Controls.Add(this.grpExportSolution);
            this.tabExtract.Controls.Add(this.btnExtract);
            this.tabExtract.Controls.Add(this.btnOutputFolder);
            this.tabExtract.Controls.Add(this.btnOpenZip);
            this.tabExtract.Controls.Add(this.txtOutputFolder);
            this.tabExtract.Controls.Add(this.lblExtractZipPath);
            this.tabExtract.Controls.Add(this.lblOutputFolder);
            this.tabExtract.Controls.Add(this.txtZipPath);
            this.tabExtract.Controls.Add(this.localOrCrm);
            resources.ApplyResources(this.tabExtract, "tabExtract");
            this.tabExtract.Name = "tabExtract";
            this.tabExtract.UseVisualStyleBackColor = true;
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
            // chkLocalize
            // 
            resources.ApplyResources(this.chkLocalize, "chkLocalize");
            this.chkLocalize.Name = "chkLocalize";
            this.toolTip.SetToolTip(this.chkLocalize, resources.GetString("chkLocalize.ToolTip"));
            this.chkLocalize.UseVisualStyleBackColor = true;
            // 
            // lblErrorLevel
            // 
            resources.ApplyResources(this.lblErrorLevel, "lblErrorLevel");
            this.lblErrorLevel.Name = "lblErrorLevel";
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
            // chkBanner
            // 
            resources.ApplyResources(this.chkBanner, "chkBanner");
            this.chkBanner.Checked = true;
            this.chkBanner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBanner.Name = "chkBanner";
            this.chkBanner.UseVisualStyleBackColor = true;
            // 
            // chkClobber
            // 
            resources.ApplyResources(this.chkClobber, "chkClobber");
            this.chkClobber.Name = "chkClobber";
            this.chkClobber.UseVisualStyleBackColor = true;
            // 
            // lblPackageType
            // 
            resources.ApplyResources(this.lblPackageType, "lblPackageType");
            this.lblPackageType.Name = "lblPackageType";
            // 
            // deleteContainter
            // 
            this.deleteContainter.Controls.Add(this.radAllowDeletePrompt);
            this.deleteContainter.Controls.Add(this.radAllowDeleteYes);
            this.deleteContainter.Controls.Add(this.radAllowDeleteNo);
            this.deleteContainter.Controls.Add(this.lblAllowDelete);
            resources.ApplyResources(this.deleteContainter, "deleteContainter");
            this.deleteContainter.Name = "deleteContainter";
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
            // lblAllowDelete
            // 
            resources.ApplyResources(this.lblAllowDelete, "lblAllowDelete");
            this.lblAllowDelete.Name = "lblAllowDelete";
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
            // grpExportSolution
            // 
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
            // btnOutputFolder
            // 
            this.btnOutputFolder.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Folder;
            resources.ApplyResources(this.btnOutputFolder, "btnOutputFolder");
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.BtnOutputFolder_Click);
            // 
            // btnOpenZip
            // 
            this.btnOpenZip.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            resources.ApplyResources(this.btnOpenZip, "btnOpenZip");
            this.btnOpenZip.Name = "btnOpenZip";
            this.btnOpenZip.UseVisualStyleBackColor = true;
            this.btnOpenZip.Click += new System.EventHandler(this.BtnOpenZip_Click);
            // 
            // txtOutputFolder
            // 
            resources.ApplyResources(this.txtOutputFolder, "txtOutputFolder");
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.ShortcutsEnabled = false;
            this.txtOutputFolder.TabStop = false;
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
            // txtZipPath
            // 
            resources.ApplyResources(this.txtZipPath, "txtZipPath");
            this.txtZipPath.Name = "txtZipPath";
            this.txtZipPath.ReadOnly = true;
            this.txtZipPath.ShortcutsEnabled = false;
            this.txtZipPath.TabStop = false;
            // 
            // localOrCrm
            // 
            resources.ApplyResources(this.localOrCrm, "localOrCrm");
            this.localOrCrm.Name = "localOrCrm";
            this.localOrCrm.UseVisualStyleBackColor = true;
            this.localOrCrm.CheckedChanged += new System.EventHandler(this.LocalOrCrm_CheckedChanged);
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
            this.btnPackMap.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            resources.ApplyResources(this.btnPackMap, "btnPackMap");
            this.btnPackMap.Name = "btnPackMap";
            this.btnPackMap.UseVisualStyleBackColor = true;
            // 
            // btnLogPack
            // 
            this.btnLogPack.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            resources.ApplyResources(this.btnLogPack, "btnLogPack");
            this.btnLogPack.Name = "btnLogPack";
            this.btnLogPack.UseVisualStyleBackColor = true;
            // 
            // btnArgumentsPack
            // 
            this.btnArgumentsPack.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
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
            // 
            // btnNuGetFeed
            // 
            this.btnNuGetFeed.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Refresh;
            resources.ApplyResources(this.btnNuGetFeed, "btnNuGetFeed");
            this.btnNuGetFeed.Name = "btnNuGetFeed";
            this.btnNuGetFeed.UseVisualStyleBackColor = true;
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
            this.tabExtract.PerformLayout();
            this.deleteContainter.ResumeLayout(false);
            this.deleteContainter.PerformLayout();
            this.grpExportSolution.ResumeLayout(false);
            this.grpExportSolution.PerformLayout();
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
        private System.Windows.Forms.Panel deleteContainter;
        private System.Windows.Forms.Label lblAllowDelete;
        private System.Windows.Forms.RadioButton radAllowDeletePrompt;
        private System.Windows.Forms.RadioButton radAllowDeleteYes;
        private System.Windows.Forms.RadioButton radAllowDeleteNo;
        private System.Windows.Forms.Label lblPackageType;
        private System.Windows.Forms.ComboBox cmbPackageType;
        private System.Windows.Forms.CheckBox chkClobber;
        private System.Windows.Forms.CheckBox chkBanner;
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
    }
}
