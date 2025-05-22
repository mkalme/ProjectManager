
namespace ProjectManager {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerForm));
            this.LineDataGridView = new System.Windows.Forms.DataGridView();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new ProjectManager.TextAndImageColumn();
            this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenInFileExplorerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramToolStripSeperator = new ProjectManager.ExtendedToolStripSeparator();
            this.NewViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PathLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GoForwardsButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.PathPanel = new ProjectManager.PathPanel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ProjectViewButton = new System.Windows.Forms.Button();
            this.FileViewButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SelectedItemInformationLabel = new System.Windows.Forms.Label();
            this.ItemInformationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LineDataGridView)).BeginInit();
            this.LineContextMenuStrip.SuspendLayout();
            this.LayoutPanel.SuspendLayout();
            this.PathLayoutPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineDataGridView
            // 
            this.LineDataGridView.AllowUserToAddRows = false;
            this.LineDataGridView.AllowUserToDeleteRows = false;
            this.LineDataGridView.AllowUserToResizeRows = false;
            this.LineDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LineDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LineDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LineDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.NameColumn,
            this.PathColumn,
            this.LineCountColumn,
            this.ProjectTypeColumn,
            this.CreationDateColumn});
            this.LineDataGridView.ContextMenuStrip = this.LineContextMenuStrip;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LineDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.LineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineDataGridView.EnableHeadersVisualStyles = false;
            this.LineDataGridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.LineDataGridView.Location = new System.Drawing.Point(0, 37);
            this.LineDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.LineDataGridView.Name = "LineDataGridView";
            this.LineDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LineDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.LineDataGridView.RowTemplate.Height = 23;
            this.LineDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LineDataGridView.Size = new System.Drawing.Size(778, 382);
            this.LineDataGridView.TabIndex = 0;
            this.LineDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LineDataGridView_CellDoubleClick);
            this.LineDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LineDataGridView_CellFormatting);
            this.LineDataGridView.SelectionChanged += new System.EventHandler(this.LineDataGridView_SelectionChanged);
            this.LineDataGridView.Sorted += new System.EventHandler(this.LineDataGridView_Sorted);
            // 
            // IndexColumn
            // 
            this.IndexColumn.HeaderText = "";
            this.IndexColumn.Name = "IndexColumn";
            this.IndexColumn.ReadOnly = true;
            this.IndexColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Image = null;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 190;
            // 
            // PathColumn
            // 
            this.PathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PathColumn.HeaderText = "Path";
            this.PathColumn.Name = "PathColumn";
            this.PathColumn.ReadOnly = true;
            // 
            // LineCountColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.LineCountColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.LineCountColumn.HeaderText = "Lines";
            this.LineCountColumn.Name = "LineCountColumn";
            this.LineCountColumn.ReadOnly = true;
            this.LineCountColumn.Width = 55;
            // 
            // ProjectTypeColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ProjectTypeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectTypeColumn.HeaderText = "Type";
            this.ProjectTypeColumn.Name = "ProjectTypeColumn";
            this.ProjectTypeColumn.ReadOnly = true;
            this.ProjectTypeColumn.Width = 120;
            // 
            // CreationDateColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "MMM d, yyyy";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CreationDateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.CreationDateColumn.HeaderText = "Creation date";
            this.CreationDateColumn.Name = "CreationDateColumn";
            this.CreationDateColumn.ReadOnly = true;
            this.CreationDateColumn.Width = 105;
            // 
            // LineContextMenuStrip
            // 
            this.LineContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LineContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenInFileExplorerMenuItem,
            this.OpenInProgramMenuItem,
            this.ProgramToolStripSeperator,
            this.NewViewMenuItem,
            this.NewWindowMenuItem});
            this.LineContextMenuStrip.Name = "LineContextMenuStrip";
            this.LineContextMenuStrip.Size = new System.Drawing.Size(184, 98);
            this.LineContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.LineContextMenuStrip_Opening);
            // 
            // OpenInFileExplorerMenuItem
            // 
            this.OpenInFileExplorerMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenInFileExplorerMenuItem.Image = global::ProjectManager.Properties.Resources._16pxFileExplorer;
            this.OpenInFileExplorerMenuItem.Name = "OpenInFileExplorerMenuItem";
            this.OpenInFileExplorerMenuItem.Size = new System.Drawing.Size(183, 22);
            this.OpenInFileExplorerMenuItem.Text = "Open in File Explorer";
            this.OpenInFileExplorerMenuItem.Click += new System.EventHandler(this.OpenInFileExplorerMenuItem_Click);
            // 
            // OpenInProgramMenuItem
            // 
            this.OpenInProgramMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenInProgramMenuItem.Image = global::ProjectManager.Properties.Resources._16pxApplication;
            this.OpenInProgramMenuItem.Name = "OpenInProgramMenuItem";
            this.OpenInProgramMenuItem.Size = new System.Drawing.Size(183, 22);
            this.OpenInProgramMenuItem.Text = "Open in program";
            this.OpenInProgramMenuItem.Click += new System.EventHandler(this.OpenInProgramMenuItem_Click);
            // 
            // ProgramToolStripSeperator
            // 
            this.ProgramToolStripSeperator.Name = "ProgramToolStripSeperator";
            this.ProgramToolStripSeperator.Size = new System.Drawing.Size(180, 6);
            // 
            // NewViewMenuItem
            // 
            this.NewViewMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewViewMenuItem.Image = global::ProjectManager.Properties.Resources._16pxView;
            this.NewViewMenuItem.Name = "NewViewMenuItem";
            this.NewViewMenuItem.Size = new System.Drawing.Size(183, 22);
            this.NewViewMenuItem.Text = "New view";
            this.NewViewMenuItem.Click += new System.EventHandler(this.NewViewMenuItem_Click);
            // 
            // NewWindowMenuItem
            // 
            this.NewWindowMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewWindowMenuItem.Image = global::ProjectManager.Properties.Resources._16xNewWindow;
            this.NewWindowMenuItem.Name = "NewWindowMenuItem";
            this.NewWindowMenuItem.Size = new System.Drawing.Size(183, 22);
            this.NewWindowMenuItem.Text = "New window";
            this.NewWindowMenuItem.Click += new System.EventHandler(this.NewWindowMenuItem_Click);
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Controls.Add(this.PathLayoutPanel, 0, 0);
            this.LayoutPanel.Controls.Add(this.LineDataGridView, 0, 1);
            this.LayoutPanel.Controls.Add(this.BottomPanel, 0, 2);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(10, 0);
            this.LayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 3;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutPanel.Size = new System.Drawing.Size(778, 449);
            this.LayoutPanel.TabIndex = 1;
            // 
            // PathLayoutPanel
            // 
            this.PathLayoutPanel.ColumnCount = 3;
            this.PathLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PathLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PathLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PathLayoutPanel.Controls.Add(this.GoForwardsButton, 1, 0);
            this.PathLayoutPanel.Controls.Add(this.GoBackButton, 0, 0);
            this.PathLayoutPanel.Controls.Add(this.PathPanel, 2, 0);
            this.PathLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathLayoutPanel.Location = new System.Drawing.Point(0, 6);
            this.PathLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.PathLayoutPanel.Name = "PathLayoutPanel";
            this.PathLayoutPanel.RowCount = 1;
            this.PathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PathLayoutPanel.Size = new System.Drawing.Size(778, 25);
            this.PathLayoutPanel.TabIndex = 2;
            // 
            // GoForwardsButton
            // 
            this.GoForwardsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GoForwardsButton.BackgroundImage = global::ProjectManager.Properties.Resources._512pxRightArrow;
            this.GoForwardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoForwardsButton.FlatAppearance.BorderSize = 0;
            this.GoForwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoForwardsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GoForwardsButton.Location = new System.Drawing.Point(24, 1);
            this.GoForwardsButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoForwardsButton.Name = "GoForwardsButton";
            this.GoForwardsButton.Size = new System.Drawing.Size(23, 23);
            this.GoForwardsButton.TabIndex = 1;
            this.GoForwardsButton.UseVisualStyleBackColor = true;
            this.GoForwardsButton.Click += new System.EventHandler(this.GoForwardsButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GoBackButton.BackgroundImage = global::ProjectManager.Properties.Resources._512pxLeftArrow;
            this.GoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBackButton.FlatAppearance.BorderSize = 0;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GoBackButton.Location = new System.Drawing.Point(0, 1);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(23, 23);
            this.GoBackButton.TabIndex = 0;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // PathPanel
            // 
            this.PathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanel.Location = new System.Drawing.Point(54, 0);
            this.PathPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(724, 25);
            this.PathPanel.TabIndex = 2;
            this.PathPanel.ButtonClick += new System.EventHandler(this.PathPanel_ButtonClick);
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
            this.BottomPanel.Location = new System.Drawing.Point(0, 419);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(778, 30);
            this.BottomPanel.TabIndex = 1;
            // 
            // ProjectViewButton
            // 
            this.ProjectViewButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProjectViewButton.BackgroundImage = global::ProjectManager.Properties.Resources._16pxCSharpProject;
            this.ProjectViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProjectViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProjectViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProjectViewButton.Location = new System.Drawing.Point(626, 3);
            this.ProjectViewButton.Name = "ProjectViewButton";
            this.ProjectViewButton.Size = new System.Drawing.Size(24, 24);
            this.ProjectViewButton.TabIndex = 6;
            this.ProjectViewButton.UseVisualStyleBackColor = true;
            this.ProjectViewButton.Click += new System.EventHandler(this.ProjectViewButton_Click);
            // 
            // FileViewButton
            // 
            this.FileViewButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FileViewButton.BackgroundImage = global::ProjectManager.Properties.Resources._16pxTextFile;
            this.FileViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FileViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FileViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FileViewButton.Location = new System.Drawing.Point(598, 3);
            this.FileViewButton.Name = "FileViewButton";
            this.FileViewButton.Size = new System.Drawing.Size(24, 24);
            this.FileViewButton.TabIndex = 5;
            this.FileViewButton.UseVisualStyleBackColor = true;
            this.FileViewButton.Click += new System.EventHandler(this.FileViewButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BrowseButton.BackgroundImage = global::ProjectManager.Properties.Resources._16pxBrowser;
            this.BrowseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BrowseButton.Location = new System.Drawing.Point(677, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(24, 24);
            this.BrowseButton.TabIndex = 4;
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
            this.CopyButton.Size = new System.Drawing.Size(74, 24);
            this.CopyButton.TabIndex = 3;
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
            this.SelectedItemInformationLabel.TabIndex = 2;
            this.SelectedItemInformationLabel.Text = "Selected items:";
            // 
            // ItemInformationLabel
            // 
            this.ItemInformationLabel.AutoSize = true;
            this.ItemInformationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ItemInformationLabel.Location = new System.Drawing.Point(-2, 7);
            this.ItemInformationLabel.Name = "ItemInformationLabel";
            this.ItemInformationLabel.Size = new System.Drawing.Size(39, 15);
            this.ItemInformationLabel.TabIndex = 1;
            this.ItemInformationLabel.Text = "Items:";
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.LayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectManagerForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Manager";
            this.Load += new System.EventHandler(this.ProjectManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineDataGridView)).EndInit();
            this.LineContextMenuStrip.ResumeLayout(false);
            this.LayoutPanel.ResumeLayout(false);
            this.PathLayoutPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LineDataGridView;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label ItemInformationLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button GoForwardsButton;
        private System.Windows.Forms.ContextMenuStrip LineContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenInFileExplorerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenInProgramMenuItem;
        private System.Windows.Forms.Label SelectedItemInformationLabel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TableLayoutPanel PathLayoutPanel;
        private PathPanel PathPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private TextAndImageColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateColumn;
        private System.Windows.Forms.Button ProjectViewButton;
        private System.Windows.Forms.Button FileViewButton;
        private System.Windows.Forms.ToolStripMenuItem NewViewMenuItem;
        private ExtendedToolStripSeparator ProgramToolStripSeperator;
        private System.Windows.Forms.ToolStripMenuItem NewWindowMenuItem;
    }
}

