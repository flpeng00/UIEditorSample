namespace UIEditorSample
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contextSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contextTreeView = new System.Windows.Forms.TreeView();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextSplitContainer)).BeginInit();
            this.contextSplitContainer.Panel1.SuspendLayout();
            this.contextSplitContainer.Panel2.SuspendLayout();
            this.contextSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.windowToolStripMenuItem;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1348, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 28);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.contextSplitContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(1348, 693);
            this.mainSplitContainer.SplitterDistance = 1041;
            this.mainSplitContainer.TabIndex = 7;
            // 
            // contextSplitContainer
            // 
            this.contextSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contextSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contextSplitContainer.Name = "contextSplitContainer";
            this.contextSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contextSplitContainer.Panel1
            // 
            this.contextSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.contextSplitContainer.Panel1.Controls.Add(this.contextTreeView);
            // 
            // contextSplitContainer.Panel2
            // 
            this.contextSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.contextSplitContainer.Panel2.Controls.Add(this.propertyGrid);
            this.contextSplitContainer.Size = new System.Drawing.Size(303, 693);
            this.contextSplitContainer.SplitterDistance = 259;
            this.contextSplitContainer.TabIndex = 0;
            // 
            // contextTreeView
            // 
            this.contextTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contextTreeView.Location = new System.Drawing.Point(0, 0);
            this.contextTreeView.Name = "contextTreeView";
            this.contextTreeView.Size = new System.Drawing.Size(303, 259);
            this.contextTreeView.TabIndex = 0;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(303, 430);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.contextSplitContainer.Panel1.ResumeLayout(false);
            this.contextSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextSplitContainer)).EndInit();
            this.contextSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private SplitContainer mainSplitContainer;
        private SplitContainer contextSplitContainer;
        private TreeView contextTreeView;
        private PropertyGrid propertyGrid;
    }
}