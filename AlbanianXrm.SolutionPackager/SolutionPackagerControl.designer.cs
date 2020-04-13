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
            this.tabsExtractOrPack = new System.Windows.Forms.TabControl();
            this.tabExtract = new System.Windows.Forms.TabPage();
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
            this.chkAllowWrite = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAllowDelete = new System.Windows.Forms.Label();
            this.radAllowDeleteNo = new System.Windows.Forms.RadioButton();
            this.radAllowDeleteYes = new System.Windows.Forms.RadioButton();
            this.radAllowDeletePrompt = new System.Windows.Forms.RadioButton();
            this.tabsExtractOrPack.SuspendLayout();
            this.tabExtract.SuspendLayout();
            this.grpExportSolution.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsExtractOrPack
            // 
            this.tabsExtractOrPack.Controls.Add(this.tabExtract);
            this.tabsExtractOrPack.Controls.Add(this.tabPack);
            this.tabsExtractOrPack.Controls.Add(this.tabSettings);
            this.tabsExtractOrPack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsExtractOrPack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsExtractOrPack.Location = new System.Drawing.Point(0, 0);
            this.tabsExtractOrPack.Name = "tabsExtractOrPack";
            this.tabsExtractOrPack.SelectedIndex = 0;
            this.tabsExtractOrPack.Size = new System.Drawing.Size(440, 600);
            this.tabsExtractOrPack.TabIndex = 0;
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
            this.tabExtract.Location = new System.Drawing.Point(4, 24);
            this.tabExtract.Name = "tabExtract";
            this.tabExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtract.Size = new System.Drawing.Size(432, 572);
            this.tabExtract.TabIndex = 0;
            this.tabExtract.Text = "Extract";
            this.tabExtract.UseVisualStyleBackColor = true;
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
            this.grpExportSolution.Location = new System.Drawing.Point(0, 212);
            this.grpExportSolution.Name = "grpExportSolution";
            this.grpExportSolution.Size = new System.Drawing.Size(432, 178);
            this.grpExportSolution.TabIndex = 11;
            this.grpExportSolution.TabStop = false;
            this.grpExportSolution.Text = "Export Solution";
            // 
            // lblExportAs
            // 
            this.lblExportAs.AutoSize = true;
            this.lblExportAs.Location = new System.Drawing.Point(7, 50);
            this.lblExportAs.Name = "lblExportAs";
            this.lblExportAs.Size = new System.Drawing.Size(63, 15);
            this.lblExportAs.TabIndex = 22;
            this.lblExportAs.Text = "Export As: ";
            // 
            // radManaged
            // 
            this.radManaged.AutoSize = true;
            this.radManaged.Location = new System.Drawing.Point(172, 48);
            this.radManaged.Name = "radManaged";
            this.radManaged.Size = new System.Drawing.Size(75, 19);
            this.radManaged.TabIndex = 21;
            this.radManaged.Text = "Managed";
            this.radManaged.UseVisualStyleBackColor = true;
            // 
            // radUnmanaged
            // 
            this.radUnmanaged.AutoSize = true;
            this.radUnmanaged.Checked = true;
            this.radUnmanaged.Location = new System.Drawing.Point(76, 48);
            this.radUnmanaged.Name = "radUnmanaged";
            this.radUnmanaged.Size = new System.Drawing.Size(90, 19);
            this.radUnmanaged.TabIndex = 20;
            this.radUnmanaged.TabStop = true;
            this.radUnmanaged.Text = "Unmanaged";
            this.radUnmanaged.UseVisualStyleBackColor = true;
            // 
            // chkExportRelationshipRoles
            // 
            this.chkExportRelationshipRoles.AutoSize = true;
            this.chkExportRelationshipRoles.Location = new System.Drawing.Point(10, 152);
            this.chkExportRelationshipRoles.Name = "chkExportRelationshipRoles";
            this.chkExportRelationshipRoles.Size = new System.Drawing.Size(122, 19);
            this.chkExportRelationshipRoles.TabIndex = 19;
            this.chkExportRelationshipRoles.Text = "Relationship Roles";
            this.chkExportRelationshipRoles.UseVisualStyleBackColor = true;
            // 
            // chkExportSales
            // 
            this.chkExportSales.AutoSize = true;
            this.chkExportSales.Location = new System.Drawing.Point(294, 127);
            this.chkExportSales.Name = "chkExportSales";
            this.chkExportSales.Size = new System.Drawing.Size(52, 19);
            this.chkExportSales.TabIndex = 18;
            this.chkExportSales.Text = "Sales";
            this.chkExportSales.UseVisualStyleBackColor = true;
            // 
            // chkExportOutlookSynchronization
            // 
            this.chkExportOutlookSynchronization.AutoSize = true;
            this.chkExportOutlookSynchronization.Location = new System.Drawing.Point(153, 152);
            this.chkExportOutlookSynchronization.Name = "chkExportOutlookSynchronization";
            this.chkExportOutlookSynchronization.Size = new System.Drawing.Size(150, 19);
            this.chkExportOutlookSynchronization.TabIndex = 17;
            this.chkExportOutlookSynchronization.Text = "Outlook Syncronization";
            this.chkExportOutlookSynchronization.UseVisualStyleBackColor = true;
            // 
            // chkExportMarketing
            // 
            this.chkExportMarketing.AutoSize = true;
            this.chkExportMarketing.Location = new System.Drawing.Point(153, 127);
            this.chkExportMarketing.Name = "chkExportMarketing";
            this.chkExportMarketing.Size = new System.Drawing.Size(80, 19);
            this.chkExportMarketing.TabIndex = 16;
            this.chkExportMarketing.Text = "Marketing";
            this.chkExportMarketing.UseVisualStyleBackColor = true;
            // 
            // chkExportISVConfig
            // 
            this.chkExportISVConfig.AutoSize = true;
            this.chkExportISVConfig.Location = new System.Drawing.Point(10, 127);
            this.chkExportISVConfig.Name = "chkExportISVConfig";
            this.chkExportISVConfig.Size = new System.Drawing.Size(81, 19);
            this.chkExportISVConfig.TabIndex = 15;
            this.chkExportISVConfig.Text = "ISV Config";
            this.chkExportISVConfig.UseVisualStyleBackColor = true;
            // 
            // chkExportGeneralSettings
            // 
            this.chkExportGeneralSettings.AutoSize = true;
            this.chkExportGeneralSettings.Location = new System.Drawing.Point(294, 102);
            this.chkExportGeneralSettings.Name = "chkExportGeneralSettings";
            this.chkExportGeneralSettings.Size = new System.Drawing.Size(111, 19);
            this.chkExportGeneralSettings.TabIndex = 14;
            this.chkExportGeneralSettings.Text = "General Settings";
            this.chkExportGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // chkExportExternalApplications
            // 
            this.chkExportExternalApplications.AutoSize = true;
            this.chkExportExternalApplications.Location = new System.Drawing.Point(153, 102);
            this.chkExportExternalApplications.Name = "chkExportExternalApplications";
            this.chkExportExternalApplications.Size = new System.Drawing.Size(137, 19);
            this.chkExportExternalApplications.TabIndex = 13;
            this.chkExportExternalApplications.Text = "External Applications";
            this.chkExportExternalApplications.UseVisualStyleBackColor = true;
            // 
            // chkExportEmailTracking
            // 
            this.chkExportEmailTracking.AutoSize = true;
            this.chkExportEmailTracking.Location = new System.Drawing.Point(10, 102);
            this.chkExportEmailTracking.Name = "chkExportEmailTracking";
            this.chkExportEmailTracking.Size = new System.Drawing.Size(102, 19);
            this.chkExportEmailTracking.TabIndex = 12;
            this.chkExportEmailTracking.Text = "Email Tracking";
            this.chkExportEmailTracking.UseVisualStyleBackColor = true;
            // 
            // chkExportCustomization
            // 
            this.chkExportCustomization.AutoSize = true;
            this.chkExportCustomization.Location = new System.Drawing.Point(294, 77);
            this.chkExportCustomization.Name = "chkExportCustomization";
            this.chkExportCustomization.Size = new System.Drawing.Size(103, 19);
            this.chkExportCustomization.TabIndex = 11;
            this.chkExportCustomization.Text = "Customization";
            this.chkExportCustomization.UseVisualStyleBackColor = true;
            // 
            // chkExportCalendar
            // 
            this.chkExportCalendar.AutoSize = true;
            this.chkExportCalendar.Location = new System.Drawing.Point(153, 77);
            this.chkExportCalendar.Name = "chkExportCalendar";
            this.chkExportCalendar.Size = new System.Drawing.Size(73, 19);
            this.chkExportCalendar.TabIndex = 10;
            this.chkExportCalendar.Text = "Calendar";
            this.chkExportCalendar.UseVisualStyleBackColor = true;
            // 
            // chkExportAutoNumbering
            // 
            this.chkExportAutoNumbering.AutoSize = true;
            this.chkExportAutoNumbering.Location = new System.Drawing.Point(10, 77);
            this.chkExportAutoNumbering.Name = "chkExportAutoNumbering";
            this.chkExportAutoNumbering.Size = new System.Drawing.Size(116, 19);
            this.chkExportAutoNumbering.TabIndex = 9;
            this.chkExportAutoNumbering.Text = "Auto Numbering";
            this.chkExportAutoNumbering.UseVisualStyleBackColor = true;
            // 
            // lblOnlineSolution
            // 
            this.lblOnlineSolution.AutoSize = true;
            this.lblOnlineSolution.Location = new System.Drawing.Point(6, 19);
            this.lblOnlineSolution.Name = "lblOnlineSolution";
            this.lblOnlineSolution.Size = new System.Drawing.Size(80, 15);
            this.lblOnlineSolution.TabIndex = 5;
            this.lblOnlineSolution.Text = "CRM Solution";
            // 
            // cmbCrmSolutions
            // 
            this.cmbCrmSolutions.DisplayMember = "FriendlyName";
            this.cmbCrmSolutions.FormattingEnabled = true;
            this.cmbCrmSolutions.Location = new System.Drawing.Point(93, 16);
            this.cmbCrmSolutions.Name = "cmbCrmSolutions";
            this.cmbCrmSolutions.Size = new System.Drawing.Size(270, 23);
            this.cmbCrmSolutions.TabIndex = 4;
            this.cmbCrmSolutions.ValueMember = "SolutionId";
            // 
            // btnRefreshSolutions
            // 
            this.btnRefreshSolutions.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Solutions;
            this.btnRefreshSolutions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshSolutions.Location = new System.Drawing.Point(386, 12);
            this.btnRefreshSolutions.Name = "btnRefreshSolutions";
            this.btnRefreshSolutions.Size = new System.Drawing.Size(30, 30);
            this.btnRefreshSolutions.TabIndex = 8;
            this.btnRefreshSolutions.UseVisualStyleBackColor = true;
            this.btnRefreshSolutions.Click += new System.EventHandler(this.BtnRefreshSolutions_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(341, 185);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 10;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Folder;
            this.btnOutputFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutputFolder.Location = new System.Drawing.Point(384, 56);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(30, 30);
            this.btnOutputFolder.TabIndex = 9;
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.BtnOutputFolder_Click);
            // 
            // btnOpenZip
            // 
            this.btnOpenZip.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Zip;
            this.btnOpenZip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenZip.Location = new System.Drawing.Point(384, 24);
            this.btnOpenZip.Name = "btnOpenZip";
            this.btnOpenZip.Size = new System.Drawing.Size(30, 30);
            this.btnOpenZip.TabIndex = 7;
            this.btnOpenZip.UseVisualStyleBackColor = true;
            this.btnOpenZip.Click += new System.EventHandler(this.BtnOpenZip_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(92, 60);
            this.txtOutputFolder.Multiline = false;
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtOutputFolder.ShortcutsEnabled = false;
            this.txtOutputFolder.Size = new System.Drawing.Size(270, 24);
            this.txtOutputFolder.TabIndex = 6;
            this.txtOutputFolder.TabStop = false;
            this.txtOutputFolder.Text = "";
            this.txtOutputFolder.WordWrap = false;
            // 
            // lblExtractZipPath
            // 
            this.lblExtractZipPath.AutoSize = true;
            this.lblExtractZipPath.Location = new System.Drawing.Point(7, 32);
            this.lblExtractZipPath.Name = "lblExtractZipPath";
            this.lblExtractZipPath.Size = new System.Drawing.Size(78, 15);
            this.lblExtractZipPath.TabIndex = 3;
            this.lblExtractZipPath.Text = "Solution Path";
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Location = new System.Drawing.Point(7, 64);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(81, 15);
            this.lblOutputFolder.TabIndex = 2;
            this.lblOutputFolder.Text = "Output Folder";
            // 
            // txtZipPath
            // 
            this.txtZipPath.Location = new System.Drawing.Point(94, 28);
            this.txtZipPath.Multiline = false;
            this.txtZipPath.Name = "txtZipPath";
            this.txtZipPath.ReadOnly = true;
            this.txtZipPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtZipPath.ShortcutsEnabled = false;
            this.txtZipPath.Size = new System.Drawing.Size(270, 24);
            this.txtZipPath.TabIndex = 0;
            this.txtZipPath.TabStop = false;
            this.txtZipPath.Text = "";
            this.txtZipPath.WordWrap = false;
            // 
            // localOrCrm
            // 
            this.localOrCrm.AutoSize = true;
            this.localOrCrm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.localOrCrm.Location = new System.Drawing.Point(7, 7);
            this.localOrCrm.Name = "localOrCrm";
            this.localOrCrm.Size = new System.Drawing.Size(271, 19);
            this.localOrCrm.TabIndex = 1;
            this.localOrCrm.Text = "Download the solution from the Organization?";
            this.localOrCrm.UseVisualStyleBackColor = true;
            this.localOrCrm.CheckedChanged += new System.EventHandler(this.LocalOrCrm_CheckedChanged);
            // 
            // tabPack
            // 
            this.tabPack.Location = new System.Drawing.Point(4, 24);
            this.tabPack.Name = "tabPack";
            this.tabPack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPack.Size = new System.Drawing.Size(432, 572);
            this.tabPack.TabIndex = 1;
            this.tabPack.Text = "Pack";
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnNuGetFeed);
            this.tabSettings.Controls.Add(this.lblNuGetFeed);
            this.tabSettings.Controls.Add(this.txtNuGetFeed);
            this.tabSettings.Controls.Add(this.btnCoreTools);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.txtCoreTools);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(432, 572);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnNuGetFeed
            // 
            this.btnNuGetFeed.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Refresh;
            this.btnNuGetFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuGetFeed.Location = new System.Drawing.Point(386, 32);
            this.btnNuGetFeed.Name = "btnNuGetFeed";
            this.btnNuGetFeed.Size = new System.Drawing.Size(30, 30);
            this.btnNuGetFeed.TabIndex = 13;
            this.btnNuGetFeed.UseVisualStyleBackColor = true;
            this.btnNuGetFeed.Click += new System.EventHandler(this.BtnNuGetFeed_Click);
            // 
            // lblNuGetFeed
            // 
            this.lblNuGetFeed.AutoSize = true;
            this.lblNuGetFeed.Location = new System.Drawing.Point(5, 40);
            this.lblNuGetFeed.Name = "lblNuGetFeed";
            this.lblNuGetFeed.Size = new System.Drawing.Size(69, 15);
            this.lblNuGetFeed.TabIndex = 12;
            this.lblNuGetFeed.Text = "NuGet Feed";
            // 
            // txtNuGetFeed
            // 
            this.txtNuGetFeed.Location = new System.Drawing.Point(110, 36);
            this.txtNuGetFeed.Multiline = false;
            this.txtNuGetFeed.Name = "txtNuGetFeed";
            this.txtNuGetFeed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtNuGetFeed.ShortcutsEnabled = false;
            this.txtNuGetFeed.Size = new System.Drawing.Size(270, 24);
            this.txtNuGetFeed.TabIndex = 11;
            this.txtNuGetFeed.TabStop = false;
            this.txtNuGetFeed.Text = "https://packages.nuget.org/api/v2";
            this.txtNuGetFeed.WordWrap = false;
            // 
            // btnCoreTools
            // 
            this.btnCoreTools.BackgroundImage = global::AlbanianXrm.SolutionPackager.Properties.Resources.Solutions;
            this.btnCoreTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoreTools.Location = new System.Drawing.Point(386, 2);
            this.btnCoreTools.Name = "btnCoreTools";
            this.btnCoreTools.Size = new System.Drawing.Size(30, 30);
            this.btnCoreTools.TabIndex = 10;
            this.btnCoreTools.UseVisualStyleBackColor = true;
            this.btnCoreTools.Click += new System.EventHandler(this.BtnCoreTools_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "CoreTools Version";
            // 
            // txtCoreTools
            // 
            this.txtCoreTools.Location = new System.Drawing.Point(110, 6);
            this.txtCoreTools.Multiline = false;
            this.txtCoreTools.Name = "txtCoreTools";
            this.txtCoreTools.ReadOnly = true;
            this.txtCoreTools.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCoreTools.ShortcutsEnabled = false;
            this.txtCoreTools.Size = new System.Drawing.Size(270, 24);
            this.txtCoreTools.TabIndex = 8;
            this.txtCoreTools.TabStop = false;
            this.txtCoreTools.Text = "";
            this.txtCoreTools.WordWrap = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openZipFile
            // 
            this.openZipFile.FileName = "openFileDialog1";
            this.openZipFile.Filter = "Solution|*.zip|All Files|*.*";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabsExtractOrPack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(800, 600);
            this.splitContainer1.SplitterDistance = 440;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(356, 600);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // chkAllowWrite
            // 
            this.chkAllowWrite.AutoSize = true;
            this.chkAllowWrite.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAllowWrite.Checked = true;
            this.chkAllowWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowWrite.Location = new System.Drawing.Point(7, 96);
            this.chkAllowWrite.Name = "chkAllowWrite";
            this.chkAllowWrite.Size = new System.Drawing.Size(98, 19);
            this.chkAllowWrite.TabIndex = 12;
            this.chkAllowWrite.Text = "Allow Write?  ";
            this.chkAllowWrite.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radAllowDeletePrompt);
            this.panel1.Controls.Add(this.radAllowDeleteYes);
            this.panel1.Controls.Add(this.radAllowDeleteNo);
            this.panel1.Controls.Add(this.lblAllowDelete);
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 31);
            this.panel1.TabIndex = 13;
            // 
            // lblAllowDelete
            // 
            this.lblAllowDelete.AutoSize = true;
            this.lblAllowDelete.Location = new System.Drawing.Point(7, 0);
            this.lblAllowDelete.Name = "lblAllowDelete";
            this.lblAllowDelete.Size = new System.Drawing.Size(73, 15);
            this.lblAllowDelete.TabIndex = 0;
            this.lblAllowDelete.Text = "Allow Delete";
            // 
            // radAllowDeleteNo
            // 
            this.radAllowDeleteNo.AutoSize = true;
            this.radAllowDeleteNo.Location = new System.Drawing.Point(211, 0);
            this.radAllowDeleteNo.Name = "radAllowDeleteNo";
            this.radAllowDeleteNo.Size = new System.Drawing.Size(41, 19);
            this.radAllowDeleteNo.TabIndex = 1;
            this.radAllowDeleteNo.TabStop = true;
            this.radAllowDeleteNo.Text = "No";
            this.radAllowDeleteNo.UseVisualStyleBackColor = true;
            // 
            // radAllowDeleteYes
            // 
            this.radAllowDeleteYes.AutoSize = true;
            this.radAllowDeleteYes.Location = new System.Drawing.Point(163, 0);
            this.radAllowDeleteYes.Name = "radAllowDeleteYes";
            this.radAllowDeleteYes.Size = new System.Drawing.Size(42, 19);
            this.radAllowDeleteYes.TabIndex = 2;
            this.radAllowDeleteYes.TabStop = true;
            this.radAllowDeleteYes.Text = "Yes";
            this.radAllowDeleteYes.UseVisualStyleBackColor = true;
            // 
            // radAllowDeletePrompt
            // 
            this.radAllowDeletePrompt.AutoSize = true;
            this.radAllowDeletePrompt.Checked = true;
            this.radAllowDeletePrompt.Location = new System.Drawing.Point(92, 0);
            this.radAllowDeletePrompt.Name = "radAllowDeletePrompt";
            this.radAllowDeletePrompt.Size = new System.Drawing.Size(65, 19);
            this.radAllowDeletePrompt.TabIndex = 3;
            this.radAllowDeletePrompt.TabStop = true;
            this.radAllowDeletePrompt.Text = "Prompt";
            this.radAllowDeletePrompt.UseVisualStyleBackColor = true;
            // 
            // SolutionPackagerControl
            // 
            this.Controls.Add(this.splitContainer1);
            this.Name = "SolutionPackagerControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.tabsExtractOrPack.ResumeLayout(false);
            this.tabExtract.ResumeLayout(false);
            this.tabExtract.PerformLayout();
            this.grpExportSolution.ResumeLayout(false);
            this.grpExportSolution.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}
