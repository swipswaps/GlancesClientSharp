using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.UI
{
    public class DataEntry
    {
        public RingBuffer Data { get; private set; }
        public string Name { get; private set; }
        public Color Color { get; private set; }

        public DataEntry(string name, Color color, RingBuffer data)
        {
            Name = Name;
            Color = color;
            Data = data;
        }
        public DataEntry(string name, Color color, int capacity) : this (name, color, new RingBuffer(capacity)) { }
    }
}
