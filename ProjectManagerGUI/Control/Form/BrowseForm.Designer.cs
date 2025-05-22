
namespace ProjectManagerGUI {
    partial class BrowseForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
            this.ProjectsFolderLabel = new System.Windows.Forms.Label();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressContainerPanel = new System.Windows.Forms.Panel();
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.SelectButton = new CustomDialogs.DarkButton();
            this.PathTextBox = new CustomDialogs.DarkTextBox();
            this.BrowseButton = new CustomDialogs.DarkButton();
            this.ProgressContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectsFolderLabel
            // 
            this.ProjectsFolderLabel.AutoSize = true;
            this.ProjectsFolderLabel.Location = new System.Drawing.Point(8, 10);
            this.ProjectsFolderLabel.Name = "ProjectsFolderLabel";
            this.ProjectsFolderLabel.Size = new System.Drawing.Size(83, 15);
            this.ProjectsFolderLabel.TabIndex = 2;
            this.ProjectsFolderLabel.Text = "Projects folder";
            // 
            // ProgressContainerPanel
            // 
            this.ProgressContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProgressContainerPanel.Controls.Add(this.ProgressPanel);
            this.ProgressContainerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressContainerPanel.Location = new System.Drawing.Point(0, 127);
            this.ProgressContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressContainerPanel.Name = "ProgressContainerPanel";
            this.ProgressContainerPanel.Size = new System.Drawing.Size(431, 5);
            this.ProgressContainerPanel.TabIndex = 5;
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(171)))), ((int)(((byte)(105)))));
            this.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProgressPanel.Location = new System.Drawing.Point(0, 0);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(0, 5);
            this.ProgressPanel.TabIndex = 0;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SelectButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectButton.Location = new System.Drawing.Point(12, 96);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 24);
            this.SelectButton.TabIndex = 6;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(97, 27);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.PathTextBox.PasswordChar = '\0';
            this.PathTextBox.ReadOnly = false;
            this.PathTextBox.Size = new System.Drawing.Size(324, 24);
            this.PathTextBox.TabIndex = 7;
            this.PathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.XOffset = 0;
            this.PathTextBox.YOffset = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BrowseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Image = global::ProjectManagerGUI.Properties.Resources._16pxBrowser;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.Location = new System.Drawing.Point(12, 27);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BrowseButton.Size = new System.Drawing.Size(75, 24);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(431, 132);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ProgressContainerPanel);
            this.Controls.Add(this.ProjectsFolderLabel);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BrowseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browse for projects";
            this.Shown += new System.EventHandler(this.BrowseForm_Shown);
            this.ProgressContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProjectsFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Panel ProgressContainerPanel;
        private System.Windows.Forms.Panel ProgressPanel;
        private CustomDialogs.DarkButton SelectButton;
        private CustomDialogs.DarkTextBox PathTextBox;
        private CustomDialogs.DarkButton BrowseButton;
    }
}