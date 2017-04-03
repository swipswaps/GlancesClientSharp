using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.UI
{
    public class RingBuffer
    {
        private float[] Data;
        private int Index;

        public int Capacity
        {
            get { return Data.Length; }
            set
            {
                if (value != Data.Length)
                {
                    var newData = new float[value];
                    Array.Copy(Data, newData, Math.Min(value, Data.Length));
                    Data = newData;
                    CapacityChanged?.Invoke(this, new EventArgs());
                }
            }
        }
        public EventHandler CapacityChanged { get; set; }
        public EventHandler ValueAdded { get; set; }


        public RingBuffer(int capacity)
        {
            Data = new float[capacity];
        }

        public float this[int index]
        {
            get { return Data[(Index + index) % Data.Length]; }
        }

        public void Add(float value)
        {
            Data[(Index++) % Data.Length] = value;
            Index %= Data.Length;
            ValueAdded?.Invoke(this, new EventArgs());
        }
    }
}
