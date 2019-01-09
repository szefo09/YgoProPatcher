namespace YgoProPatcher
{
    partial class YgoProPatcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YgoProPatcher));
            this.YGOPRO1PathButton = new System.Windows.Forms.Button();
            this.YGOPRO2PathButton = new System.Windows.Forms.Button();
            this.YGOPRO1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YgoProLinksPath = new System.Windows.Forms.TextBox();
            this.YgoPro2Path = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.internetCheckbox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.footerLabel = new System.Windows.Forms.Label();
            this.gitHubDownloadCheckbox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.OverwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.debug = new System.Windows.Forms.Label();
            this.ReinstallCheckbox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FinishButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.UpdateCheckerButton = new System.Windows.Forms.Button();
            this.UpdateCheckerTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateWhenLabel = new System.Windows.Forms.Label();
            this.MimimizeButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.StartMinimizedCheckbox = new System.Windows.Forms.CheckBox();
            this.submitFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateCheckerTimeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // YGOPRO1PathButton
            // 
            this.YGOPRO1PathButton.Enabled = false;
            this.YGOPRO1PathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YGOPRO1PathButton.Location = new System.Drawing.Point(525, 73);
            this.YGOPRO1PathButton.Name = "YGOPRO1PathButton";
            this.YGOPRO1PathButton.Size = new System.Drawing.Size(100, 23);
            this.YGOPRO1PathButton.TabIndex = 0;
            this.YGOPRO1PathButton.Text = "Select Path";
            this.YGOPRO1PathButton.UseVisualStyleBackColor = true;
            this.YGOPRO1PathButton.Visible = false;
            this.YGOPRO1PathButton.Click += new System.EventHandler(this.YgoProLinksButton_Click);
            // 
            // YGOPRO2PathButton
            // 
            this.YGOPRO2PathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YGOPRO2PathButton.Location = new System.Drawing.Point(525, 28);
            this.YGOPRO2PathButton.Name = "YGOPRO2PathButton";
            this.YGOPRO2PathButton.Size = new System.Drawing.Size(100, 23);
            this.YGOPRO2PathButton.TabIndex = 1;
            this.YGOPRO2PathButton.Text = "Select Path";
            this.YGOPRO2PathButton.UseVisualStyleBackColor = true;
            this.YGOPRO2PathButton.Click += new System.EventHandler(this.YGOPRO2Button_Click);
            // 
            // YGOPRO1Label
            // 
            this.YGOPRO1Label.AutoSize = true;
            this.YGOPRO1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YGOPRO1Label.Location = new System.Drawing.Point(9, 79);
            this.YGOPRO1Label.Name = "YGOPRO1Label";
            this.YGOPRO1Label.Size = new System.Drawing.Size(141, 17);
            this.YGOPRO1Label.TabIndex = 2;
            this.YGOPRO1Label.Text = "Path to YgoProLinks:";
            this.YGOPRO1Label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path to YGOPro2:";
            // 
            // YgoProLinksPath
            // 
            this.YgoProLinksPath.Enabled = false;
            this.YgoProLinksPath.Location = new System.Drawing.Point(159, 78);
            this.YgoProLinksPath.Name = "YgoProLinksPath";
            this.YgoProLinksPath.Size = new System.Drawing.Size(360, 20);
            this.YgoProLinksPath.TabIndex = 4;
            this.YgoProLinksPath.Visible = false;
            // 
            // YgoPro2Path
            // 
            this.YgoPro2Path.Location = new System.Drawing.Point(159, 31);
            this.YgoPro2Path.Name = "YgoPro2Path";
            this.YgoPro2Path.Size = new System.Drawing.Size(360, 20);
            this.YgoPro2Path.TabIndex = 5;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Location = new System.Drawing.Point(225, 224);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(182, 82);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update YGOPro2";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Status.Location = new System.Drawing.Point(33, 307);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(560, 23);
            this.Status.TabIndex = 8;
            this.Status.Text = "Ready";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(225, 333);
            this.progressBar.Maximum = 90;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(182, 23);
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(225, 383);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(182, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // internetCheckbox
            // 
            this.internetCheckbox.AutoSize = true;
            this.internetCheckbox.Checked = true;
            this.internetCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.internetCheckbox.Enabled = false;
            this.internetCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.internetCheckbox.Location = new System.Drawing.Point(12, 130);
            this.internetCheckbox.Name = "internetCheckbox";
            this.internetCheckbox.Size = new System.Drawing.Size(398, 21);
            this.internetCheckbox.TabIndex = 11;
            this.internetCheckbox.Text = "Download high quality pictures from the internet if possible.";
            this.internetCheckbox.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Enabled = false;
            this.footerLabel.Font = new System.Drawing.Font("Lato", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.footerLabel.Location = new System.Drawing.Point(522, 426);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(111, 15);
            this.footerLabel.TabIndex = 12;
            this.footerLabel.Text = "Created by Szefo09, ";
            // 
            // gitHubDownloadCheckbox
            // 
            this.gitHubDownloadCheckbox.AutoSize = true;
            this.gitHubDownloadCheckbox.Checked = true;
            this.gitHubDownloadCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gitHubDownloadCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gitHubDownloadCheckbox.Location = new System.Drawing.Point(12, 171);
            this.gitHubDownloadCheckbox.Name = "gitHubDownloadCheckbox";
            this.gitHubDownloadCheckbox.Size = new System.Drawing.Size(375, 21);
            this.gitHubDownloadCheckbox.TabIndex = 13;
            this.gitHubDownloadCheckbox.Text = "Download files from the internet without YGOPro Percy.";
            this.gitHubDownloadCheckbox.UseVisualStyleBackColor = true;
            this.gitHubDownloadCheckbox.CheckedChanged += new System.EventHandler(this.GitHubDownloadCheckbox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(225, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OverwriteCheckbox
            // 
            this.OverwriteCheckbox.AutoSize = true;
            this.OverwriteCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OverwriteCheckbox.Location = new System.Drawing.Point(12, 198);
            this.OverwriteCheckbox.Name = "OverwriteCheckbox";
            this.OverwriteCheckbox.Size = new System.Drawing.Size(153, 38);
            this.OverwriteCheckbox.TabIndex = 16;
            this.OverwriteCheckbox.Text = "Overwrite pictures.\r\n(Not recommended)";
            this.OverwriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(545, 230);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 13);
            this.debug.TabIndex = 17;
            // 
            // ReinstallCheckbox
            // 
            this.ReinstallCheckbox.AutoSize = true;
            this.ReinstallCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.ReinstallCheckbox.Location = new System.Drawing.Point(12, 242);
            this.ReinstallCheckbox.Name = "ReinstallCheckbox";
            this.ReinstallCheckbox.Size = new System.Drawing.Size(187, 38);
            this.ReinstallCheckbox.TabIndex = 19;
            this.ReinstallCheckbox.Text = "Reinstall YGOPro2 client \r\nbefore updating.\r\n";
            this.ReinstallCheckbox.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ShowAlways = true;
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.FinishButton.Enabled = false;
            this.FinishButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinishButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FinishButton.Location = new System.Drawing.Point(225, 224);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(182, 82);
            this.FinishButton.TabIndex = 21;
            this.FinishButton.Text = "Exit the updater\r\n&&\r\nLaunch YGOPro2.";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Visible = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(471, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "Please close YGOPro2\r\nbefore updating!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // UpdateCheckerButton
            // 
            this.UpdateCheckerButton.Location = new System.Drawing.Point(485, 112);
            this.UpdateCheckerButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateCheckerButton.Name = "UpdateCheckerButton";
            this.UpdateCheckerButton.Size = new System.Drawing.Size(140, 53);
            this.UpdateCheckerButton.TabIndex = 24;
            this.UpdateCheckerButton.Text = "Check For New Updates";
            this.UpdateCheckerButton.UseVisualStyleBackColor = true;
            this.UpdateCheckerButton.Click += new System.EventHandler(this.UpdateCheckerButton_Click);
            // 
            // UpdateCheckerTimeNumeric
            // 
            this.UpdateCheckerTimeNumeric.Location = new System.Drawing.Point(578, 180);
            this.UpdateCheckerTimeNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateCheckerTimeNumeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.UpdateCheckerTimeNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpdateCheckerTimeNumeric.Name = "UpdateCheckerTimeNumeric";
            this.UpdateCheckerTimeNumeric.Size = new System.Drawing.Size(47, 20);
            this.UpdateCheckerTimeNumeric.TabIndex = 25;
            this.UpdateCheckerTimeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpdateCheckerTimeNumeric.ValueChanged += new System.EventHandler(this.UpdateCheckerTimeNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(430, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Minutes between checks:";
            // 
            // UpdateWhenLabel
            // 
            this.UpdateWhenLabel.AutoSize = true;
            this.UpdateWhenLabel.Location = new System.Drawing.Point(430, 209);
            this.UpdateWhenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateWhenLabel.Name = "UpdateWhenLabel";
            this.UpdateWhenLabel.Size = new System.Drawing.Size(0, 13);
            this.UpdateWhenLabel.TabIndex = 27;
            // 
            // MimimizeButton
            // 
            this.MimimizeButton.Location = new System.Drawing.Point(505, 230);
            this.MimimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MimimizeButton.Name = "MimimizeButton";
            this.MimimizeButton.Size = new System.Drawing.Size(120, 25);
            this.MimimizeButton.TabIndex = 28;
            this.MimimizeButton.Text = "Minimize to taskbar";
            this.MimimizeButton.UseVisualStyleBackColor = true;
            this.MimimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "YgoProPatcher ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // StartMinimizedCheckbox
            // 
            this.StartMinimizedCheckbox.AutoSize = true;
            this.StartMinimizedCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartMinimizedCheckbox.Location = new System.Drawing.Point(474, 259);
            this.StartMinimizedCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.StartMinimizedCheckbox.Name = "StartMinimizedCheckbox";
            this.StartMinimizedCheckbox.Size = new System.Drawing.Size(151, 38);
            this.StartMinimizedCheckbox.TabIndex = 29;
            this.StartMinimizedCheckbox.Text = "Start minimized and\r\ncheck for updates.";
            this.StartMinimizedCheckbox.UseVisualStyleBackColor = true;
            // 
            // submitFaceButton
            // 
            this.submitFaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitFaceButton.Location = new System.Drawing.Point(12, 379);
            this.submitFaceButton.Name = "submitFaceButton";
            this.submitFaceButton.Size = new System.Drawing.Size(189, 62);
            this.submitFaceButton.TabIndex = 30;
            this.submitFaceButton.Text = "Click this if you want to \r\nsubmit your own custom face icon for YGOPro2";
            this.submitFaceButton.UseVisualStyleBackColor = true;
            this.submitFaceButton.Click += new System.EventHandler(this.FormSubmitButton_click);
            // 
            // YgoProPatcher
            // 
            this.AcceptButton = this.UpdateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.submitFaceButton);
            this.Controls.Add(this.StartMinimizedCheckbox);
            this.Controls.Add(this.MimimizeButton);
            this.Controls.Add(this.UpdateWhenLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateCheckerTimeNumeric);
            this.Controls.Add(this.UpdateCheckerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReinstallCheckbox);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.OverwriteCheckbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gitHubDownloadCheckbox);
            this.Controls.Add(this.footerLabel);
            this.Controls.Add(this.internetCheckbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.YgoPro2Path);
            this.Controls.Add(this.YgoProLinksPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YGOPRO1Label);
            this.Controls.Add(this.YGOPRO2PathButton);
            this.Controls.Add(this.YGOPRO1PathButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.Status);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YgoProPatcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGOPro2 Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YgoProPatcher_FormClosing);
            this.Load += new System.EventHandler(this.YgoProPatcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateCheckerTimeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YGOPRO1PathButton;
        private System.Windows.Forms.Button YGOPRO2PathButton;
        private System.Windows.Forms.Label YGOPRO1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YgoProLinksPath;
        private System.Windows.Forms.TextBox YgoPro2Path;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox internetCheckbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.CheckBox gitHubDownloadCheckbox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox OverwriteCheckbox;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.CheckBox ReinstallCheckbox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button UpdateCheckerButton;
        private System.Windows.Forms.NumericUpDown UpdateCheckerTimeNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpdateWhenLabel;
        private System.Windows.Forms.Button MimimizeButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox StartMinimizedCheckbox;
        private System.Windows.Forms.Button submitFaceButton;
    }
}
