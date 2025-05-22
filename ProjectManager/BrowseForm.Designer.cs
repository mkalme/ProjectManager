
namespace ProjectManager {
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
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ProjectsFolderLabel = new System.Windows.Forms.Label();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressContainerPanel = new System.Windows.Forms.Panel();
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.TextBoxPanel.SuspendLayout();
            this.ProgressContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Image = global::ProjectManager.Properties.Resources._16pxBrowser;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.Location = new System.Drawing.Point(12, 27);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BrowseButton.Size = new System.Drawing.Size(75, 24);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Location = new System.Drawing.Point(12, 96);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 24);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
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
            // TextBoxPanel
            // 
            this.TextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPanel.Controls.Add(this.PathTextBox);
            this.TextBoxPanel.Location = new System.Drawing.Point(97, 27);
            this.TextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.TextBoxPanel.Size = new System.Drawing.Size(325, 24);
            this.TextBoxPanel.TabIndex = 4;
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(4, 4);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(319, 16);
            this.PathTextBox.TabIndex = 0;
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
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(431, 132);
            this.Controls.Add(this.ProgressContainerPanel);
            this.Controls.Add(this.TextBoxPanel);
            this.Controls.Add(this.ProjectsFolderLabel);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.BrowseButton);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BrowseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browse for projects";
            this.Shown += new System.EventHandler(this.BrowseForm_Shown);
            this.TextBoxPanel.ResumeLayout(false);
            this.TextBoxPanel.PerformLayout();
            this.ProgressContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label ProjectsFolderLabel;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Panel ProgressContainerPanel;
        private System.Windows.Forms.Panel ProgressPanel;
    }
}