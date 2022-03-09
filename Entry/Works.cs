using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIEditorSample.Entry
{
    public class Works : Entry
    {
        public Works()
        {
            SetDefaultName();
        }

        public override bool AddChild(Entry entry)
        {
            childEntries.Add(entry);
            return true;
        }

        public override void Paint(Graphics g)
        {
            foreach( Entry entry in childEntries)
            {
                entry.Paint(g);
            }
        }
    }
}
