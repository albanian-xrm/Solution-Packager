using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbanianXrm.SolutionPackager
{
    public partial class SolutionImportStatus
    {
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionImportStatus));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.lblJobStatusLabel = new System.Windows.Forms.Label();
            this.lblCreatedOnLabel = new System.Windows.Forms.Label();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblStartedOnLabel = new System.Windows.Forms.Label();
            this.lblCompletedOnLabel = new System.Windows.Forms.Label();
            this.lblStartedOn = new System.Windows.Forms.Label();
            this.lblCompletedOn = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblErrorCodeLabel = new System.Windows.Forms.Label();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.lblSolutionNameLabel = new System.Windows.Forms.Label();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.btnCopyMessage = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // tlpContainer
            // 
            resources.ApplyResources(this.tlpContainer, "tlpContainer");
            this.tlpContainer.Controls.Add(this.lblJobStatus, 1, 1);
            this.tlpContainer.Controls.Add(this.lblJobStatusLabel, 0, 1);
            this.tlpContainer.Controls.Add(this.lblCreatedOnLabel, 0, 2);
            this.tlpContainer.Controls.Add(this.lblCreatedOn, 1, 2);
            this.tlpContainer.Controls.Add(this.lblStartedOnLabel, 0, 3);
            this.tlpContainer.Controls.Add(this.lblCompletedOnLabel, 0, 4);
            this.tlpContainer.Controls.Add(this.lblStartedOn, 1, 3);
            this.tlpContainer.Controls.Add(this.lblCompletedOn, 1, 4);
            this.tlpContainer.Controls.Add(this.progressBar, 0, 0);
            this.tlpContainer.Controls.Add(this.lblErrorCodeLabel, 0, 6);
            this.tlpContainer.Controls.Add(this.lblErrorCode, 1, 6);
            this.tlpContainer.Controls.Add(this.lblSolutionNameLabel, 0, 5);
            this.tlpContainer.Controls.Add(this.lblSolutionName, 1, 5);
            this.tlpContainer.Controls.Add(this.btnCopyMessage, 0, 7);
            this.tlpContainer.Name = "tlpContainer";
            // 
            // lblJobStatus
            // 
            resources.ApplyResources(this.lblJobStatus, "lblJobStatus");
            this.lblJobStatus.Name = "lblJobStatus";
            // 
            // lblJobStatusLabel
            // 
            resources.ApplyResources(this.lblJobStatusLabel, "lblJobStatusLabel");
            this.lblJobStatusLabel.Name = "lblJobStatusLabel";
            // 
            // lblCreatedOnLabel
            // 
            resources.ApplyResources(this.lblCreatedOnLabel, "lblCreatedOnLabel");
            this.lblCreatedOnLabel.Name = "lblCreatedOnLabel";
            // 
            // lblCreatedOn
            // 
            resources.ApplyResources(this.lblCreatedOn, "lblCreatedOn");
            this.lblCreatedOn.Name = "lblCreatedOn";
            // 
            // lblStartedOnLabel
            // 
            resources.ApplyResources(this.lblStartedOnLabel, "lblStartedOnLabel");
            this.lblStartedOnLabel.Name = "lblStartedOnLabel";
            // 
            // lblCompletedOnLabel
            // 
            resources.ApplyResources(this.lblCompletedOnLabel, "lblCompletedOnLabel");
            this.lblCompletedOnLabel.Name = "lblCompletedOnLabel";
            // 
            // lblStartedOn
            // 
            resources.ApplyResources(this.lblStartedOn, "lblStartedOn");
            this.lblStartedOn.Name = "lblStartedOn";
            // 
            // lblCompletedOn
            // 
            resources.ApplyResources(this.lblCompletedOn, "lblCompletedOn");
            this.lblCompletedOn.Name = "lblCompletedOn";
            // 
            // progressBar
            // 
            this.tlpContainer.SetColumnSpan(this.progressBar, 3);
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Step = 1;
            // 
            // lblErrorCodeLabel
            // 
            resources.ApplyResources(this.lblErrorCodeLabel, "lblErrorCodeLabel");
            this.lblErrorCodeLabel.Name = "lblErrorCodeLabel";
            // 
            // lblErrorCode
            // 
            resources.ApplyResources(this.lblErrorCode, "lblErrorCode");
            this.lblErrorCode.Name = "lblErrorCode";
            // 
            // lblSolutionNameLabel
            // 
            resources.ApplyResources(this.lblSolutionNameLabel, "lblSolutionNameLabel");
            this.lblSolutionNameLabel.Name = "lblSolutionNameLabel";
            // 
            // lblSolutionName
            // 
            resources.ApplyResources(this.lblSolutionName, "lblSolutionName");
            this.lblSolutionName.Name = "lblSolutionName";
            // 
            // btnCopyMessage
            // 
            resources.ApplyResources(this.btnCopyMessage, "btnCopyMessage");
            this.tlpContainer.SetColumnSpan(this.btnCopyMessage, 3);
            this.btnCopyMessage.Name = "btnCopyMessage";
            this.btnCopyMessage.UseVisualStyleBackColor = true;
            this.btnCopyMessage.Click += new System.EventHandler(this.BtnCopyMessage_Click);
            // 
            // SolutionImportStatus
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tlpContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SolutionImportStatus";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Label lblJobStatusLabel;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.Label lblCreatedOnLabel;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblStartedOnLabel;
        private System.Windows.Forms.Label lblCompletedOnLabel;
        private System.Windows.Forms.Label lblStartedOn;
        private System.Windows.Forms.Label lblCompletedOn;
        private System.Windows.Forms.Label lblErrorCodeLabel;
        private System.Windows.Forms.Label lblErrorCode;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblSolutionNameLabel;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Button btnCopyMessage;
    }
}
