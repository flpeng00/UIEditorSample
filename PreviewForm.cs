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
        public PreviewForm()
        {
            InitializeComponent();
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            layer = new LayerGuide();
            layer.rc = new Rectangle(10, 10, 100, 100);
            layer.color = Color.Red;
        }

        private void PreviewForm_Paint(object sender, PaintEventArgs e)
        {
            layer.Draw(e.Graphics);
        }

        private void PreviewForm_Click(object sender, EventArgs e)
        {
            MouseEventArgs e2 = (MouseEventArgs)e;
            if( layer.rc.Contains(e2.X, e2.Y))
            {
                MainForm mainForm = (MainForm)this.ParentForm;
                mainForm.ShowProperty(layer);

            }
        }

        LayerGuide layer;
    }
}
