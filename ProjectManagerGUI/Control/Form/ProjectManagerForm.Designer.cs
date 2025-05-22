
namespace ProjectManagerGUI {
    partial class ProjectManagerForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerForm));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ProjectViewButton = new System.Windows.Forms.Button();
            this.FileViewButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SelectedItemInformationLabel = new System.Windows.Forms.Label();
            this.ItemInformationLabel = new System.Windows.Forms.Label();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.OpenInFileExplorerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInProgramSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.NewViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomPanel.SuspendLayout();
            this.GlobalContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ProjectViewButton);
            this.BottomPanel.Controls.Add(this.FileViewButton);
            this.BottomPanel.Controls.Add(this.BrowseButton);
            this.BottomPanel.Controls.Add(this.CopyButton);
            this.BottomPanel.Controls.Add(this.SelectedItemInformationLabel);
            this.BottomPanel.Controls.Add(this.ItemInformationLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 413);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(778, 30);
            this.BottomPanel.TabIndex = 1;
            // 
            // ProjectViewButton
            // 
            this.ProjectViewButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProjectViewButton.BackgroundImage = global::ProjectManagerGUI.Properties.Resources._16pxCSharpProject;
            this.ProjectViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProjectViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProjectViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProjectViewButton.Location = new System.Drawing.Point(626, 3);
            this.ProjectViewButton.Name = "ProjectViewButton";
            this.ProjectViewButton.Size = new System.Drawing.Size(24, 24);
            this.ProjectViewButton.TabIndex = 12;
            this.ProjectViewButton.UseVisualStyleBackColor = true;
            this.ProjectViewButton.Click += new System.EventHandler(this.ProjectViewButton_Click);
            // 
            // FileViewButton
            // 
            this.FileViewButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FileViewButton.BackgroundImage = global::ProjectManagerGUI.Properties.Resources._16pxTextFile;
            this.FileViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FileViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FileViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FileViewButton.Location = new System.Drawing.Point(598, 3);
            this.FileViewButton.Name = "FileViewButton";
            this.FileViewButton.Size = new System.Drawing.Size(24, 24);
            this.FileViewButton.TabIndex = 11;
            this.FileViewButton.UseVisualStyleBackColor = true;
            this.FileViewButton.Click += new System.EventHandler(this.FileViewButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BrowseButton.BackgroundImage = global::ProjectManagerGUI.Properties.Resources._16pxBrowser;
            this.BrowseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BrowseButton.Location = new System.Drawing.Point(677, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(24, 24);
            this.BrowseButton.TabIndex = 10;
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyButton.Location = new System.Drawing.Point(704, 3);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 24);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SelectedItemInformationLabel
            // 
            this.SelectedItemInformationLabel.AutoSize = true;
            this.SelectedItemInformationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectedItemInformationLabel.Location = new System.Drawing.Point(230, 7);
            this.SelectedItemInformationLabel.Name = "SelectedItemInformationLabel";
            this.SelectedItemInformationLabel.Size = new System.Drawing.Size(86, 15);
            this.SelectedItemInformationLabel.TabIndex = 8;
            this.SelectedItemInformationLabel.Text = "Selected items:";
            // 
            // ItemInformationLabel
            // 
            this.ItemInformationLabel.AutoSize = true;
            this.ItemInformationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ItemInformationLabel.Location = new System.Drawing.Point(-2, 7);
            this.ItemInformationLabel.Name = "ItemInformationLabel";
            this.ItemInformationLabel.Size = new System.Drawing.Size(39, 15);
            this.ItemInformationLabel.TabIndex = 7;
            this.ItemInformationLabel.Text = "Items:";
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomPanel, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 6);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalContainer.Size = new System.Drawing.Size(778, 443);
            this.GlobalContainer.TabIndex = 2;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenInFileExplorerMenuItem,
            this.OpenInProgramMenuItem,
            this.OpenInProgramSeperator,
            this.NewViewMenuItem,
            this.NewWindowMenuItem});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(184, 98);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // OpenInFileExplorerMenuItem
            // 
            this.OpenInFileExplorerMenuItem.Image = global::ProjectManagerGUI.Properties.Resources._50pxFileExplorer;
            this.OpenInFileExplorerMenuItem.Name = "OpenInFileExplorerMenuItem";
            this.OpenInFileExplorerMenuItem.Size = new System.Drawing.Size(183, 22);
            this.OpenInFileExplorerMenuItem.Text = "Open in File Explorer";
            this.OpenInFileExplorerMenuItem.Click += new System.EventHandler(this.OpenInFileExplorerMenuItem_Click);
            // 
            // OpenInProgramMenuItem
            // 
            this.OpenInProgramMenuItem.Image = global::ProjectManagerGUI.Properties.Resources._16pxApplication;
            this.OpenInProgramMenuItem.Name = "OpenInProgramMenuItem";
            this.OpenInProgramMenuItem.Size = new System.Drawing.Size(183, 22);
            this.OpenInProgramMenuItem.Text = "Open in program";
            this.OpenInProgramMenuItem.Click += new System.EventHandler(this.OpenInProgramMenuItem_Click);
            // 
            // OpenInProgramSeperator
            // 
            this.OpenInProgramSeperator.Name = "OpenInProgramSeperator";
            this.OpenInProgramSeperator.Size = new System.Drawing.Size(180, 6);
            // 
            // NewViewMenuItem
            // 
            this.NewViewMenuItem.Image = global::ProjectManagerGUI.Properties.Resources._16pxView;
            this.NewViewMenuItem.Name = "NewViewMenuItem";
            this.NewViewMenuItem.Size = new System.Drawing.Size(183, 22);
            this.NewViewMenuItem.Text = "New view";
            this.NewViewMenuItem.Click += new System.EventHandler(this.NewViewMenuItem_Click);
            // 
            // NewWindowMenuItem
            // 
            this.NewWindowMenuItem.Image = global::ProjectManagerGUI.Properties.Resources._16xNewWindow;
            this.NewWindowMenuItem.Name = "NewWindowMenuItem";
            this.NewWindowMenuItem.Size = new System.Drawing.Size(183, 22);
            this.NewWindowMenuItem.Text = "New window";
            this.NewWindowMenuItem.Click += new System.EventHandler(this.NewWindowMenuItem_Click);
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectManagerForm";
            this.Padding = new System.Windows.Forms.Padding(10, 6, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Manager";
            this.Load += new System.EventHandler(this.ProjectManagerForm_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.GlobalContainer.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenInFileExplorerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenInProgramMenuItem;
        private System.Windows.Forms.ToolStripSeparator OpenInProgramSeperator;
        private System.Windows.Forms.ToolStripMenuItem NewViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewWindowMenuItem;
        private System.Windows.Forms.Button ProjectViewButton;
        private System.Windows.Forms.Button FileViewButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label SelectedItemInformationLabel;
        private System.Windows.Forms.Label ItemInformationLabel;
    }
}

