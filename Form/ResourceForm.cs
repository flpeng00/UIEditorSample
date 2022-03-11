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
    public partial class ResourceForm : Form
    {

        List<CanvasInfo> canvasInfos;

        public ResourceForm()
        {
            InitializeComponent();
            canvasInfos = new List<CanvasInfo>();
        }

        public void AddCanvasInfo(CanvasInfo canvasInfo)
        {
            canvasInfos.Add(canvasInfo);

            treeView_canvasResource.BeginUpdate();
            treeView_canvasResource.Nodes.Clear();
            foreach( CanvasInfo info in canvasInfos)
            {
                TreeNode node = new TreeNode();
                node.Text = info.path;
                node.Tag = info;
                treeView_canvasResource.Nodes.Add(node);
            }
            treeView_canvasResource.ExpandAll();
            treeView_canvasResource.EndUpdate();

            Image image = Image.FromFile(canvasInfo.path);
            Entry.Canvas canvas = new Entry.Canvas();
            canvas.SetImage(image);
            canvas.SetName(Path.GetFileNameWithoutExtension(canvasInfo.path));

            WorkSpace.Instance().AddEntry(canvas);
        }
    }
}
