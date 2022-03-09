namespace UIEditorSample
{
    partial class EntryForm
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
            this.entryMenuContainer = new System.Windows.Forms.SplitContainer();
            this.treeView_entryPool = new System.Windows.Forms.TreeView();
            this.propertyGrid_entryPool = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.entryMenuContainer)).BeginInit();
            this.entryMenuContainer.Panel1.SuspendLayout();
            this.entryMenuContainer.Panel2.SuspendLayout();
            this.entryMenuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryMenuContainer
            // 
            this.entryMenuContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.entryMenuContainer.Name = "entryMenuContainer";
            this.entryMenuContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // entryMenuContainer.Panel1
            // 
            this.entryMenuContainer.Panel1.Controls.Add(this.treeView_entryPool);
            // 
            // entryMenuContainer.Panel2
            // 
            this.entryMenuContainer.Panel2.Controls.Add(this.propertyGrid_entryPool);
            this.entryMenuContainer.Size = new System.Drawing.Size(252, 667);
            this.entryMenuContainer.SplitterDistance = 297;
            this.entryMenuContainer.TabIndex = 0;
            // 
            // treeView_entryPool
            // 
            this.treeView_entryPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_entryPool.Location = new System.Drawing.Point(0, 0);
            this.treeView_entryPool.Name = "treeView_entryPool";
            this.treeView_entryPool.Size = new System.Drawing.Size(252, 297);
            this.treeView_entryPool.TabIndex = 0;
            // 
            // propertyGrid_entryPool
            // 
            this.propertyGrid_entryPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_entryPool.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid_entryPool.Name = "propertyGrid_entryPool";
            this.propertyGrid_entryPool.Size = new System.Drawing.Size(252, 366);
            this.propertyGrid_entryPool.TabIndex = 0;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 667);
            this.ControlBox = false;
            this.Controls.Add(this.entryMenuContainer);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.entryMenuContainer.Panel1.ResumeLayout(false);
            this.entryMenuContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entryMenuContainer)).EndInit();
            this.entryMenuContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer entryMenuContainer;
        private TreeView treeView_entryPool;
        private PropertyGrid propertyGrid_entryPool;
    }
}