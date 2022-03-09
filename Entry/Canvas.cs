using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIEditorSample.Entry
{
    public class Canvas : Entry
    {
        Image image;

        public Canvas()
        {
            this.range = Rectangle.FromLTRB(10, 10, 20, 20);
        }

        public void SetImage(Image image)
        {
            this.image = image;
            this.range = new Rectangle(0, 0, image.Width, image.Height);
        }

        public override void Paint(Graphics g)
        {
            if (image != null)
                g.DrawImage(this.image, this.range);
        }

        public override bool AddChild(Entry entry)
        {
            return false;
        }
    }
}
