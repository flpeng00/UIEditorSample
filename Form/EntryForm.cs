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
            WorkSpace work = WorkSpace.Instance();
            Entry.Works works = work.works;

            if (works != null)
            {
                treeView_entryPool.BeginUpdate();
                treeView_entryPool.Nodes.Clear();
                TreeNode rootNode = works.MakeTreeNode();
                treeView_entryPool.Nodes.Add(rootNode);
                treeView_entryPool.ExpandAll();
                treeView_entryPool.EndUpdate();

                if (work.selectedID >= 0)
                    RefreshTreeNodeSelection(treeView_entryPool.TopNode, work.selectedID);
            }
        }

        private bool RefreshTreeNodeSelection(TreeNode node, int id)
        {
            if (node == null)
                return false;
            Entry.Entry? entry = node.Tag as Entry.Entry;
            if (entry == null)
                return false;
            if (entry.id == id)
            {
                treeView_entryPool.SelectedNode = node;
                return true;
            }
            foreach(TreeNode child in node.Nodes)
            {
                if (RefreshTreeNodeSelection(child, id))
                    return true;
            }
            return false;
        }

        public void RefreshPropertyGrid()
        {
            Entry.Entry? entry = WorkSpace.Instance().GetSelectedEntry();
            if (entry == null)
                propertyGrid_entryPool.ResetSelectedProperty();
            propertyGrid_entryPool.SelectedObject = entry;
        }

        private void propertyGrid_entryPool_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            WorkSpace.Instance().OnEntryChanged();
        }

        private void treeView_entryPool_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;
            Entry.Entry selected = (Entry.Entry)e.Node.Tag;
            if (selected == null)
                return;
            WorkSpace.Instance().SetSelecteEntry(selected.id);
        }

        public void OnSelectedChange()
        {
            int selected = WorkSpace.Instance().selectedID;
            if (selected < 0)
            {
                treeView_entryPool.SelectedNode = null;
            }
            else
            {
                int node = -1;
                if (treeView_entryPool.SelectedNode != null)
                {
                    Entry.Entry? e = (Entry.Entry)treeView_entryPool.SelectedNode.Tag;
                    if (e != null)
                    {
                        node = e.id;
                    }
                }
                if (selected != node)
                    RefreshTreeView();
            }
        }
    }
}
