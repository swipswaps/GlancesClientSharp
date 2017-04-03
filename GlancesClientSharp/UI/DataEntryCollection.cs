using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.UI
{
    public class DataEntryCollection : IList<DataEntry>
    {
        private List<DataEntry> entries;

        public EventHandler<GenericEventArgs<DataEntry>> EntryAdded { get; set; }
        public EventHandler<GenericEventArgs<DataEntry>> EntryRemoved { get; set; }

        public int Count { get  { return entries.Count; } }

        public bool IsReadOnly { get { return false; } }

        public DataEntry this[int index]
        {
            get { return entries[index]; }
            set { entries[index] = value; }
        }

        public DataEntryCollection()
        {
            entries = new List<DataEntry>();
        }

        public int IndexOf(DataEntry item)
        {
            return entries.IndexOf(item);
        }

        public void Insert(int index, DataEntry item)
        {
            entries.Insert(index, item);
            EntryAdded?.Invoke(this, new UI.GenericEventArgs<UI.DataEntry>(item));
        }

        public void RemoveAt(int index)
        {
            var item = entries[index];
            entries.RemoveAt(index);
            EntryRemoved?.Invoke(this, new UI.GenericEventArgs<UI.DataEntry>(item));
        }

        public void Add(DataEntry item)
        {
            entries.Add(item);
            EntryAdded?.Invoke(this, new UI.GenericEventArgs<UI.DataEntry>(item));
        }

        public void Clear()
        {
            var items = entries.ToArray();
            entries.Clear();
            foreach(var item in items)
                EntryRemoved?.Invoke(this, new UI.GenericEventArgs<UI.DataEntry>(item));
        }

        public bool Contains(DataEntry item)
        {
            return entries.Contains(item);
        }

        public void CopyTo(DataEntry[] array, int arrayIndex)
        {
            entries.CopyTo(array, arrayIndex);
        }

        public bool Remove(DataEntry item)
        {
            if (entries.Remove(item))
            {
                EntryRemoved?.Invoke(this, new UI.GenericEventArgs<UI.DataEntry>(item));
                return true;
            }
            return false;
        }

        public IEnumerator<DataEntry> GetEnumerator()
        {
            return entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entries.GetEnumerator();
        }
    }
}
