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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YgoProPatcher));
            this.pathButtonYGOPRO1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YgoProLinksPath = new System.Windows.Forms.TextBox();
            this.YgoPro2Path = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancel = new System.Windows.Forms.Button();
            this.internetCheckbox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.gitHubDownloadCheckbox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.OverwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathButtonYGOPRO1
            // 
            this.pathButtonYGOPRO1.Enabled = false;
            this.pathButtonYGOPRO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathButtonYGOPRO1.Location = new System.Drawing.Point(525, 55);
            this.pathButtonYGOPRO1.Name = "pathButtonYGOPRO1";
            this.pathButtonYGOPRO1.Size = new System.Drawing.Size(100, 23);
            this.pathButtonYGOPRO1.TabIndex = 0;
            this.pathButtonYGOPRO1.Text = "Select Path";
            this.pathButtonYGOPRO1.UseVisualStyleBackColor = true;
            this.pathButtonYGOPRO1.Click += new System.EventHandler(this.YgoProLinksButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(525, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Select Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.YGOPRO2Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path to YgoProLinks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path to YGOPRO2:";
            // 
            // YgoProLinksPath
            // 
            this.YgoProLinksPath.Enabled = false;
            this.YgoProLinksPath.Location = new System.Drawing.Point(159, 58);
            this.YgoProLinksPath.Name = "YgoProLinksPath";
            this.YgoProLinksPath.Size = new System.Drawing.Size(360, 20);
            this.YgoProLinksPath.TabIndex = 4;
            // 
            // YgoPro2Path
            // 
            this.YgoPro2Path.Location = new System.Drawing.Point(159, 112);
            this.YgoPro2Path.Name = "YgoPro2Path";
            this.YgoPro2Path.Size = new System.Drawing.Size(360, 20);
            this.YgoPro2Path.TabIndex = 5;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Location = new System.Drawing.Point(225, 209);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(182, 82);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Patch YGOPRO2 using YGOPro Links";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Status.Location = new System.Drawing.Point(32, 291);
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
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(225, 383);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(182, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // internetCheckbox
            // 
            this.internetCheckbox.AutoSize = true;
            this.internetCheckbox.Checked = true;
            this.internetCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.internetCheckbox.Enabled = false;
            this.internetCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.internetCheckbox.Location = new System.Drawing.Point(12, 144);
            this.internetCheckbox.Name = "internetCheckbox";
            this.internetCheckbox.Size = new System.Drawing.Size(319, 21);
            this.internetCheckbox.TabIndex = 11;
            this.internetCheckbox.Text = "Download HQ Pics from the Internet if possible";
            this.internetCheckbox.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Lato Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(493, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Created by Szefo09, Version 2.0\r\n";
            // 
            // gitHubDownloadCheckbox
            // 
            this.gitHubDownloadCheckbox.AutoSize = true;
            this.gitHubDownloadCheckbox.Checked = true;
            this.gitHubDownloadCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gitHubDownloadCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gitHubDownloadCheckbox.Location = new System.Drawing.Point(12, 165);
            this.gitHubDownloadCheckbox.Name = "gitHubDownloadCheckbox";
            this.gitHubDownloadCheckbox.Size = new System.Drawing.Size(385, 21);
            this.gitHubDownloadCheckbox.TabIndex = 13;
            this.gitHubDownloadCheckbox.Text = "Download files without using YGOPRO1 from the Internet";
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
            this.OverwriteCheckbox.Location = new System.Drawing.Point(12, 192);
            this.OverwriteCheckbox.Name = "OverwriteCheckbox";
            this.OverwriteCheckbox.Size = new System.Drawing.Size(149, 38);
            this.OverwriteCheckbox.TabIndex = 16;
            this.OverwriteCheckbox.Text = "Overwrite Pics\r\n(Not reccomended)";
            this.OverwriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(525, 209);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 13);
            this.debug.TabIndex = 17;
            // 
            // YgoProPatcher
            // 
            this.AcceptButton = this.UpdateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.OverwriteCheckbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gitHubDownloadCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.internetCheckbox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.YgoPro2Path);
            this.Controls.Add(this.YgoProLinksPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathButtonYGOPRO1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YgoProPatcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGOPRO2 Updater using YGOPROLinks Beta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pathButtonYGOPRO1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YgoProLinksPath;
        private System.Windows.Forms.TextBox YgoPro2Path;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.CheckBox internetCheckbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox gitHubDownloadCheckbox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox OverwriteCheckbox;
        private System.Windows.Forms.Label debug;
    }
}

