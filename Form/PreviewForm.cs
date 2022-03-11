using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace UIEditorSample
{
    public partial class PreviewForm : Form
    {
        enum DragDropMode
        {
            None,
            Select,
            Move,
            Copy,
        }
        public MainForm mainForm;
        private bool onDrag = false;
        private DragDropMode dragMode = DragDropMode.None;
        private Point dragOffset = new Point(0, 0);

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

            WorkSpace workSpace = WorkSpace.Instance();
            Entry.Entry selectedEntry = workSpace.GetSelectedEntry();
            if (selectedEntry != null)
            {
                const int penWidth = 2;
                Rectangle rect = selectedEntry.range;
                rect.X += MainCanvas.Left - penWidth / 2;
                rect.Y += MainCanvas.Top - penWidth / 2;
                Pen pen = new Pen(Color.WhiteSmoke, penWidth);
                pen.DashPattern = new float[] { 1f, 1f };
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void MainCanvas_Paint(object sender, PaintEventArgs e)
        {
            WorkSpace.Instance().works.Paint(e.Graphics);

            WorkSpace workSpace = WorkSpace.Instance();
            Entry.Entry selectedEntry = workSpace.GetSelectedEntry();
            if (selectedEntry != null)
            {
                const int penWidth = 2;
                Rectangle rect = selectedEntry.range;
                rect.X += -penWidth / 2;
                rect.Y += -penWidth / 2;
                Pen pen = new Pen(Color.Yellow, penWidth);
                pen.DashPattern = new float[] { 1f, 1f };
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void MainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            WorkSpace workSpace = WorkSpace.Instance();
            Entry.Entry? selected = workSpace.GetSelectedEntry();
            if (selected == null)
                return;

            if (Control.ModifierKeys == Keys.Control)
            {
                dragMode = DragDropMode.Copy;
            }
            else if (Control.ModifierKeys == Keys.Alt)
            {
                dragMode = DragDropMode.Move;
            }
            onDrag = true;
            dragOffset.X = e.Location.X - selected.GetLocation().X;
            dragOffset.Y = e.Location.Y - selected.GetLocation().Y;
        }

        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!onDrag)
                return;

            WorkSpace workSpace = WorkSpace.Instance();
            Entry.Entry? selected = workSpace.GetSelectedEntry();
            if (selected == null)
            {
                onDrag = false;
                dragMode = DragDropMode.None;
                return;
            }

            switch (dragMode)
            {
                case DragDropMode.None:
                    break;
                case DragDropMode.Move:
                    Point point = e.Location;
                    point.X -= dragOffset.X;
                    point.Y -= dragOffset.Y;
                    selected.Move(point);
                    mainForm.OnEntryChanged();
                    break;
            }
        }

        private void MainCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point point = new Point(me.X, me.Y);
            List<Entry.Entry> entries = WorkSpace.Instance().GetEntryWithPoint(point);
            if (entries.Count <= 0)
            {
                WorkSpace.Instance().SetSelecteEntry(-1);
                return;
            }
            WorkSpace.Instance().SetSelecteEntry(entries[0].id);
        }

        private void MainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            onDrag = false;
            dragMode = DragDropMode.None;
        }
    }
}
