using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIEditorSample
{
    public class WorkSpace
    {
        public MainForm mainForm;
        public PreviewForm previewForm;
        public Entry.Works works;
        public SortedDictionary<int, Entry.Entry> entries;
        public int selectedID = -1;

        public WorkSpace(MainForm mainForm, PreviewForm previewForm)
        {
            this.mainForm = mainForm;
            this.previewForm = previewForm;
            entries = new SortedDictionary<int, Entry.Entry>();
            works = new Entry.Works();
            entries.Add(works.id, works);
        }

        public void Init()
        {
        }

        public void AddEntry(Entry.Entry entry)
        {
            works.AddChild(entry);
            entries.Add(entry.id, entry);
            mainForm.OnEntryChanged();
        }

        public Entry.Entry GetSelectedEntry()
        {
            if (selectedID == -1)
                return null;
            if (!entries.ContainsKey(selectedID))
                return null;
            return entries[selectedID];
        }

        public List<Entry.Entry> GetEntryWithPoint(Point point)
        {
            List<Entry.Entry> entries = new List<Entry.Entry>();
            foreach ( var pair in this.entries)
            {
                Entry.Entry entry = pair.Value;
                if (entry.IsInRange(point))
                    entries.Add(entry);
            }

            return entries;
        }

        public void SetSelecteEntry(in int id)
        {
            selectedID = id;
            if (selectedID >= 0)
                GetSelectedEntry().selected = true;
            mainForm.OnEntrySelected();
        }
    }
}
