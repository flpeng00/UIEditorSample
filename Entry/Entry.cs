using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace UIEditorSample.Entry
{
    public abstract class Entry
    {
        public enum Type
        {
            None,
            Works,
            Canvas,
            Layer,
            Position,
        }
        static private int lastEntryID = 0;

        [Browsable(false)] 
        public int id { get; private set; } = 0;
        protected string name { get; set; } = string.Empty;
        protected Type type { get; set; } = Type.None;
        public Rectangle range { get; set; } = Rectangle.Empty;

        public bool visible { 
            get; set; 
        } = true;

        public List<Entry> childEntries = new List<Entry>();
        public bool selected { get; set; } = false;

        public abstract void Paint(Graphics g);
        public abstract bool AddChild(Entry entry);
        public virtual bool IsInRange(Point point)
        {
            return range.Contains(point);
        }

        protected Entry()
        {
            lastEntryID++;
            id = lastEntryID;
            SetDefaultName();
        }

        public void Move(Point point)
        {
            Rectangle rc = range;
            rc.Location = point;
            range = rc;
        }

        public Point GetLocation()
        {
            return range.Location;
        }

        public string TypeToString(in Type type)
        {
            switch (type)
            {
                case Type.None:
                    return "None";
                case Type.Works:
                    return "Works";
                case Type.Canvas:
                    return "Canvas";
                case Type.Layer:
                    return "Layer";
                case Type.Position:
                    return "Position";
                default:
                    return type.ToString();

            }
        }

        public virtual TreeNode MakeTreeNode()
        {
            TreeNode node = new TreeNode();
            node.Tag = this;
            node.Text = this.name;

            foreach (Entry childEntry in this.childEntries)
            {
                TreeNode childNode = childEntry.MakeTreeNode();
                node.Nodes.Add(childNode);
            }

            return node;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public virtual void SetDefaultName()
        {
            name = this.GetType().Name + id.ToString();
        }
    }
}
