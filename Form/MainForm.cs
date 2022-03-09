namespace UIEditorSample
{
    public partial class MainForm : Form
    {
        public WorkSpace workSpace;
        public PreviewForm previewForm;
        public EntryForm entryForm;
        public ResourceForm resourceForm;

        public MainForm()
        {
            InitializeComponent();
            entryForm = new EntryForm();
            entryForm.MdiParent = this;
            entryForm.StartPosition = FormStartPosition.Manual;
            entryForm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - entryForm.Width, 0);
            entryForm.Show();
            

            resourceForm = new ResourceForm();
            resourceForm.MdiParent = this;
            resourceForm.Show();

            previewForm = new PreviewForm();
            previewForm.TopLevel = false;
            previewForm.mainForm = this;
            previewForm.MdiParent = this;

            workSpace = new WorkSpace(this, previewForm);
            previewForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            workSpace.Init();
            entryForm.RefreshTreeView();
        }

        private void getCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                filePath = openFileDialog.FileName;
            }

            CanvasInfo canvasInfo = new CanvasInfo();
            canvasInfo.path = filePath;
            canvasInfo.name = Path.GetFileName(filePath);
            resourceForm.AddCanvasInfo(canvasInfo);
        }

        public void OnEntryChanged()
        {
            entryForm.RefreshTreeView();
            previewForm.Invalidate();
        }

        public void OnEntrySelected()
        {
            entryForm.RefreshTreeView();
            entryForm.RefreshPropertyGrid();
        }
    }
}