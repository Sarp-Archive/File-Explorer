namespace Folder
{
    partial class exploreForm
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
            this.filesList = new System.Windows.Forms.ListBox();
            this.mainContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInWindowsExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTerminalHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCtx_S1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.navLayout = new System.Windows.Forms.TableLayoutPanel();
            this.reloadButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.Panel();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContext.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.navLayout.SuspendLayout();
            this.locationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesList
            // 
            this.filesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filesList.ContextMenuStrip = this.mainContext;
            this.filesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.filesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesList.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesList.FormattingEnabled = true;
            this.filesList.IntegralHeight = false;
            this.filesList.ItemHeight = 16;
            this.filesList.Location = new System.Drawing.Point(3, 43);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(794, 404);
            this.filesList.Sorted = true;
            this.filesList.TabIndex = 0;
            this.filesList.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // mainContext
            // 
            this.mainContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.mCtx_S1,
            this.refreshToolStripMenuItem,
            this.openInWindowsExplorerToolStripMenuItem,
            this.openTerminalHereToolStripMenuItem});
            this.mainContext.Name = "mainContext";
            this.mainContext.Size = new System.Drawing.Size(215, 164);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Folder.Properties.Resources.refreshBtn_30_green;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // openInWindowsExplorerToolStripMenuItem
            // 
            this.openInWindowsExplorerToolStripMenuItem.Image = global::Folder.Properties.Resources.explorer_30;
            this.openInWindowsExplorerToolStripMenuItem.Name = "openInWindowsExplorerToolStripMenuItem";
            this.openInWindowsExplorerToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openInWindowsExplorerToolStripMenuItem.Text = "Open in Windows Explorer";
            this.openInWindowsExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInWindowsExplorerToolStripMenuItem_Click);
            // 
            // openTerminalHereToolStripMenuItem
            // 
            this.openTerminalHereToolStripMenuItem.Image = global::Folder.Properties.Resources.terminalBtn_30;
            this.openTerminalHereToolStripMenuItem.Name = "openTerminalHereToolStripMenuItem";
            this.openTerminalHereToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openTerminalHereToolStripMenuItem.Text = "Open Terminal here";
            this.openTerminalHereToolStripMenuItem.Click += new System.EventHandler(this.openTerminalHereToolStripMenuItem_Click);
            // 
            // mCtx_S1
            // 
            this.mCtx_S1.Name = "mCtx_S1";
            this.mCtx_S1.Size = new System.Drawing.Size(211, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem});
            this.newToolStripMenuItem.Image = global::Folder.Properties.Resources.addBtn_30;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Folder.Properties.Resources.cleanBtn_30;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteToolStripMenuItem.Text = "Delete selection";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.filesList, 0, 1);
            this.mainLayout.Controls.Add(this.navLayout, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(10);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(800, 450);
            this.mainLayout.TabIndex = 1;
            // 
            // navLayout
            // 
            this.navLayout.ColumnCount = 3;
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navLayout.Controls.Add(this.reloadButton, 0, 0);
            this.navLayout.Controls.Add(this.upButton, 0, 0);
            this.navLayout.Controls.Add(this.locationBox, 2, 0);
            this.navLayout.Location = new System.Drawing.Point(0, 0);
            this.navLayout.Margin = new System.Windows.Forms.Padding(0);
            this.navLayout.Name = "navLayout";
            this.navLayout.RowCount = 1;
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navLayout.Size = new System.Drawing.Size(800, 40);
            this.navLayout.TabIndex = 1;
            // 
            // reloadButton
            // 
            this.reloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reloadButton.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadButton.Location = new System.Drawing.Point(43, 3);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(34, 34);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // upButton
            // 
            this.upButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upButton.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(3, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(34, 34);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.Color.White;
            this.locationBox.Controls.Add(this.locationTxt);
            this.locationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationBox.Location = new System.Drawing.Point(80, 0);
            this.locationBox.Margin = new System.Windows.Forms.Padding(0);
            this.locationBox.Name = "locationBox";
            this.locationBox.Padding = new System.Windows.Forms.Padding(11);
            this.locationBox.Size = new System.Drawing.Size(720, 40);
            this.locationBox.TabIndex = 1;
            // 
            // locationTxt
            // 
            this.locationTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxt.Location = new System.Drawing.Point(11, 11);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(698, 18);
            this.locationTxt.TabIndex = 0;
            this.locationTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.locationTxt_KeyDown);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openToolStripMenuItem.Text = "Open selection";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exploreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLayout);
            this.Icon = global::Folder.Properties.Resources.folder;
            this.Name = "exploreForm";
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainContext.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.navLayout.ResumeLayout(false);
            this.locationBox.ResumeLayout(false);
            this.locationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel navLayout;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Panel locationBox;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.ContextMenuStrip mainContext;
        private System.Windows.Forms.ToolStripMenuItem openTerminalHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator mCtx_S1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInWindowsExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

