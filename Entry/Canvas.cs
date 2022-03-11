using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
            int selected = WorkSpace.Instance().selectedID;
            bool bTransparent = false;
            if (selected >= 0 && selected != this.id)
                bTransparent = true;

            if (visible && image != null)
            {
                if (bTransparent)
                {
                    var colorMatrix = new ColorMatrix();
                    colorMatrix.Matrix33 = 0.3f;
                    var imageAttributes = new ImageAttributes();
                    imageAttributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(this.image, this.range, 0, 0, this.range.Width, this.range.Height, GraphicsUnit.Pixel, imageAttributes);
                }
                else
                {
                    g.DrawImage(this.image, this.range);
                }
            }
        }

        public override bool AddChild(Entry entry)
        {
            return false;
        }
    }
}
