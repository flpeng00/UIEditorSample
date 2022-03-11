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
        public Entry.Works works;
        public SortedDictionary<int, Entry.Entry> entries;
        public int selectedID = -1;

        private static WorkSpace instance;
        public static WorkSpace Instance()
        {
            if (instance == null)
                instance = new WorkSpace();
            return instance;
        }

        private WorkSpace()
        {
            entries = new SortedDictionary<int, Entry.Entry>();
            works = new Entry.Works();
            entries.Add(works.id, works);
        }

        public void AddEntry(Entry.Entry entry)
        {
            works.AddChild(entry);
            entries.Add(entry.id, entry);
            mainForm.OnEntryChanged();
        }

        public Entry.Entry? GetSelectedEntry()
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
            if (selectedID == id)
                return;
            selectedID = id;
            foreach (var pair in this.entries)
            {
                Entry.Entry entry = pair.Value;
                entry.selected = entry.id == id;
            }
            mainForm.OnEntrySelected();
        }

        public void OnEntryChanged()
        {
            mainForm.OnEntryChanged();
        }
    }
}
