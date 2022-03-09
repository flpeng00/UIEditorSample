namespace UIEditorSample
{
    partial class ResourceForm
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
            this.treeView_canvasResource = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView_canvasResource
            // 
            this.treeView_canvasResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_canvasResource.Location = new System.Drawing.Point(0, 0);
            this.treeView_canvasResource.Name = "treeView_canvasResource";
            this.treeView_canvasResource.Size = new System.Drawing.Size(247, 651);
            this.treeView_canvasResource.TabIndex = 0;
            // 
            // ResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 651);
            this.ControlBox = false;
            this.Controls.Add(this.treeView_canvasResource);
            this.Name = "ResourceForm";
            this.Text = "Canvas";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView_canvasResource;
    }
}