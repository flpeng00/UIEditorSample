using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIEditorSample
{
    public partial class PreviewForm : Form
    {
        public MainForm mainForm;

        public PreviewForm()
        {
            InitializeComponent();
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
        }

        private void PreviewForm_Paint(object sender, PaintEventArgs e)
        {
            MainCanvas.Invalidate();
        }

        private void MainCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (mainForm.workSpace.works != null)
                mainForm.workSpace.works.Paint(e.Graphics);
        }

        private void MainCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point point = new Point(me.X, me.Y);
            List<Entry.Entry> entries = mainForm.workSpace.GetEntryWithPoint(point);
            if (entries.Count <= 0)
            {
                mainForm.workSpace.SetSelecteEntry(-1);
                return;
            }
            mainForm.workSpace.SetSelecteEntry(entries[0].id);
        }
    }
}
