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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        public void RefreshTreeView()
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            Entry.Works works = mainForm.workSpace.works;

            if (works != null)
            {
                treeView_entryPool.BeginUpdate();
                treeView_entryPool.Nodes.Clear();
                TreeNode rootNode = works.MakeTreeNode(treeView_entryPool);
                treeView_entryPool.Nodes.Add(rootNode);
                treeView_entryPool.ExpandAll();
                treeView_entryPool.EndUpdate();
            }
        }

        public void RefreshPropertyGrid()
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            Entry.Entry entry = mainForm.workSpace.GetSelectedEntry();
            if (entry == null)
                propertyGrid_entryPool.ResetSelectedProperty();
            propertyGrid_entryPool.SelectedObject = entry;
        }
    }
}
