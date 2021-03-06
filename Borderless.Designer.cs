﻿namespace BorderlessGaming
{
    partial class Borderless
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borderless));
            this.makeBorderlessButton = new System.Windows.Forms.Button();
            this.selectedProcess = new System.Windows.Forms.Label();
            this.processList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.workerTimer = new System.Windows.Forms.Timer(this.components);
            this.addSelectedItem = new System.Windows.Forms.Button();
            this.bugReportButton = new System.Windows.Forms.Button();
            this.donateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeBorderlessButton
            // 
            this.makeBorderlessButton.Location = new System.Drawing.Point(223, 50);
            this.makeBorderlessButton.Name = "makeBorderlessButton";
            this.makeBorderlessButton.Size = new System.Drawing.Size(111, 36);
            this.makeBorderlessButton.TabIndex = 1;
            this.makeBorderlessButton.Text = "Make Borderless";
            this.makeBorderlessButton.UseVisualStyleBackColor = true;
            this.makeBorderlessButton.Click += new System.EventHandler(this.MakeBorderless);
            // 
            // selectedProcess
            // 
            this.selectedProcess.AutoSize = true;
            this.selectedProcess.Location = new System.Drawing.Point(224, 21);
            this.selectedProcess.Name = "selectedProcess";
            this.selectedProcess.Size = new System.Drawing.Size(107, 13);
            this.selectedProcess.TabIndex = 2;
            this.selectedProcess.Text = "No Process Selected";
            this.selectedProcess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(-1, -1);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(219, 199);
            this.processList.TabIndex = 0;
            this.processList.SelectedIndexChanged += new System.EventHandler(this.processList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(223, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(301, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 31);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // workerTimer
            // 
            this.workerTimer.Interval = 3000;
            this.workerTimer.Tick += new System.EventHandler(this.workerTimer_Tick);
            // 
            // addSelectedItem
            // 
            this.addSelectedItem.Location = new System.Drawing.Point(223, 92);
            this.addSelectedItem.Name = "addSelectedItem";
            this.addSelectedItem.Size = new System.Drawing.Size(111, 34);
            this.addSelectedItem.TabIndex = 7;
            this.addSelectedItem.Text = "Add Selected Item To Favorites";
            this.addSelectedItem.UseVisualStyleBackColor = true;
            this.addSelectedItem.Click += new System.EventHandler(this.sendGameName);
            // 
            // bugReportButton
            // 
            this.bugReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bugReportButton.BackgroundImage")));
            this.bugReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bugReportButton.Location = new System.Drawing.Point(262, 132);
            this.bugReportButton.Name = "bugReportButton";
            this.bugReportButton.Size = new System.Drawing.Size(33, 31);
            this.bugReportButton.TabIndex = 8;
            this.bugReportButton.UseVisualStyleBackColor = true;
            this.bugReportButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // donateButton
            // 
            this.donateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donateButton.Location = new System.Drawing.Point(238, 169);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(75, 23);
            this.donateButton.TabIndex = 9;
            this.donateButton.Text = "Donate";
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // Borderless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 195);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.bugReportButton);
            this.Controls.Add(this.addSelectedItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedProcess);
            this.Controls.Add(this.makeBorderlessButton);
            this.Controls.Add(this.processList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 234);
            this.MinimumSize = new System.Drawing.Size(351, 234);
            this.Name = "Borderless";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borderless Gaming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeBorderlessButton;
        private System.Windows.Forms.Label selectedProcess;
        private System.Windows.Forms.ListBox processList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer workerTimer;
        private System.Windows.Forms.Button addSelectedItem;
        private System.Windows.Forms.Button bugReportButton;
        private System.Windows.Forms.Button donateButton;
    }
}

