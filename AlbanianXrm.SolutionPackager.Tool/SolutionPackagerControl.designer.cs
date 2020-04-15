using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radAllowDeletePrompt = new System.Windows.Forms.RadioButton();
            this.radAllowDeleteYes = new System.Windows.Forms.RadioButton();
            this.radAllowDeleteNo = new System.Windows.Forms.RadioButton();
            this.lblAllowDelete = new System.Windows.Forms.Label();
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
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnNuGetFeed = new System.Windows.Forms.Button();
            this.lblNuGetFeed = new System.Windows.Forms.Label();
            this.txtNuGetFeed = new System.Windows.Forms.RichTextBox();
            this.btnCoreTools = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoreTools = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openZipFile = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.tabsExtractOrPack.SuspendLayout();
            this.tabExtract.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpExportSolution.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.tabExtract.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.radAllowDeletePrompt);
            this.panel1.Controls.Add(this.radAllowDeleteYes);
            this.panel1.Controls.Add(this.radAllowDeleteNo);
            this.panel1.Controls.Add(this.lblAllowDelete);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            resources.ApplyResources(this.tabPack, "tabPack");
            this.tabPack.Name = "tabPack";
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cmbLanguage);
            this.tabSettings.Controls.Add(this.lblLanguage);
            this.tabSettings.Controls.Add(this.btnNuGetFeed);
            this.tabSettings.Controls.Add(this.lblNuGetFeed);
            this.tabSettings.Controls.Add(this.txtNuGetFeed);
            this.tabSettings.Controls.Add(this.btnCoreTools);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.txtCoreTools);
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.UseVisualStyleBackColor = true;
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
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // btnNuGetFeed
            // 
            this.btnNuGetFeed.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Refresh;
            resources.ApplyResources(this.btnNuGetFeed, "btnNuGetFeed");
            this.btnNuGetFeed.Name = "btnNuGetFeed";
            this.btnNuGetFeed.UseVisualStyleBackColor = true;
            this.btnNuGetFeed.Click += new System.EventHandler(this.BtnNuGetFeed_Click);
            // 
            // lblNuGetFeed
            // 
            resources.ApplyResources(this.lblNuGetFeed, "lblNuGetFeed");
            this.lblNuGetFeed.Name = "lblNuGetFeed";
            // 
            // txtNuGetFeed
            // 
            resources.ApplyResources(this.txtNuGetFeed, "txtNuGetFeed");
            this.txtNuGetFeed.Name = "txtNuGetFeed";
            this.txtNuGetFeed.ShortcutsEnabled = false;
            this.txtNuGetFeed.TabStop = false;
            // 
            // btnCoreTools
            // 
            this.btnCoreTools.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Solutions;
            resources.ApplyResources(this.btnCoreTools, "btnCoreTools");
            this.btnCoreTools.Name = "btnCoreTools";
            this.btnCoreTools.UseVisualStyleBackColor = true;
            this.btnCoreTools.Click += new System.EventHandler(this.BtnCoreTools_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtCoreTools
            // 
            resources.ApplyResources(this.txtCoreTools, "txtCoreTools");
            this.txtCoreTools.Name = "txtCoreTools";
            this.txtCoreTools.ReadOnly = true;
            this.txtCoreTools.ShortcutsEnabled = false;
            this.txtCoreTools.TabStop = false;
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
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabsExtractOrPack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
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
            this.Controls.Add(this.splitContainer1);
            this.Name = "SolutionPackagerControl";
            resources.ApplyResources(this, "$this");
            this.tabsExtractOrPack.ResumeLayout(false);
            this.tabExtract.ResumeLayout(false);
            this.tabExtract.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpExportSolution.ResumeLayout(false);
            this.grpExportSolution.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCoreTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtCoreTools;
        private System.Windows.Forms.TabPage tabPack;
        private System.Windows.Forms.Button btnNuGetFeed;
        private System.Windows.Forms.Label lblNuGetFeed;
        private System.Windows.Forms.RichTextBox txtNuGetFeed;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private System.Windows.Forms.OpenFileDialog openZipFile;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAllowDelete;
        private System.Windows.Forms.RadioButton radAllowDeletePrompt;
        private System.Windows.Forms.RadioButton radAllowDeleteYes;
        private System.Windows.Forms.RadioButton radAllowDeleteNo;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
    }
}
