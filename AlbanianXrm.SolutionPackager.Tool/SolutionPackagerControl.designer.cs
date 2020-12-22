namespace AlbanianXrm.SolutionPackager
{
    internal partial class SolutionPackagerControl
    {
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionPackagerControl));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
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
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.errorProvider.SetError(this.splitContainer, resources.GetString("splitContainer.Error"));
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.errorProvider.SetIconAlignment(this.splitContainer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("splitContainer.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.splitContainer, ((int)(resources.GetObject("splitContainer.IconPadding"))));
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
            this.splitContainer.Panel1.Controls.Add(this.tabsExtractOrPack);
            this.errorProvider.SetError(this.splitContainer.Panel1, resources.GetString("splitContainer.Panel1.Error"));
            this.errorProvider.SetIconAlignment(this.splitContainer.Panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("splitContainer.Panel1.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.splitContainer.Panel1, ((int)(resources.GetObject("splitContainer.Panel1.IconPadding"))));
            this.toolTip.SetToolTip(this.splitContainer.Panel1, resources.GetString("splitContainer.Panel1.ToolTip"));
            // 
            // splitContainer.Panel2
            // 
            resources.ApplyResources(this.splitContainer.Panel2, "splitContainer.Panel2");
            this.splitContainer.Panel2.Controls.Add(this.txtOutput);
            this.errorProvider.SetError(this.splitContainer.Panel2, resources.GetString("splitContainer.Panel2.Error"));
            this.errorProvider.SetIconAlignment(this.splitContainer.Panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("splitContainer.Panel2.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.splitContainer.Panel2, ((int)(resources.GetObject("splitContainer.Panel2.IconPadding"))));
            this.toolTip.SetToolTip(this.splitContainer.Panel2, resources.GetString("splitContainer.Panel2.ToolTip"));
            this.toolTip.SetToolTip(this.splitContainer, resources.GetString("splitContainer.ToolTip"));
            // 
            // tabsExtractOrPack
            // 
            resources.ApplyResources(this.tabsExtractOrPack, "tabsExtractOrPack");
            this.tabsExtractOrPack.Controls.Add(this.tabExtract);
            this.tabsExtractOrPack.Controls.Add(this.tabPack);
            this.tabsExtractOrPack.Controls.Add(this.tabSettings);
            this.errorProvider.SetError(this.tabsExtractOrPack, resources.GetString("tabsExtractOrPack.Error"));
            this.errorProvider.SetIconAlignment(this.tabsExtractOrPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabsExtractOrPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.tabsExtractOrPack, ((int)(resources.GetObject("tabsExtractOrPack.IconPadding"))));
            this.tabsExtractOrPack.Name = "tabsExtractOrPack";
            this.tabsExtractOrPack.SelectedIndex = 0;
            this.toolTip.SetToolTip(this.tabsExtractOrPack, resources.GetString("tabsExtractOrPack.ToolTip"));
            this.tabsExtractOrPack.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabsExtractOrPack_Selected);
            // 
            // tabExtract
            // 
            resources.ApplyResources(this.tabExtract, "tabExtract");
            this.tabExtract.Controls.Add(this.tlpExtract);
            this.errorProvider.SetError(this.tabExtract, resources.GetString("tabExtract.Error"));
            this.errorProvider.SetIconAlignment(this.tabExtract, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabExtract.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.tabExtract, ((int)(resources.GetObject("tabExtract.IconPadding"))));
            this.tabExtract.Name = "tabExtract";
            this.toolTip.SetToolTip(this.tabExtract, resources.GetString("tabExtract.ToolTip"));
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
            this.errorProvider.SetError(this.tlpExtract, resources.GetString("tlpExtract.Error"));
            this.errorProvider.SetIconAlignment(this.tlpExtract, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tlpExtract.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.tlpExtract, ((int)(resources.GetObject("tlpExtract.IconPadding"))));
            this.tlpExtract.Name = "tlpExtract";
            this.toolTip.SetToolTip(this.tlpExtract, resources.GetString("tlpExtract.ToolTip"));
            // 
            // localOrCrm
            // 
            resources.ApplyResources(this.localOrCrm, "localOrCrm");
            this.tlpExtract.SetColumnSpan(this.localOrCrm, 2);
            this.errorProvider.SetError(this.localOrCrm, resources.GetString("localOrCrm.Error"));
            this.errorProvider.SetIconAlignment(this.localOrCrm, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("localOrCrm.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.localOrCrm, ((int)(resources.GetObject("localOrCrm.IconPadding"))));
            this.localOrCrm.Name = "localOrCrm";
            this.toolTip.SetToolTip(this.localOrCrm, resources.GetString("localOrCrm.ToolTip"));
            this.localOrCrm.UseVisualStyleBackColor = true;
            this.localOrCrm.CheckedChanged += new System.EventHandler(this.LocalOrCrm_CheckedChanged);
            // 
            // grpExportSolution
            // 
            resources.ApplyResources(this.grpExportSolution, "grpExportSolution");
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
            this.errorProvider.SetError(this.grpExportSolution, resources.GetString("grpExportSolution.Error"));
            this.errorProvider.SetIconAlignment(this.grpExportSolution, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grpExportSolution.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.grpExportSolution, ((int)(resources.GetObject("grpExportSolution.IconPadding"))));
            this.grpExportSolution.Name = "grpExportSolution";
            this.grpExportSolution.TabStop = false;
            this.toolTip.SetToolTip(this.grpExportSolution, resources.GetString("grpExportSolution.ToolTip"));
            // 
            // lblExportAs
            // 
            resources.ApplyResources(this.lblExportAs, "lblExportAs");
            this.errorProvider.SetError(this.lblExportAs, resources.GetString("lblExportAs.Error"));
            this.errorProvider.SetIconAlignment(this.lblExportAs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExportAs.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExportAs, ((int)(resources.GetObject("lblExportAs.IconPadding"))));
            this.lblExportAs.Name = "lblExportAs";
            this.toolTip.SetToolTip(this.lblExportAs, resources.GetString("lblExportAs.ToolTip"));
            // 
            // radManaged
            // 
            resources.ApplyResources(this.radManaged, "radManaged");
            this.errorProvider.SetError(this.radManaged, resources.GetString("radManaged.Error"));
            this.errorProvider.SetIconAlignment(this.radManaged, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radManaged.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.radManaged, ((int)(resources.GetObject("radManaged.IconPadding"))));
            this.radManaged.Name = "radManaged";
            this.toolTip.SetToolTip(this.radManaged, resources.GetString("radManaged.ToolTip"));
            this.radManaged.UseVisualStyleBackColor = true;
            // 
            // radUnmanaged
            // 
            resources.ApplyResources(this.radUnmanaged, "radUnmanaged");
            this.radUnmanaged.Checked = true;
            this.errorProvider.SetError(this.radUnmanaged, resources.GetString("radUnmanaged.Error"));
            this.errorProvider.SetIconAlignment(this.radUnmanaged, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radUnmanaged.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.radUnmanaged, ((int)(resources.GetObject("radUnmanaged.IconPadding"))));
            this.radUnmanaged.Name = "radUnmanaged";
            this.radUnmanaged.TabStop = true;
            this.toolTip.SetToolTip(this.radUnmanaged, resources.GetString("radUnmanaged.ToolTip"));
            this.radUnmanaged.UseVisualStyleBackColor = true;
            // 
            // chkExportRelationshipRoles
            // 
            resources.ApplyResources(this.chkExportRelationshipRoles, "chkExportRelationshipRoles");
            this.errorProvider.SetError(this.chkExportRelationshipRoles, resources.GetString("chkExportRelationshipRoles.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportRelationshipRoles, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportRelationshipRoles.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportRelationshipRoles, ((int)(resources.GetObject("chkExportRelationshipRoles.IconPadding"))));
            this.chkExportRelationshipRoles.Name = "chkExportRelationshipRoles";
            this.toolTip.SetToolTip(this.chkExportRelationshipRoles, resources.GetString("chkExportRelationshipRoles.ToolTip"));
            this.chkExportRelationshipRoles.UseVisualStyleBackColor = true;
            // 
            // chkExportSales
            // 
            resources.ApplyResources(this.chkExportSales, "chkExportSales");
            this.errorProvider.SetError(this.chkExportSales, resources.GetString("chkExportSales.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportSales, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportSales.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportSales, ((int)(resources.GetObject("chkExportSales.IconPadding"))));
            this.chkExportSales.Name = "chkExportSales";
            this.toolTip.SetToolTip(this.chkExportSales, resources.GetString("chkExportSales.ToolTip"));
            this.chkExportSales.UseVisualStyleBackColor = true;
            // 
            // chkExportOutlookSynchronization
            // 
            resources.ApplyResources(this.chkExportOutlookSynchronization, "chkExportOutlookSynchronization");
            this.errorProvider.SetError(this.chkExportOutlookSynchronization, resources.GetString("chkExportOutlookSynchronization.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportOutlookSynchronization, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportOutlookSynchronization.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportOutlookSynchronization, ((int)(resources.GetObject("chkExportOutlookSynchronization.IconPadding"))));
            this.chkExportOutlookSynchronization.Name = "chkExportOutlookSynchronization";
            this.toolTip.SetToolTip(this.chkExportOutlookSynchronization, resources.GetString("chkExportOutlookSynchronization.ToolTip"));
            this.chkExportOutlookSynchronization.UseVisualStyleBackColor = true;
            // 
            // chkExportMarketing
            // 
            resources.ApplyResources(this.chkExportMarketing, "chkExportMarketing");
            this.errorProvider.SetError(this.chkExportMarketing, resources.GetString("chkExportMarketing.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportMarketing, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportMarketing.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportMarketing, ((int)(resources.GetObject("chkExportMarketing.IconPadding"))));
            this.chkExportMarketing.Name = "chkExportMarketing";
            this.toolTip.SetToolTip(this.chkExportMarketing, resources.GetString("chkExportMarketing.ToolTip"));
            this.chkExportMarketing.UseVisualStyleBackColor = true;
            // 
            // chkExportISVConfig
            // 
            resources.ApplyResources(this.chkExportISVConfig, "chkExportISVConfig");
            this.errorProvider.SetError(this.chkExportISVConfig, resources.GetString("chkExportISVConfig.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportISVConfig, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportISVConfig.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportISVConfig, ((int)(resources.GetObject("chkExportISVConfig.IconPadding"))));
            this.chkExportISVConfig.Name = "chkExportISVConfig";
            this.toolTip.SetToolTip(this.chkExportISVConfig, resources.GetString("chkExportISVConfig.ToolTip"));
            this.chkExportISVConfig.UseVisualStyleBackColor = true;
            // 
            // chkExportGeneralSettings
            // 
            resources.ApplyResources(this.chkExportGeneralSettings, "chkExportGeneralSettings");
            this.errorProvider.SetError(this.chkExportGeneralSettings, resources.GetString("chkExportGeneralSettings.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportGeneralSettings, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportGeneralSettings.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportGeneralSettings, ((int)(resources.GetObject("chkExportGeneralSettings.IconPadding"))));
            this.chkExportGeneralSettings.Name = "chkExportGeneralSettings";
            this.toolTip.SetToolTip(this.chkExportGeneralSettings, resources.GetString("chkExportGeneralSettings.ToolTip"));
            this.chkExportGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // chkExportExternalApplications
            // 
            resources.ApplyResources(this.chkExportExternalApplications, "chkExportExternalApplications");
            this.errorProvider.SetError(this.chkExportExternalApplications, resources.GetString("chkExportExternalApplications.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportExternalApplications, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportExternalApplications.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportExternalApplications, ((int)(resources.GetObject("chkExportExternalApplications.IconPadding"))));
            this.chkExportExternalApplications.Name = "chkExportExternalApplications";
            this.toolTip.SetToolTip(this.chkExportExternalApplications, resources.GetString("chkExportExternalApplications.ToolTip"));
            this.chkExportExternalApplications.UseVisualStyleBackColor = true;
            // 
            // chkExportEmailTracking
            // 
            resources.ApplyResources(this.chkExportEmailTracking, "chkExportEmailTracking");
            this.errorProvider.SetError(this.chkExportEmailTracking, resources.GetString("chkExportEmailTracking.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportEmailTracking, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportEmailTracking.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportEmailTracking, ((int)(resources.GetObject("chkExportEmailTracking.IconPadding"))));
            this.chkExportEmailTracking.Name = "chkExportEmailTracking";
            this.toolTip.SetToolTip(this.chkExportEmailTracking, resources.GetString("chkExportEmailTracking.ToolTip"));
            this.chkExportEmailTracking.UseVisualStyleBackColor = true;
            // 
            // chkExportCustomization
            // 
            resources.ApplyResources(this.chkExportCustomization, "chkExportCustomization");
            this.errorProvider.SetError(this.chkExportCustomization, resources.GetString("chkExportCustomization.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportCustomization, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportCustomization.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportCustomization, ((int)(resources.GetObject("chkExportCustomization.IconPadding"))));
            this.chkExportCustomization.Name = "chkExportCustomization";
            this.toolTip.SetToolTip(this.chkExportCustomization, resources.GetString("chkExportCustomization.ToolTip"));
            this.chkExportCustomization.UseVisualStyleBackColor = true;
            // 
            // chkExportCalendar
            // 
            resources.ApplyResources(this.chkExportCalendar, "chkExportCalendar");
            this.errorProvider.SetError(this.chkExportCalendar, resources.GetString("chkExportCalendar.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportCalendar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportCalendar.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportCalendar, ((int)(resources.GetObject("chkExportCalendar.IconPadding"))));
            this.chkExportCalendar.Name = "chkExportCalendar";
            this.toolTip.SetToolTip(this.chkExportCalendar, resources.GetString("chkExportCalendar.ToolTip"));
            this.chkExportCalendar.UseVisualStyleBackColor = true;
            // 
            // chkExportAutoNumbering
            // 
            resources.ApplyResources(this.chkExportAutoNumbering, "chkExportAutoNumbering");
            this.errorProvider.SetError(this.chkExportAutoNumbering, resources.GetString("chkExportAutoNumbering.Error"));
            this.errorProvider.SetIconAlignment(this.chkExportAutoNumbering, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExportAutoNumbering.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExportAutoNumbering, ((int)(resources.GetObject("chkExportAutoNumbering.IconPadding"))));
            this.chkExportAutoNumbering.Name = "chkExportAutoNumbering";
            this.toolTip.SetToolTip(this.chkExportAutoNumbering, resources.GetString("chkExportAutoNumbering.ToolTip"));
            this.chkExportAutoNumbering.UseVisualStyleBackColor = true;
            // 
            // lblOnlineSolution
            // 
            resources.ApplyResources(this.lblOnlineSolution, "lblOnlineSolution");
            this.errorProvider.SetError(this.lblOnlineSolution, resources.GetString("lblOnlineSolution.Error"));
            this.errorProvider.SetIconAlignment(this.lblOnlineSolution, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblOnlineSolution.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblOnlineSolution, ((int)(resources.GetObject("lblOnlineSolution.IconPadding"))));
            this.lblOnlineSolution.Name = "lblOnlineSolution";
            this.toolTip.SetToolTip(this.lblOnlineSolution, resources.GetString("lblOnlineSolution.ToolTip"));
            // 
            // cmbCrmSolutions
            // 
            resources.ApplyResources(this.cmbCrmSolutions, "cmbCrmSolutions");
            this.cmbCrmSolutions.DisplayMember = "FriendlyName";
            this.errorProvider.SetError(this.cmbCrmSolutions, resources.GetString("cmbCrmSolutions.Error"));
            this.cmbCrmSolutions.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cmbCrmSolutions, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbCrmSolutions.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cmbCrmSolutions, ((int)(resources.GetObject("cmbCrmSolutions.IconPadding"))));
            this.cmbCrmSolutions.Name = "cmbCrmSolutions";
            this.toolTip.SetToolTip(this.cmbCrmSolutions, resources.GetString("cmbCrmSolutions.ToolTip"));
            this.cmbCrmSolutions.ValueMember = "SolutionId";
            // 
            // btnRefreshSolutions
            // 
            resources.ApplyResources(this.btnRefreshSolutions, "btnRefreshSolutions");
            this.btnRefreshSolutions.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Solutions;
            this.errorProvider.SetError(this.btnRefreshSolutions, resources.GetString("btnRefreshSolutions.Error"));
            this.errorProvider.SetIconAlignment(this.btnRefreshSolutions, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnRefreshSolutions.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnRefreshSolutions, ((int)(resources.GetObject("btnRefreshSolutions.IconPadding"))));
            this.btnRefreshSolutions.Name = "btnRefreshSolutions";
            this.toolTip.SetToolTip(this.btnRefreshSolutions, resources.GetString("btnRefreshSolutions.ToolTip"));
            this.btnRefreshSolutions.UseVisualStyleBackColor = true;
            this.btnRefreshSolutions.Click += new System.EventHandler(this.BtnRefreshSolutions_Click);
            // 
            // btnExtract
            // 
            resources.ApplyResources(this.btnExtract, "btnExtract");
            this.errorProvider.SetError(this.btnExtract, resources.GetString("btnExtract.Error"));
            this.errorProvider.SetIconAlignment(this.btnExtract, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExtract.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnExtract, ((int)(resources.GetObject("btnExtract.IconPadding"))));
            this.btnExtract.Name = "btnExtract";
            this.toolTip.SetToolTip(this.btnExtract, resources.GetString("btnExtract.ToolTip"));
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // flpExtractLabels
            // 
            resources.ApplyResources(this.flpExtractLabels, "flpExtractLabels");
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
            this.errorProvider.SetError(this.flpExtractLabels, resources.GetString("flpExtractLabels.Error"));
            this.errorProvider.SetIconAlignment(this.flpExtractLabels, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpExtractLabels.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpExtractLabels, ((int)(resources.GetObject("flpExtractLabels.IconPadding"))));
            this.flpExtractLabels.Name = "flpExtractLabels";
            this.toolTip.SetToolTip(this.flpExtractLabels, resources.GetString("flpExtractLabels.ToolTip"));
            // 
            // lblExtractZipPath
            // 
            resources.ApplyResources(this.lblExtractZipPath, "lblExtractZipPath");
            this.errorProvider.SetError(this.lblExtractZipPath, resources.GetString("lblExtractZipPath.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractZipPath, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractZipPath.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractZipPath, ((int)(resources.GetObject("lblExtractZipPath.IconPadding"))));
            this.lblExtractZipPath.Name = "lblExtractZipPath";
            this.toolTip.SetToolTip(this.lblExtractZipPath, resources.GetString("lblExtractZipPath.ToolTip"));
            // 
            // lblOutputFolder
            // 
            resources.ApplyResources(this.lblOutputFolder, "lblOutputFolder");
            this.errorProvider.SetError(this.lblOutputFolder, resources.GetString("lblOutputFolder.Error"));
            this.errorProvider.SetIconAlignment(this.lblOutputFolder, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblOutputFolder.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblOutputFolder, ((int)(resources.GetObject("lblOutputFolder.IconPadding"))));
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.toolTip.SetToolTip(this.lblOutputFolder, resources.GetString("lblOutputFolder.ToolTip"));
            // 
            // lblPackageType
            // 
            resources.ApplyResources(this.lblPackageType, "lblPackageType");
            this.errorProvider.SetError(this.lblPackageType, resources.GetString("lblPackageType.Error"));
            this.errorProvider.SetIconAlignment(this.lblPackageType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPackageType.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblPackageType, ((int)(resources.GetObject("lblPackageType.IconPadding"))));
            this.lblPackageType.Name = "lblPackageType";
            this.toolTip.SetToolTip(this.lblPackageType, resources.GetString("lblPackageType.ToolTip"));
            // 
            // lblPackWrite
            // 
            resources.ApplyResources(this.lblPackWrite, "lblPackWrite");
            this.errorProvider.SetError(this.lblPackWrite, resources.GetString("lblPackWrite.Error"));
            this.errorProvider.SetIconAlignment(this.lblPackWrite, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPackWrite.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblPackWrite, ((int)(resources.GetObject("lblPackWrite.IconPadding"))));
            this.lblPackWrite.Name = "lblPackWrite";
            this.toolTip.SetToolTip(this.lblPackWrite, resources.GetString("lblPackWrite.ToolTip"));
            // 
            // lblAllowDelete
            // 
            resources.ApplyResources(this.lblAllowDelete, "lblAllowDelete");
            this.errorProvider.SetError(this.lblAllowDelete, resources.GetString("lblAllowDelete.Error"));
            this.errorProvider.SetIconAlignment(this.lblAllowDelete, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAllowDelete.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblAllowDelete, ((int)(resources.GetObject("lblAllowDelete.IconPadding"))));
            this.lblAllowDelete.Name = "lblAllowDelete";
            this.toolTip.SetToolTip(this.lblAllowDelete, resources.GetString("lblAllowDelete.ToolTip"));
            // 
            // lblExtractClobber
            // 
            resources.ApplyResources(this.lblExtractClobber, "lblExtractClobber");
            this.errorProvider.SetError(this.lblExtractClobber, resources.GetString("lblExtractClobber.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractClobber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractClobber.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractClobber, ((int)(resources.GetObject("lblExtractClobber.IconPadding"))));
            this.lblExtractClobber.Name = "lblExtractClobber";
            this.toolTip.SetToolTip(this.lblExtractClobber, resources.GetString("lblExtractClobber.ToolTip"));
            // 
            // lblErrorLevel
            // 
            resources.ApplyResources(this.lblErrorLevel, "lblErrorLevel");
            this.errorProvider.SetError(this.lblErrorLevel, resources.GetString("lblErrorLevel.Error"));
            this.errorProvider.SetIconAlignment(this.lblErrorLevel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblErrorLevel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblErrorLevel, ((int)(resources.GetObject("lblErrorLevel.IconPadding"))));
            this.lblErrorLevel.Name = "lblErrorLevel";
            this.toolTip.SetToolTip(this.lblErrorLevel, resources.GetString("lblErrorLevel.ToolTip"));
            // 
            // lblExtractMap
            // 
            resources.ApplyResources(this.lblExtractMap, "lblExtractMap");
            this.errorProvider.SetError(this.lblExtractMap, resources.GetString("lblExtractMap.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractMap, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractMap.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractMap, ((int)(resources.GetObject("lblExtractMap.IconPadding"))));
            this.lblExtractMap.Name = "lblExtractMap";
            this.toolTip.SetToolTip(this.lblExtractMap, resources.GetString("lblExtractMap.ToolTip"));
            // 
            // lblExtractLogo
            // 
            resources.ApplyResources(this.lblExtractLogo, "lblExtractLogo");
            this.errorProvider.SetError(this.lblExtractLogo, resources.GetString("lblExtractLogo.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractLogo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractLogo.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractLogo, ((int)(resources.GetObject("lblExtractLogo.IconPadding"))));
            this.lblExtractLogo.Name = "lblExtractLogo";
            this.toolTip.SetToolTip(this.lblExtractLogo, resources.GetString("lblExtractLogo.ToolTip"));
            // 
            // lblExtractLog
            // 
            resources.ApplyResources(this.lblExtractLog, "lblExtractLog");
            this.errorProvider.SetError(this.lblExtractLog, resources.GetString("lblExtractLog.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractLog, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractLog.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractLog, ((int)(resources.GetObject("lblExtractLog.IconPadding"))));
            this.lblExtractLog.Name = "lblExtractLog";
            this.toolTip.SetToolTip(this.lblExtractLog, resources.GetString("lblExtractLog.ToolTip"));
            // 
            // lblExtractArguments
            // 
            resources.ApplyResources(this.lblExtractArguments, "lblExtractArguments");
            this.errorProvider.SetError(this.lblExtractArguments, resources.GetString("lblExtractArguments.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractArguments, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractArguments.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractArguments, ((int)(resources.GetObject("lblExtractArguments.IconPadding"))));
            this.lblExtractArguments.Name = "lblExtractArguments";
            this.toolTip.SetToolTip(this.lblExtractArguments, resources.GetString("lblExtractArguments.ToolTip"));
            // 
            // lblExtractSourceLocale
            // 
            resources.ApplyResources(this.lblExtractSourceLocale, "lblExtractSourceLocale");
            this.errorProvider.SetError(this.lblExtractSourceLocale, resources.GetString("lblExtractSourceLocale.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractSourceLocale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractSourceLocale.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractSourceLocale, ((int)(resources.GetObject("lblExtractSourceLocale.IconPadding"))));
            this.lblExtractSourceLocale.Name = "lblExtractSourceLocale";
            this.toolTip.SetToolTip(this.lblExtractSourceLocale, resources.GetString("lblExtractSourceLocale.ToolTip"));
            // 
            // lblExtractLocalize
            // 
            resources.ApplyResources(this.lblExtractLocalize, "lblExtractLocalize");
            this.errorProvider.SetError(this.lblExtractLocalize, resources.GetString("lblExtractLocalize.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractLocalize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractLocalize.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractLocalize, ((int)(resources.GetObject("lblExtractLocalize.IconPadding"))));
            this.lblExtractLocalize.Name = "lblExtractLocalize";
            this.toolTip.SetToolTip(this.lblExtractLocalize, resources.GetString("lblExtractLocalize.ToolTip"));
            // 
            // lblExtractFormat
            // 
            resources.ApplyResources(this.lblExtractFormat, "lblExtractFormat");
            this.errorProvider.SetError(this.lblExtractFormat, resources.GetString("lblExtractFormat.Error"));
            this.errorProvider.SetIconAlignment(this.lblExtractFormat, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblExtractFormat.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblExtractFormat, ((int)(resources.GetObject("lblExtractFormat.IconPadding"))));
            this.lblExtractFormat.Name = "lblExtractFormat";
            this.toolTip.SetToolTip(this.lblExtractFormat, resources.GetString("lblExtractFormat.ToolTip"));
            // 
            // flpExtractControls
            // 
            resources.ApplyResources(this.flpExtractControls, "flpExtractControls");
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
            this.errorProvider.SetError(this.flpExtractControls, resources.GetString("flpExtractControls.Error"));
            this.errorProvider.SetIconAlignment(this.flpExtractControls, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpExtractControls.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpExtractControls, ((int)(resources.GetObject("flpExtractControls.IconPadding"))));
            this.flpExtractControls.Name = "flpExtractControls";
            this.toolTip.SetToolTip(this.flpExtractControls, resources.GetString("flpExtractControls.ToolTip"));
            // 
            // txtZipPath
            // 
            resources.ApplyResources(this.txtZipPath, "txtZipPath");
            this.errorProvider.SetError(this.txtZipPath, resources.GetString("txtZipPath.Error"));
            this.errorProvider.SetIconAlignment(this.txtZipPath, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtZipPath.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtZipPath, ((int)(resources.GetObject("txtZipPath.IconPadding"))));
            this.txtZipPath.Name = "txtZipPath";
            this.txtZipPath.ReadOnly = true;
            this.txtZipPath.ShortcutsEnabled = false;
            this.txtZipPath.TabStop = false;
            this.toolTip.SetToolTip(this.txtZipPath, resources.GetString("txtZipPath.ToolTip"));
            // 
            // txtOutputFolder
            // 
            resources.ApplyResources(this.txtOutputFolder, "txtOutputFolder");
            this.errorProvider.SetError(this.txtOutputFolder, resources.GetString("txtOutputFolder.Error"));
            this.errorProvider.SetIconAlignment(this.txtOutputFolder, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtOutputFolder.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtOutputFolder, ((int)(resources.GetObject("txtOutputFolder.IconPadding"))));
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.ShortcutsEnabled = false;
            this.txtOutputFolder.TabStop = false;
            this.toolTip.SetToolTip(this.txtOutputFolder, resources.GetString("txtOutputFolder.ToolTip"));
            // 
            // cmbPackageType
            // 
            resources.ApplyResources(this.cmbPackageType, "cmbPackageType");
            this.cmbPackageType.DisplayMember = "FriendlyName";
            this.errorProvider.SetError(this.cmbPackageType, resources.GetString("cmbPackageType.Error"));
            this.cmbPackageType.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cmbPackageType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbPackageType.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cmbPackageType, ((int)(resources.GetObject("cmbPackageType.IconPadding"))));
            this.cmbPackageType.Items.AddRange(new object[] {
            resources.GetString("cmbPackageType.Items"),
            resources.GetString("cmbPackageType.Items1"),
            resources.GetString("cmbPackageType.Items2"),
            resources.GetString("cmbPackageType.Items3")});
            this.cmbPackageType.Name = "cmbPackageType";
            this.toolTip.SetToolTip(this.cmbPackageType, resources.GetString("cmbPackageType.ToolTip"));
            this.cmbPackageType.ValueMember = "SolutionId";
            // 
            // chkAllowWrite
            // 
            resources.ApplyResources(this.chkAllowWrite, "chkAllowWrite");
            this.chkAllowWrite.Checked = true;
            this.chkAllowWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider.SetError(this.chkAllowWrite, resources.GetString("chkAllowWrite.Error"));
            this.errorProvider.SetIconAlignment(this.chkAllowWrite, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkAllowWrite.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkAllowWrite, ((int)(resources.GetObject("chkAllowWrite.IconPadding"))));
            this.chkAllowWrite.Name = "chkAllowWrite";
            this.toolTip.SetToolTip(this.chkAllowWrite, resources.GetString("chkAllowWrite.ToolTip"));
            this.chkAllowWrite.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.radAllowDeletePrompt);
            this.flowLayoutPanel1.Controls.Add(this.radAllowDeleteYes);
            this.flowLayoutPanel1.Controls.Add(this.radAllowDeleteNo);
            this.errorProvider.SetError(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.Error"));
            this.errorProvider.SetIconAlignment(this.flowLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flowLayoutPanel1.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flowLayoutPanel1, ((int)(resources.GetObject("flowLayoutPanel1.IconPadding"))));
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // radAllowDeletePrompt
            // 
            resources.ApplyResources(this.radAllowDeletePrompt, "radAllowDeletePrompt");
            this.radAllowDeletePrompt.Checked = true;
            this.errorProvider.SetError(this.radAllowDeletePrompt, resources.GetString("radAllowDeletePrompt.Error"));
            this.errorProvider.SetIconAlignment(this.radAllowDeletePrompt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radAllowDeletePrompt.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.radAllowDeletePrompt, ((int)(resources.GetObject("radAllowDeletePrompt.IconPadding"))));
            this.radAllowDeletePrompt.Name = "radAllowDeletePrompt";
            this.radAllowDeletePrompt.TabStop = true;
            this.toolTip.SetToolTip(this.radAllowDeletePrompt, resources.GetString("radAllowDeletePrompt.ToolTip"));
            this.radAllowDeletePrompt.UseVisualStyleBackColor = true;
            // 
            // radAllowDeleteYes
            // 
            resources.ApplyResources(this.radAllowDeleteYes, "radAllowDeleteYes");
            this.errorProvider.SetError(this.radAllowDeleteYes, resources.GetString("radAllowDeleteYes.Error"));
            this.errorProvider.SetIconAlignment(this.radAllowDeleteYes, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radAllowDeleteYes.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.radAllowDeleteYes, ((int)(resources.GetObject("radAllowDeleteYes.IconPadding"))));
            this.radAllowDeleteYes.Name = "radAllowDeleteYes";
            this.radAllowDeleteYes.TabStop = true;
            this.toolTip.SetToolTip(this.radAllowDeleteYes, resources.GetString("radAllowDeleteYes.ToolTip"));
            this.radAllowDeleteYes.UseVisualStyleBackColor = true;
            // 
            // radAllowDeleteNo
            // 
            resources.ApplyResources(this.radAllowDeleteNo, "radAllowDeleteNo");
            this.errorProvider.SetError(this.radAllowDeleteNo, resources.GetString("radAllowDeleteNo.Error"));
            this.errorProvider.SetIconAlignment(this.radAllowDeleteNo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radAllowDeleteNo.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.radAllowDeleteNo, ((int)(resources.GetObject("radAllowDeleteNo.IconPadding"))));
            this.radAllowDeleteNo.Name = "radAllowDeleteNo";
            this.radAllowDeleteNo.TabStop = true;
            this.toolTip.SetToolTip(this.radAllowDeleteNo, resources.GetString("radAllowDeleteNo.ToolTip"));
            this.radAllowDeleteNo.UseVisualStyleBackColor = true;
            // 
            // chkClobber
            // 
            resources.ApplyResources(this.chkClobber, "chkClobber");
            this.errorProvider.SetError(this.chkClobber, resources.GetString("chkClobber.Error"));
            this.errorProvider.SetIconAlignment(this.chkClobber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkClobber.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkClobber, ((int)(resources.GetObject("chkClobber.IconPadding"))));
            this.chkClobber.Name = "chkClobber";
            this.toolTip.SetToolTip(this.chkClobber, resources.GetString("chkClobber.ToolTip"));
            this.chkClobber.UseVisualStyleBackColor = true;
            // 
            // cmbErrorLevel
            // 
            resources.ApplyResources(this.cmbErrorLevel, "cmbErrorLevel");
            this.cmbErrorLevel.DisplayMember = "FriendlyName";
            this.errorProvider.SetError(this.cmbErrorLevel, resources.GetString("cmbErrorLevel.Error"));
            this.cmbErrorLevel.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cmbErrorLevel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbErrorLevel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cmbErrorLevel, ((int)(resources.GetObject("cmbErrorLevel.IconPadding"))));
            this.cmbErrorLevel.Items.AddRange(new object[] {
            resources.GetString("cmbErrorLevel.Items"),
            resources.GetString("cmbErrorLevel.Items1"),
            resources.GetString("cmbErrorLevel.Items2"),
            resources.GetString("cmbErrorLevel.Items3"),
            resources.GetString("cmbErrorLevel.Items4"),
            resources.GetString("cmbErrorLevel.Items5")});
            this.cmbErrorLevel.Name = "cmbErrorLevel";
            this.toolTip.SetToolTip(this.cmbErrorLevel, resources.GetString("cmbErrorLevel.ToolTip"));
            this.cmbErrorLevel.ValueMember = "SolutionId";
            // 
            // txtExtractMap
            // 
            resources.ApplyResources(this.txtExtractMap, "txtExtractMap");
            this.errorProvider.SetError(this.txtExtractMap, resources.GetString("txtExtractMap.Error"));
            this.errorProvider.SetIconAlignment(this.txtExtractMap, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtExtractMap.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtExtractMap, ((int)(resources.GetObject("txtExtractMap.IconPadding"))));
            this.txtExtractMap.Name = "txtExtractMap";
            this.txtExtractMap.ReadOnly = true;
            this.txtExtractMap.ShortcutsEnabled = false;
            this.txtExtractMap.TabStop = false;
            this.toolTip.SetToolTip(this.txtExtractMap, resources.GetString("txtExtractMap.ToolTip"));
            // 
            // chkExtractNoLogo
            // 
            resources.ApplyResources(this.chkExtractNoLogo, "chkExtractNoLogo");
            this.errorProvider.SetError(this.chkExtractNoLogo, resources.GetString("chkExtractNoLogo.Error"));
            this.errorProvider.SetIconAlignment(this.chkExtractNoLogo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkExtractNoLogo.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkExtractNoLogo, ((int)(resources.GetObject("chkExtractNoLogo.IconPadding"))));
            this.chkExtractNoLogo.Name = "chkExtractNoLogo";
            this.toolTip.SetToolTip(this.chkExtractNoLogo, resources.GetString("chkExtractNoLogo.ToolTip"));
            this.chkExtractNoLogo.UseVisualStyleBackColor = true;
            // 
            // txtExtractLog
            // 
            resources.ApplyResources(this.txtExtractLog, "txtExtractLog");
            this.errorProvider.SetError(this.txtExtractLog, resources.GetString("txtExtractLog.Error"));
            this.errorProvider.SetIconAlignment(this.txtExtractLog, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtExtractLog.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtExtractLog, ((int)(resources.GetObject("txtExtractLog.IconPadding"))));
            this.txtExtractLog.Name = "txtExtractLog";
            this.txtExtractLog.ReadOnly = true;
            this.txtExtractLog.ShortcutsEnabled = false;
            this.txtExtractLog.TabStop = false;
            this.toolTip.SetToolTip(this.txtExtractLog, resources.GetString("txtExtractLog.ToolTip"));
            // 
            // txtExtractArguments
            // 
            resources.ApplyResources(this.txtExtractArguments, "txtExtractArguments");
            this.errorProvider.SetError(this.txtExtractArguments, resources.GetString("txtExtractArguments.Error"));
            this.errorProvider.SetIconAlignment(this.txtExtractArguments, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtExtractArguments.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtExtractArguments, ((int)(resources.GetObject("txtExtractArguments.IconPadding"))));
            this.txtExtractArguments.Name = "txtExtractArguments";
            this.txtExtractArguments.ReadOnly = true;
            this.txtExtractArguments.ShortcutsEnabled = false;
            this.txtExtractArguments.TabStop = false;
            this.toolTip.SetToolTip(this.txtExtractArguments, resources.GetString("txtExtractArguments.ToolTip"));
            // 
            // cmbExtractSourceLocale
            // 
            resources.ApplyResources(this.cmbExtractSourceLocale, "cmbExtractSourceLocale");
            this.cmbExtractSourceLocale.DisplayMember = "FriendlyName";
            this.errorProvider.SetError(this.cmbExtractSourceLocale, resources.GetString("cmbExtractSourceLocale.Error"));
            this.cmbExtractSourceLocale.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cmbExtractSourceLocale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbExtractSourceLocale.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cmbExtractSourceLocale, ((int)(resources.GetObject("cmbExtractSourceLocale.IconPadding"))));
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
            this.cmbExtractSourceLocale.Name = "cmbExtractSourceLocale";
            this.toolTip.SetToolTip(this.cmbExtractSourceLocale, resources.GetString("cmbExtractSourceLocale.ToolTip"));
            this.cmbExtractSourceLocale.ValueMember = "SolutionId";
            // 
            // chkLocalize
            // 
            resources.ApplyResources(this.chkLocalize, "chkLocalize");
            this.errorProvider.SetError(this.chkLocalize, resources.GetString("chkLocalize.Error"));
            this.errorProvider.SetIconAlignment(this.chkLocalize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkLocalize.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkLocalize, ((int)(resources.GetObject("chkLocalize.IconPadding"))));
            this.chkLocalize.Name = "chkLocalize";
            this.toolTip.SetToolTip(this.chkLocalize, resources.GetString("chkLocalize.ToolTip"));
            this.chkLocalize.UseVisualStyleBackColor = true;
            // 
            // chkFormatDocument
            // 
            resources.ApplyResources(this.chkFormatDocument, "chkFormatDocument");
            this.chkFormatDocument.Checked = true;
            this.chkFormatDocument.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider.SetError(this.chkFormatDocument, resources.GetString("chkFormatDocument.Error"));
            this.errorProvider.SetIconAlignment(this.chkFormatDocument, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkFormatDocument.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkFormatDocument, ((int)(resources.GetObject("chkFormatDocument.IconPadding"))));
            this.chkFormatDocument.Name = "chkFormatDocument";
            this.toolTip.SetToolTip(this.chkFormatDocument, resources.GetString("chkFormatDocument.ToolTip"));
            this.chkFormatDocument.UseVisualStyleBackColor = true;
            // 
            // flpExtractButtons
            // 
            resources.ApplyResources(this.flpExtractButtons, "flpExtractButtons");
            this.flpExtractButtons.Controls.Add(this.btnOpenZip);
            this.flpExtractButtons.Controls.Add(this.btnOutputFolder);
            this.flpExtractButtons.Controls.Add(this.btnExtractMapFile);
            this.flpExtractButtons.Controls.Add(this.btnExtractLog);
            this.flpExtractButtons.Controls.Add(this.btnExtractArguments);
            this.errorProvider.SetError(this.flpExtractButtons, resources.GetString("flpExtractButtons.Error"));
            this.errorProvider.SetIconAlignment(this.flpExtractButtons, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpExtractButtons.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpExtractButtons, ((int)(resources.GetObject("flpExtractButtons.IconPadding"))));
            this.flpExtractButtons.Name = "flpExtractButtons";
            this.toolTip.SetToolTip(this.flpExtractButtons, resources.GetString("flpExtractButtons.ToolTip"));
            // 
            // btnOpenZip
            // 
            resources.ApplyResources(this.btnOpenZip, "btnOpenZip");
            this.btnOpenZip.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            this.errorProvider.SetError(this.btnOpenZip, resources.GetString("btnOpenZip.Error"));
            this.errorProvider.SetIconAlignment(this.btnOpenZip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOpenZip.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnOpenZip, ((int)(resources.GetObject("btnOpenZip.IconPadding"))));
            this.btnOpenZip.Name = "btnOpenZip";
            this.toolTip.SetToolTip(this.btnOpenZip, resources.GetString("btnOpenZip.ToolTip"));
            this.btnOpenZip.UseVisualStyleBackColor = true;
            this.btnOpenZip.Click += new System.EventHandler(this.BtnOpenZip_Click);
            // 
            // btnOutputFolder
            // 
            resources.ApplyResources(this.btnOutputFolder, "btnOutputFolder");
            this.btnOutputFolder.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Folder;
            this.errorProvider.SetError(this.btnOutputFolder, resources.GetString("btnOutputFolder.Error"));
            this.errorProvider.SetIconAlignment(this.btnOutputFolder, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOutputFolder.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnOutputFolder, ((int)(resources.GetObject("btnOutputFolder.IconPadding"))));
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.toolTip.SetToolTip(this.btnOutputFolder, resources.GetString("btnOutputFolder.ToolTip"));
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.BtnOutputFolder_Click);
            // 
            // btnExtractMapFile
            // 
            resources.ApplyResources(this.btnExtractMapFile, "btnExtractMapFile");
            this.btnExtractMapFile.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Code;
            this.errorProvider.SetError(this.btnExtractMapFile, resources.GetString("btnExtractMapFile.Error"));
            this.errorProvider.SetIconAlignment(this.btnExtractMapFile, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExtractMapFile.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnExtractMapFile, ((int)(resources.GetObject("btnExtractMapFile.IconPadding"))));
            this.btnExtractMapFile.Name = "btnExtractMapFile";
            this.toolTip.SetToolTip(this.btnExtractMapFile, resources.GetString("btnExtractMapFile.ToolTip"));
            this.btnExtractMapFile.UseVisualStyleBackColor = true;
            this.btnExtractMapFile.Click += new System.EventHandler(this.BtnExtractMapFile_Click);
            // 
            // btnExtractLog
            // 
            resources.ApplyResources(this.btnExtractLog, "btnExtractLog");
            this.btnExtractLog.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Log;
            this.errorProvider.SetError(this.btnExtractLog, resources.GetString("btnExtractLog.Error"));
            this.errorProvider.SetIconAlignment(this.btnExtractLog, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExtractLog.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnExtractLog, ((int)(resources.GetObject("btnExtractLog.IconPadding"))));
            this.btnExtractLog.Name = "btnExtractLog";
            this.toolTip.SetToolTip(this.btnExtractLog, resources.GetString("btnExtractLog.ToolTip"));
            this.btnExtractLog.UseVisualStyleBackColor = true;
            this.btnExtractLog.Click += new System.EventHandler(this.BtnExtractLog_Click);
            // 
            // btnExtractArguments
            // 
            resources.ApplyResources(this.btnExtractArguments, "btnExtractArguments");
            this.btnExtractArguments.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Command;
            this.errorProvider.SetError(this.btnExtractArguments, resources.GetString("btnExtractArguments.Error"));
            this.errorProvider.SetIconAlignment(this.btnExtractArguments, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExtractArguments.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnExtractArguments, ((int)(resources.GetObject("btnExtractArguments.IconPadding"))));
            this.btnExtractArguments.Name = "btnExtractArguments";
            this.toolTip.SetToolTip(this.btnExtractArguments, resources.GetString("btnExtractArguments.ToolTip"));
            this.btnExtractArguments.UseVisualStyleBackColor = true;
            this.btnExtractArguments.Click += new System.EventHandler(this.BtnExtractArguments_Click);
            // 
            // tabPack
            // 
            resources.ApplyResources(this.tabPack, "tabPack");
            this.tabPack.Controls.Add(this.tlpPack);
            this.errorProvider.SetError(this.tabPack, resources.GetString("tabPack.Error"));
            this.errorProvider.SetIconAlignment(this.tabPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.tabPack, ((int)(resources.GetObject("tabPack.IconPadding"))));
            this.tabPack.Name = "tabPack";
            this.toolTip.SetToolTip(this.tabPack, resources.GetString("tabPack.ToolTip"));
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // tlpPack
            // 
            resources.ApplyResources(this.tlpPack, "tlpPack");
            this.tlpPack.Controls.Add(this.btnPack, 1, 1);
            this.tlpPack.Controls.Add(this.flpPackLabels, 0, 0);
            this.tlpPack.Controls.Add(this.flpPackControls, 1, 0);
            this.tlpPack.Controls.Add(this.flpPackButtons, 2, 0);
            this.errorProvider.SetError(this.tlpPack, resources.GetString("tlpPack.Error"));
            this.errorProvider.SetIconAlignment(this.tlpPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tlpPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.tlpPack, ((int)(resources.GetObject("tlpPack.IconPadding"))));
            this.tlpPack.Name = "tlpPack";
            this.toolTip.SetToolTip(this.tlpPack, resources.GetString("tlpPack.ToolTip"));
            // 
            // btnPack
            // 
            resources.ApplyResources(this.btnPack, "btnPack");
            this.errorProvider.SetError(this.btnPack, resources.GetString("btnPack.Error"));
            this.errorProvider.SetIconAlignment(this.btnPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnPack, ((int)(resources.GetObject("btnPack.IconPadding"))));
            this.btnPack.Name = "btnPack";
            this.toolTip.SetToolTip(this.btnPack, resources.GetString("btnPack.ToolTip"));
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // flpPackLabels
            // 
            resources.ApplyResources(this.flpPackLabels, "flpPackLabels");
            this.flpPackLabels.Controls.Add(this.lblInputFolder);
            this.flpPackLabels.Controls.Add(this.lblOutputZip);
            this.flpPackLabels.Controls.Add(this.lblPackageTypePack);
            this.flpPackLabels.Controls.Add(this.lblErrorLevelPack);
            this.flpPackLabels.Controls.Add(this.lblPackMap);
            this.flpPackLabels.Controls.Add(this.lblNoLogoPack);
            this.flpPackLabels.Controls.Add(this.lblLogPack);
            this.flpPackLabels.Controls.Add(this.lblArgumentsPack);
            this.flpPackLabels.Controls.Add(this.lblLocalizePack);
            this.errorProvider.SetError(this.flpPackLabels, resources.GetString("flpPackLabels.Error"));
            this.errorProvider.SetIconAlignment(this.flpPackLabels, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpPackLabels.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpPackLabels, ((int)(resources.GetObject("flpPackLabels.IconPadding"))));
            this.flpPackLabels.Name = "flpPackLabels";
            this.toolTip.SetToolTip(this.flpPackLabels, resources.GetString("flpPackLabels.ToolTip"));
            // 
            // lblInputFolder
            // 
            resources.ApplyResources(this.lblInputFolder, "lblInputFolder");
            this.errorProvider.SetError(this.lblInputFolder, resources.GetString("lblInputFolder.Error"));
            this.errorProvider.SetIconAlignment(this.lblInputFolder, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblInputFolder.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblInputFolder, ((int)(resources.GetObject("lblInputFolder.IconPadding"))));
            this.lblInputFolder.Name = "lblInputFolder";
            this.toolTip.SetToolTip(this.lblInputFolder, resources.GetString("lblInputFolder.ToolTip"));
            // 
            // lblOutputZip
            // 
            resources.ApplyResources(this.lblOutputZip, "lblOutputZip");
            this.errorProvider.SetError(this.lblOutputZip, resources.GetString("lblOutputZip.Error"));
            this.errorProvider.SetIconAlignment(this.lblOutputZip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblOutputZip.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblOutputZip, ((int)(resources.GetObject("lblOutputZip.IconPadding"))));
            this.lblOutputZip.Name = "lblOutputZip";
            this.toolTip.SetToolTip(this.lblOutputZip, resources.GetString("lblOutputZip.ToolTip"));
            // 
            // lblPackageTypePack
            // 
            resources.ApplyResources(this.lblPackageTypePack, "lblPackageTypePack");
            this.errorProvider.SetError(this.lblPackageTypePack, resources.GetString("lblPackageTypePack.Error"));
            this.errorProvider.SetIconAlignment(this.lblPackageTypePack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPackageTypePack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblPackageTypePack, ((int)(resources.GetObject("lblPackageTypePack.IconPadding"))));
            this.lblPackageTypePack.Name = "lblPackageTypePack";
            this.toolTip.SetToolTip(this.lblPackageTypePack, resources.GetString("lblPackageTypePack.ToolTip"));
            // 
            // lblErrorLevelPack
            // 
            resources.ApplyResources(this.lblErrorLevelPack, "lblErrorLevelPack");
            this.errorProvider.SetError(this.lblErrorLevelPack, resources.GetString("lblErrorLevelPack.Error"));
            this.errorProvider.SetIconAlignment(this.lblErrorLevelPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblErrorLevelPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblErrorLevelPack, ((int)(resources.GetObject("lblErrorLevelPack.IconPadding"))));
            this.lblErrorLevelPack.Name = "lblErrorLevelPack";
            this.toolTip.SetToolTip(this.lblErrorLevelPack, resources.GetString("lblErrorLevelPack.ToolTip"));
            // 
            // lblPackMap
            // 
            resources.ApplyResources(this.lblPackMap, "lblPackMap");
            this.errorProvider.SetError(this.lblPackMap, resources.GetString("lblPackMap.Error"));
            this.errorProvider.SetIconAlignment(this.lblPackMap, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPackMap.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblPackMap, ((int)(resources.GetObject("lblPackMap.IconPadding"))));
            this.lblPackMap.Name = "lblPackMap";
            this.toolTip.SetToolTip(this.lblPackMap, resources.GetString("lblPackMap.ToolTip"));
            // 
            // lblNoLogoPack
            // 
            resources.ApplyResources(this.lblNoLogoPack, "lblNoLogoPack");
            this.errorProvider.SetError(this.lblNoLogoPack, resources.GetString("lblNoLogoPack.Error"));
            this.errorProvider.SetIconAlignment(this.lblNoLogoPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoLogoPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblNoLogoPack, ((int)(resources.GetObject("lblNoLogoPack.IconPadding"))));
            this.lblNoLogoPack.Name = "lblNoLogoPack";
            this.toolTip.SetToolTip(this.lblNoLogoPack, resources.GetString("lblNoLogoPack.ToolTip"));
            // 
            // lblLogPack
            // 
            resources.ApplyResources(this.lblLogPack, "lblLogPack");
            this.errorProvider.SetError(this.lblLogPack, resources.GetString("lblLogPack.Error"));
            this.errorProvider.SetIconAlignment(this.lblLogPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLogPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblLogPack, ((int)(resources.GetObject("lblLogPack.IconPadding"))));
            this.lblLogPack.Name = "lblLogPack";
            this.toolTip.SetToolTip(this.lblLogPack, resources.GetString("lblLogPack.ToolTip"));
            // 
            // lblArgumentsPack
            // 
            resources.ApplyResources(this.lblArgumentsPack, "lblArgumentsPack");
            this.errorProvider.SetError(this.lblArgumentsPack, resources.GetString("lblArgumentsPack.Error"));
            this.errorProvider.SetIconAlignment(this.lblArgumentsPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblArgumentsPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblArgumentsPack, ((int)(resources.GetObject("lblArgumentsPack.IconPadding"))));
            this.lblArgumentsPack.Name = "lblArgumentsPack";
            this.toolTip.SetToolTip(this.lblArgumentsPack, resources.GetString("lblArgumentsPack.ToolTip"));
            // 
            // lblLocalizePack
            // 
            resources.ApplyResources(this.lblLocalizePack, "lblLocalizePack");
            this.errorProvider.SetError(this.lblLocalizePack, resources.GetString("lblLocalizePack.Error"));
            this.errorProvider.SetIconAlignment(this.lblLocalizePack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLocalizePack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblLocalizePack, ((int)(resources.GetObject("lblLocalizePack.IconPadding"))));
            this.lblLocalizePack.Name = "lblLocalizePack";
            this.toolTip.SetToolTip(this.lblLocalizePack, resources.GetString("lblLocalizePack.ToolTip"));
            // 
            // flpPackControls
            // 
            resources.ApplyResources(this.flpPackControls, "flpPackControls");
            this.flpPackControls.Controls.Add(this.txtPackFolder);
            this.flpPackControls.Controls.Add(this.txtPackZip);
            this.flpPackControls.Controls.Add(this.cmbPackPackageType);
            this.flpPackControls.Controls.Add(this.cmbPackErrorLevel);
            this.flpPackControls.Controls.Add(this.txtPackMap);
            this.flpPackControls.Controls.Add(this.chkPackNoLogo);
            this.flpPackControls.Controls.Add(this.txtPackLog);
            this.flpPackControls.Controls.Add(this.txtPackArguments);
            this.flpPackControls.Controls.Add(this.chkPackLocalize);
            this.errorProvider.SetError(this.flpPackControls, resources.GetString("flpPackControls.Error"));
            this.errorProvider.SetIconAlignment(this.flpPackControls, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpPackControls.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpPackControls, ((int)(resources.GetObject("flpPackControls.IconPadding"))));
            this.flpPackControls.Name = "flpPackControls";
            this.toolTip.SetToolTip(this.flpPackControls, resources.GetString("flpPackControls.ToolTip"));
            // 
            // txtPackFolder
            // 
            resources.ApplyResources(this.txtPackFolder, "txtPackFolder");
            this.errorProvider.SetError(this.txtPackFolder, resources.GetString("txtPackFolder.Error"));
            this.errorProvider.SetIconAlignment(this.txtPackFolder, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPackFolder.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtPackFolder, ((int)(resources.GetObject("txtPackFolder.IconPadding"))));
            this.txtPackFolder.Name = "txtPackFolder";
            this.txtPackFolder.ReadOnly = true;
            this.txtPackFolder.ShortcutsEnabled = false;
            this.txtPackFolder.TabStop = false;
            this.toolTip.SetToolTip(this.txtPackFolder, resources.GetString("txtPackFolder.ToolTip"));
            // 
            // txtPackZip
            // 
            resources.ApplyResources(this.txtPackZip, "txtPackZip");
            this.errorProvider.SetError(this.txtPackZip, resources.GetString("txtPackZip.Error"));
            this.errorProvider.SetIconAlignment(this.txtPackZip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPackZip.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtPackZip, ((int)(resources.GetObject("txtPackZip.IconPadding"))));
            this.txtPackZip.Name = "txtPackZip";
            this.txtPackZip.ReadOnly = true;
            this.txtPackZip.ShortcutsEnabled = false;
            this.txtPackZip.TabStop = false;
            this.toolTip.SetToolTip(this.txtPackZip, resources.GetString("txtPackZip.ToolTip"));
            // 
            // cmbPackPackageType
            // 
            resources.ApplyResources(this.cmbPackPackageType, "cmbPackPackageType");
            this.cmbPackPackageType.DisplayMember = "FriendlyName";
            this.errorProvider.SetError(this.cmbPackPackageType, resources.GetString("cmbPackPackageType.Error"));
            this.cmbPackPackageType.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cmbPackPackageType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbPackPackageType.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cmbPackPackageType, ((int)(resources.GetObject("cmbPackPackageType.IconPadding"))));
            this.cmbPackPackageType.Items.AddRange(new object[] {
            resources.GetString("cmbPackPackageType.Items"),
            resources.GetString("cmbPackPackageType.Items1"),
            resources.GetString("cmbPackPackageType.Items2"),
            resources.GetString("cmbPackPackageType.Items3")});
            this.cmbPackPackageType.Name = "cmbPackPackageType";
            this.toolTip.SetToolTip(this.cmbPackPackageType, resources.GetString("cmbPackPackageType.ToolTip"));
            this.cmbPackPackageType.ValueMember = "SolutionId";
            // 
            // cmbPackErrorLevel
            // 
            resources.ApplyResources(this.cmbPackErrorLevel, "cmbPackErrorLevel");
            this.cmbPackErrorLevel.DisplayMember = "FriendlyName";
            this.errorProvider.SetError(this.cmbPackErrorLevel, resources.GetString("cmbPackErrorLevel.Error"));
            this.cmbPackErrorLevel.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cmbPackErrorLevel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbPackErrorLevel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cmbPackErrorLevel, ((int)(resources.GetObject("cmbPackErrorLevel.IconPadding"))));
            this.cmbPackErrorLevel.Items.AddRange(new object[] {
            resources.GetString("cmbPackErrorLevel.Items"),
            resources.GetString("cmbPackErrorLevel.Items1"),
            resources.GetString("cmbPackErrorLevel.Items2"),
            resources.GetString("cmbPackErrorLevel.Items3"),
            resources.GetString("cmbPackErrorLevel.Items4"),
            resources.GetString("cmbPackErrorLevel.Items5")});
            this.cmbPackErrorLevel.Name = "cmbPackErrorLevel";
            this.toolTip.SetToolTip(this.cmbPackErrorLevel, resources.GetString("cmbPackErrorLevel.ToolTip"));
            this.cmbPackErrorLevel.ValueMember = "SolutionId";
            // 
            // txtPackMap
            // 
            resources.ApplyResources(this.txtPackMap, "txtPackMap");
            this.errorProvider.SetError(this.txtPackMap, resources.GetString("txtPackMap.Error"));
            this.errorProvider.SetIconAlignment(this.txtPackMap, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPackMap.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtPackMap, ((int)(resources.GetObject("txtPackMap.IconPadding"))));
            this.txtPackMap.Name = "txtPackMap";
            this.txtPackMap.ReadOnly = true;
            this.txtPackMap.ShortcutsEnabled = false;
            this.txtPackMap.TabStop = false;
            this.toolTip.SetToolTip(this.txtPackMap, resources.GetString("txtPackMap.ToolTip"));
            // 
            // chkPackNoLogo
            // 
            resources.ApplyResources(this.chkPackNoLogo, "chkPackNoLogo");
            this.errorProvider.SetError(this.chkPackNoLogo, resources.GetString("chkPackNoLogo.Error"));
            this.errorProvider.SetIconAlignment(this.chkPackNoLogo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkPackNoLogo.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkPackNoLogo, ((int)(resources.GetObject("chkPackNoLogo.IconPadding"))));
            this.chkPackNoLogo.Name = "chkPackNoLogo";
            this.toolTip.SetToolTip(this.chkPackNoLogo, resources.GetString("chkPackNoLogo.ToolTip"));
            this.chkPackNoLogo.UseVisualStyleBackColor = true;
            // 
            // txtPackLog
            // 
            resources.ApplyResources(this.txtPackLog, "txtPackLog");
            this.errorProvider.SetError(this.txtPackLog, resources.GetString("txtPackLog.Error"));
            this.errorProvider.SetIconAlignment(this.txtPackLog, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPackLog.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtPackLog, ((int)(resources.GetObject("txtPackLog.IconPadding"))));
            this.txtPackLog.Name = "txtPackLog";
            this.txtPackLog.ReadOnly = true;
            this.txtPackLog.ShortcutsEnabled = false;
            this.txtPackLog.TabStop = false;
            this.toolTip.SetToolTip(this.txtPackLog, resources.GetString("txtPackLog.ToolTip"));
            // 
            // txtPackArguments
            // 
            resources.ApplyResources(this.txtPackArguments, "txtPackArguments");
            this.errorProvider.SetError(this.txtPackArguments, resources.GetString("txtPackArguments.Error"));
            this.errorProvider.SetIconAlignment(this.txtPackArguments, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPackArguments.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtPackArguments, ((int)(resources.GetObject("txtPackArguments.IconPadding"))));
            this.txtPackArguments.Name = "txtPackArguments";
            this.txtPackArguments.ReadOnly = true;
            this.txtPackArguments.ShortcutsEnabled = false;
            this.txtPackArguments.TabStop = false;
            this.toolTip.SetToolTip(this.txtPackArguments, resources.GetString("txtPackArguments.ToolTip"));
            // 
            // chkPackLocalize
            // 
            resources.ApplyResources(this.chkPackLocalize, "chkPackLocalize");
            this.errorProvider.SetError(this.chkPackLocalize, resources.GetString("chkPackLocalize.Error"));
            this.errorProvider.SetIconAlignment(this.chkPackLocalize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkPackLocalize.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.chkPackLocalize, ((int)(resources.GetObject("chkPackLocalize.IconPadding"))));
            this.chkPackLocalize.Name = "chkPackLocalize";
            this.toolTip.SetToolTip(this.chkPackLocalize, resources.GetString("chkPackLocalize.ToolTip"));
            this.chkPackLocalize.UseVisualStyleBackColor = true;
            // 
            // flpPackButtons
            // 
            resources.ApplyResources(this.flpPackButtons, "flpPackButtons");
            this.flpPackButtons.Controls.Add(this.btnInputFolder);
            this.flpPackButtons.Controls.Add(this.btnOutputZip);
            this.flpPackButtons.Controls.Add(this.btnPackMap);
            this.flpPackButtons.Controls.Add(this.btnLogPack);
            this.flpPackButtons.Controls.Add(this.btnArgumentsPack);
            this.errorProvider.SetError(this.flpPackButtons, resources.GetString("flpPackButtons.Error"));
            this.errorProvider.SetIconAlignment(this.flpPackButtons, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpPackButtons.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpPackButtons, ((int)(resources.GetObject("flpPackButtons.IconPadding"))));
            this.flpPackButtons.Name = "flpPackButtons";
            this.toolTip.SetToolTip(this.flpPackButtons, resources.GetString("flpPackButtons.ToolTip"));
            // 
            // btnInputFolder
            // 
            resources.ApplyResources(this.btnInputFolder, "btnInputFolder");
            this.btnInputFolder.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Folder;
            this.errorProvider.SetError(this.btnInputFolder, resources.GetString("btnInputFolder.Error"));
            this.errorProvider.SetIconAlignment(this.btnInputFolder, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnInputFolder.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnInputFolder, ((int)(resources.GetObject("btnInputFolder.IconPadding"))));
            this.btnInputFolder.Name = "btnInputFolder";
            this.toolTip.SetToolTip(this.btnInputFolder, resources.GetString("btnInputFolder.ToolTip"));
            this.btnInputFolder.UseVisualStyleBackColor = true;
            this.btnInputFolder.Click += new System.EventHandler(this.BtnInputFolder_Click);
            // 
            // btnOutputZip
            // 
            resources.ApplyResources(this.btnOutputZip, "btnOutputZip");
            this.btnOutputZip.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            this.errorProvider.SetError(this.btnOutputZip, resources.GetString("btnOutputZip.Error"));
            this.errorProvider.SetIconAlignment(this.btnOutputZip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOutputZip.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnOutputZip, ((int)(resources.GetObject("btnOutputZip.IconPadding"))));
            this.btnOutputZip.Name = "btnOutputZip";
            this.toolTip.SetToolTip(this.btnOutputZip, resources.GetString("btnOutputZip.ToolTip"));
            this.btnOutputZip.UseVisualStyleBackColor = true;
            this.btnOutputZip.Click += new System.EventHandler(this.BtnOutputZip_Click);
            // 
            // btnPackMap
            // 
            resources.ApplyResources(this.btnPackMap, "btnPackMap");
            this.btnPackMap.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Code;
            this.errorProvider.SetError(this.btnPackMap, resources.GetString("btnPackMap.Error"));
            this.errorProvider.SetIconAlignment(this.btnPackMap, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnPackMap.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnPackMap, ((int)(resources.GetObject("btnPackMap.IconPadding"))));
            this.btnPackMap.Name = "btnPackMap";
            this.toolTip.SetToolTip(this.btnPackMap, resources.GetString("btnPackMap.ToolTip"));
            this.btnPackMap.UseVisualStyleBackColor = true;
            this.btnPackMap.Click += new System.EventHandler(this.BtnPackMap_Click);
            // 
            // btnLogPack
            // 
            resources.ApplyResources(this.btnLogPack, "btnLogPack");
            this.btnLogPack.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Log;
            this.errorProvider.SetError(this.btnLogPack, resources.GetString("btnLogPack.Error"));
            this.errorProvider.SetIconAlignment(this.btnLogPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnLogPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnLogPack, ((int)(resources.GetObject("btnLogPack.IconPadding"))));
            this.btnLogPack.Name = "btnLogPack";
            this.toolTip.SetToolTip(this.btnLogPack, resources.GetString("btnLogPack.ToolTip"));
            this.btnLogPack.UseVisualStyleBackColor = true;
            this.btnLogPack.Click += new System.EventHandler(this.BtnLogPack_Click);
            // 
            // btnArgumentsPack
            // 
            resources.ApplyResources(this.btnArgumentsPack, "btnArgumentsPack");
            this.btnArgumentsPack.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Command;
            this.errorProvider.SetError(this.btnArgumentsPack, resources.GetString("btnArgumentsPack.Error"));
            this.errorProvider.SetIconAlignment(this.btnArgumentsPack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnArgumentsPack.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnArgumentsPack, ((int)(resources.GetObject("btnArgumentsPack.IconPadding"))));
            this.btnArgumentsPack.Name = "btnArgumentsPack";
            this.toolTip.SetToolTip(this.btnArgumentsPack, resources.GetString("btnArgumentsPack.ToolTip"));
            this.btnArgumentsPack.UseVisualStyleBackColor = true;
            this.btnArgumentsPack.Click += new System.EventHandler(this.BtnArgumentsPack_Click);
            // 
            // tabSettings
            // 
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Controls.Add(this.tlpSettings);
            this.errorProvider.SetError(this.tabSettings, resources.GetString("tabSettings.Error"));
            this.errorProvider.SetIconAlignment(this.tabSettings, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabSettings.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.tabSettings, ((int)(resources.GetObject("tabSettings.IconPadding"))));
            this.tabSettings.Name = "tabSettings";
            this.toolTip.SetToolTip(this.tabSettings, resources.GetString("tabSettings.ToolTip"));
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tlpSettings
            // 
            resources.ApplyResources(this.tlpSettings, "tlpSettings");
            this.tlpSettings.Controls.Add(this.btnSaveSettings, 1, 1);
            this.tlpSettings.Controls.Add(this.flpSettingsButtons, 2, 0);
            this.tlpSettings.Controls.Add(this.flpSettingsLabels, 0, 0);
            this.tlpSettings.Controls.Add(this.flpSettingsControls, 1, 0);
            this.errorProvider.SetError(this.tlpSettings, resources.GetString("tlpSettings.Error"));
            this.errorProvider.SetIconAlignment(this.tlpSettings, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tlpSettings.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.tlpSettings, ((int)(resources.GetObject("tlpSettings.IconPadding"))));
            this.tlpSettings.Name = "tlpSettings";
            this.toolTip.SetToolTip(this.tlpSettings, resources.GetString("tlpSettings.ToolTip"));
            // 
            // btnSaveSettings
            // 
            resources.ApplyResources(this.btnSaveSettings, "btnSaveSettings");
            this.errorProvider.SetError(this.btnSaveSettings, resources.GetString("btnSaveSettings.Error"));
            this.errorProvider.SetIconAlignment(this.btnSaveSettings, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSaveSettings.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnSaveSettings, ((int)(resources.GetObject("btnSaveSettings.IconPadding"))));
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.toolTip.SetToolTip(this.btnSaveSettings, resources.GetString("btnSaveSettings.ToolTip"));
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // flpSettingsButtons
            // 
            resources.ApplyResources(this.flpSettingsButtons, "flpSettingsButtons");
            this.flpSettingsButtons.Controls.Add(this.btnCoreTools);
            this.flpSettingsButtons.Controls.Add(this.btnNuGetFeed);
            this.errorProvider.SetError(this.flpSettingsButtons, resources.GetString("flpSettingsButtons.Error"));
            this.errorProvider.SetIconAlignment(this.flpSettingsButtons, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpSettingsButtons.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpSettingsButtons, ((int)(resources.GetObject("flpSettingsButtons.IconPadding"))));
            this.flpSettingsButtons.Name = "flpSettingsButtons";
            this.toolTip.SetToolTip(this.flpSettingsButtons, resources.GetString("flpSettingsButtons.ToolTip"));
            // 
            // btnCoreTools
            // 
            resources.ApplyResources(this.btnCoreTools, "btnCoreTools");
            this.btnCoreTools.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Solutions;
            this.errorProvider.SetError(this.btnCoreTools, resources.GetString("btnCoreTools.Error"));
            this.errorProvider.SetIconAlignment(this.btnCoreTools, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCoreTools.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnCoreTools, ((int)(resources.GetObject("btnCoreTools.IconPadding"))));
            this.btnCoreTools.Name = "btnCoreTools";
            this.toolTip.SetToolTip(this.btnCoreTools, resources.GetString("btnCoreTools.ToolTip"));
            this.btnCoreTools.UseVisualStyleBackColor = true;
            this.btnCoreTools.Click += new System.EventHandler(this.BtnCoreTools_Click);
            // 
            // btnNuGetFeed
            // 
            resources.ApplyResources(this.btnNuGetFeed, "btnNuGetFeed");
            this.btnNuGetFeed.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Refresh;
            this.errorProvider.SetError(this.btnNuGetFeed, resources.GetString("btnNuGetFeed.Error"));
            this.errorProvider.SetIconAlignment(this.btnNuGetFeed, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnNuGetFeed.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.btnNuGetFeed, ((int)(resources.GetObject("btnNuGetFeed.IconPadding"))));
            this.btnNuGetFeed.Name = "btnNuGetFeed";
            this.toolTip.SetToolTip(this.btnNuGetFeed, resources.GetString("btnNuGetFeed.ToolTip"));
            this.btnNuGetFeed.UseVisualStyleBackColor = true;
            this.btnNuGetFeed.Click += new System.EventHandler(this.BtnNuGetFeed_Click);
            // 
            // flpSettingsLabels
            // 
            resources.ApplyResources(this.flpSettingsLabels, "flpSettingsLabels");
            this.flpSettingsLabels.Controls.Add(this.lblCoreToolsVersion);
            this.flpSettingsLabels.Controls.Add(this.lblNuGetFeed);
            this.flpSettingsLabels.Controls.Add(this.lblLanguage);
            this.errorProvider.SetError(this.flpSettingsLabels, resources.GetString("flpSettingsLabels.Error"));
            this.errorProvider.SetIconAlignment(this.flpSettingsLabels, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpSettingsLabels.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpSettingsLabels, ((int)(resources.GetObject("flpSettingsLabels.IconPadding"))));
            this.flpSettingsLabels.Name = "flpSettingsLabels";
            this.toolTip.SetToolTip(this.flpSettingsLabels, resources.GetString("flpSettingsLabels.ToolTip"));
            // 
            // lblCoreToolsVersion
            // 
            resources.ApplyResources(this.lblCoreToolsVersion, "lblCoreToolsVersion");
            this.errorProvider.SetError(this.lblCoreToolsVersion, resources.GetString("lblCoreToolsVersion.Error"));
            this.errorProvider.SetIconAlignment(this.lblCoreToolsVersion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCoreToolsVersion.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblCoreToolsVersion, ((int)(resources.GetObject("lblCoreToolsVersion.IconPadding"))));
            this.lblCoreToolsVersion.Name = "lblCoreToolsVersion";
            this.toolTip.SetToolTip(this.lblCoreToolsVersion, resources.GetString("lblCoreToolsVersion.ToolTip"));
            // 
            // lblNuGetFeed
            // 
            resources.ApplyResources(this.lblNuGetFeed, "lblNuGetFeed");
            this.errorProvider.SetError(this.lblNuGetFeed, resources.GetString("lblNuGetFeed.Error"));
            this.errorProvider.SetIconAlignment(this.lblNuGetFeed, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNuGetFeed.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblNuGetFeed, ((int)(resources.GetObject("lblNuGetFeed.IconPadding"))));
            this.lblNuGetFeed.Name = "lblNuGetFeed";
            this.toolTip.SetToolTip(this.lblNuGetFeed, resources.GetString("lblNuGetFeed.ToolTip"));
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.errorProvider.SetError(this.lblLanguage, resources.GetString("lblLanguage.Error"));
            this.errorProvider.SetIconAlignment(this.lblLanguage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLanguage.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.lblLanguage, ((int)(resources.GetObject("lblLanguage.IconPadding"))));
            this.lblLanguage.Name = "lblLanguage";
            this.toolTip.SetToolTip(this.lblLanguage, resources.GetString("lblLanguage.ToolTip"));
            // 
            // flpSettingsControls
            // 
            resources.ApplyResources(this.flpSettingsControls, "flpSettingsControls");
            this.flpSettingsControls.Controls.Add(this.txtCoreTools);
            this.flpSettingsControls.Controls.Add(this.txtNuGetFeed);
            this.flpSettingsControls.Controls.Add(this.cmbLanguage);
            this.errorProvider.SetError(this.flpSettingsControls, resources.GetString("flpSettingsControls.Error"));
            this.errorProvider.SetIconAlignment(this.flpSettingsControls, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flpSettingsControls.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.flpSettingsControls, ((int)(resources.GetObject("flpSettingsControls.IconPadding"))));
            this.flpSettingsControls.Name = "flpSettingsControls";
            this.toolTip.SetToolTip(this.flpSettingsControls, resources.GetString("flpSettingsControls.ToolTip"));
            // 
            // txtCoreTools
            // 
            resources.ApplyResources(this.txtCoreTools, "txtCoreTools");
            this.errorProvider.SetError(this.txtCoreTools, resources.GetString("txtCoreTools.Error"));
            this.errorProvider.SetIconAlignment(this.txtCoreTools, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCoreTools.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtCoreTools, ((int)(resources.GetObject("txtCoreTools.IconPadding"))));
            this.txtCoreTools.Name = "txtCoreTools";
            this.txtCoreTools.ReadOnly = true;
            this.txtCoreTools.ShortcutsEnabled = false;
            this.txtCoreTools.TabStop = false;
            this.toolTip.SetToolTip(this.txtCoreTools, resources.GetString("txtCoreTools.ToolTip"));
            // 
            // txtNuGetFeed
            // 
            resources.ApplyResources(this.txtNuGetFeed, "txtNuGetFeed");
            this.errorProvider.SetError(this.txtNuGetFeed, resources.GetString("txtNuGetFeed.Error"));
            this.errorProvider.SetIconAlignment(this.txtNuGetFeed, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNuGetFeed.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtNuGetFeed, ((int)(resources.GetObject("txtNuGetFeed.IconPadding"))));
            this.txtNuGetFeed.Name = "txtNuGetFeed";
            this.txtNuGetFeed.ShortcutsEnabled = false;
            this.txtNuGetFeed.TabStop = false;
            this.toolTip.SetToolTip(this.txtNuGetFeed, resources.GetString("txtNuGetFeed.ToolTip"));
            // 
            // cmbLanguage
            // 
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.DisplayMember = "DisplayName";
            this.errorProvider.SetError(this.cmbLanguage, resources.GetString("cmbLanguage.Error"));
            this.cmbLanguage.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cmbLanguage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbLanguage.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.cmbLanguage, ((int)(resources.GetObject("cmbLanguage.IconPadding"))));
            this.cmbLanguage.Name = "cmbLanguage";
            this.toolTip.SetToolTip(this.cmbLanguage, resources.GetString("cmbLanguage.ToolTip"));
            this.cmbLanguage.ValueMember = "Name";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguage_SelectedIndexChanged);
            // 
            // txtOutput
            // 
            resources.ApplyResources(this.txtOutput, "txtOutput");
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.errorProvider.SetError(this.txtOutput, resources.GetString("txtOutput.Error"));
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.errorProvider.SetIconAlignment(this.txtOutput, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtOutput.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.txtOutput, ((int)(resources.GetObject("txtOutput.IconPadding"))));
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.toolTip.SetToolTip(this.txtOutput, resources.GetString("txtOutput.ToolTip"));
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // selectFolder
            // 
            resources.ApplyResources(this.selectFolder, "selectFolder");
            // 
            // openFile
            // 
            resources.ApplyResources(this.openFile, "openFile");
            // 
            // saveFile
            // 
            resources.ApplyResources(this.saveFile, "saveFile");
            // 
            // SolutionPackagerControl
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.splitContainer);
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.Name = "SolutionPackagerControl";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.SolutionPackagerControl_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
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
        private System.Windows.Forms.OpenFileDialog openFile;
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
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}
