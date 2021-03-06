﻿namespace BackgroundManager {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MonitorPanel = new System.Windows.Forms.Panel();
            this.MonitorYValue = new System.Windows.Forms.TextBox();
            this.MonitorYLabel = new System.Windows.Forms.Label();
            this.MonitorXValue = new System.Windows.Forms.TextBox();
            this.MonitorXLabel = new System.Windows.Forms.Label();
            this.MonitorSelectDropDown = new System.Windows.Forms.ComboBox();
            this.NumberOfMonitorValue = new System.Windows.Forms.TextBox();
            this.NumberOfMonitorLabel = new System.Windows.Forms.Label();
            this.UpdateMonitorInfoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectDirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.ScanButton = new System.Windows.Forms.Button();
            this.MonitorPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonitorPanel
            // 
            this.MonitorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MonitorPanel.Controls.Add(this.MonitorYValue);
            this.MonitorPanel.Controls.Add(this.MonitorYLabel);
            this.MonitorPanel.Controls.Add(this.MonitorXValue);
            this.MonitorPanel.Controls.Add(this.MonitorXLabel);
            this.MonitorPanel.Controls.Add(this.MonitorSelectDropDown);
            this.MonitorPanel.Controls.Add(this.NumberOfMonitorValue);
            this.MonitorPanel.Controls.Add(this.NumberOfMonitorLabel);
            this.MonitorPanel.Controls.Add(this.UpdateMonitorInfoButton);
            this.MonitorPanel.Location = new System.Drawing.Point(12, 290);
            this.MonitorPanel.Name = "MonitorPanel";
            this.MonitorPanel.Size = new System.Drawing.Size(375, 260);
            this.MonitorPanel.TabIndex = 0;
            // 
            // MonitorYValue
            // 
            this.MonitorYValue.Location = new System.Drawing.Point(54, 181);
            this.MonitorYValue.Name = "MonitorYValue";
            this.MonitorYValue.Size = new System.Drawing.Size(100, 20);
            this.MonitorYValue.TabIndex = 7;
            // 
            // MonitorYLabel
            // 
            this.MonitorYLabel.AutoSize = true;
            this.MonitorYLabel.Location = new System.Drawing.Point(13, 184);
            this.MonitorYLabel.Name = "MonitorYLabel";
            this.MonitorYLabel.Size = new System.Drawing.Size(38, 13);
            this.MonitorYLabel.TabIndex = 6;
            this.MonitorYLabel.Text = "Height";
            // 
            // MonitorXValue
            // 
            this.MonitorXValue.Location = new System.Drawing.Point(54, 155);
            this.MonitorXValue.Name = "MonitorXValue";
            this.MonitorXValue.Size = new System.Drawing.Size(100, 20);
            this.MonitorXValue.TabIndex = 5;
            // 
            // MonitorXLabel
            // 
            this.MonitorXLabel.AutoSize = true;
            this.MonitorXLabel.Location = new System.Drawing.Point(13, 158);
            this.MonitorXLabel.Name = "MonitorXLabel";
            this.MonitorXLabel.Size = new System.Drawing.Size(35, 13);
            this.MonitorXLabel.TabIndex = 4;
            this.MonitorXLabel.Text = "Width";
            // 
            // MonitorSelectDropDown
            // 
            this.MonitorSelectDropDown.FormattingEnabled = true;
            this.MonitorSelectDropDown.Location = new System.Drawing.Point(18, 112);
            this.MonitorSelectDropDown.Name = "MonitorSelectDropDown";
            this.MonitorSelectDropDown.Size = new System.Drawing.Size(121, 21);
            this.MonitorSelectDropDown.TabIndex = 3;
            this.MonitorSelectDropDown.SelectedIndexChanged += new System.EventHandler(this.MonitorDropdown_SelectionChanged);
            // 
            // NumberOfMonitorValue
            // 
            this.NumberOfMonitorValue.Location = new System.Drawing.Point(118, 59);
            this.NumberOfMonitorValue.Name = "NumberOfMonitorValue";
            this.NumberOfMonitorValue.Size = new System.Drawing.Size(100, 20);
            this.NumberOfMonitorValue.TabIndex = 2;
            // 
            // NumberOfMonitorLabel
            // 
            this.NumberOfMonitorLabel.AutoSize = true;
            this.NumberOfMonitorLabel.Location = new System.Drawing.Point(13, 62);
            this.NumberOfMonitorLabel.Name = "NumberOfMonitorLabel";
            this.NumberOfMonitorLabel.Size = new System.Drawing.Size(99, 13);
            this.NumberOfMonitorLabel.TabIndex = 1;
            this.NumberOfMonitorLabel.Text = "Number of Monitors";
            // 
            // UpdateMonitorInfoButton
            // 
            this.UpdateMonitorInfoButton.Location = new System.Drawing.Point(18, 26);
            this.UpdateMonitorInfoButton.Name = "UpdateMonitorInfoButton";
            this.UpdateMonitorInfoButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateMonitorInfoButton.TabIndex = 0;
            this.UpdateMonitorInfoButton.Text = "Refresh";
            this.UpdateMonitorInfoButton.UseVisualStyleBackColor = true;
            this.UpdateMonitorInfoButton.Click += new System.EventHandler(this.UpdateMonitorInfoButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ScanButton);
            this.panel1.Controls.Add(this.DirectoryTextBox);
            this.panel1.Controls.Add(this.SelectDirectoryButton);
            this.panel1.Location = new System.Drawing.Point(397, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 260);
            this.panel1.TabIndex = 1;
            // 
            // SelectDirectoryButton
            // 
            this.SelectDirectoryButton.Location = new System.Drawing.Point(22, 25);
            this.SelectDirectoryButton.Name = "SelectDirectoryButton";
            this.SelectDirectoryButton.Size = new System.Drawing.Size(100, 23);
            this.SelectDirectoryButton.TabIndex = 0;
            this.SelectDirectoryButton.Text = "Select Directory";
            this.SelectDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButton_Click);
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(129, 27);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.DirectoryTextBox.TabIndex = 1;
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(22, 55);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(75, 23);
            this.ScanButton.TabIndex = 2;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MonitorPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MonitorPanel.ResumeLayout(false);
            this.MonitorPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MonitorPanel;
        private System.Windows.Forms.TextBox MonitorYValue;
        private System.Windows.Forms.Label MonitorYLabel;
        private System.Windows.Forms.TextBox MonitorXValue;
        private System.Windows.Forms.Label MonitorXLabel;
        private System.Windows.Forms.ComboBox MonitorSelectDropDown;
        private System.Windows.Forms.TextBox NumberOfMonitorValue;
        private System.Windows.Forms.Label NumberOfMonitorLabel;
        private System.Windows.Forms.Button UpdateMonitorInfoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button SelectDirectoryButton;
    }
}

