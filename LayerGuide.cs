using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIEditorSample
{
    internal class LayerGuide
    {
        public Rectangle rc { get; set; }
        public Color color;
        
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawRectangle(pen, rc);
        }
    }
}
