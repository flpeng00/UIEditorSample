namespace UIEditorSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviewForm previewForm = new PreviewForm();
            previewForm.MdiParent = this;
            this.mainSplitContainer.Panel1.Controls.Add(previewForm);
            previewForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            contextTreeView.Nodes.Add("Parent");
            contextTreeView.Nodes[0].Nodes.Add("Child");
        }
    }
}