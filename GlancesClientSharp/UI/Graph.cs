using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlancesClientSharp.UI
{
    public partial class Graph : UserControl
    {
        public DataEntryCollection DataEntries { get; private set; }
        public bool DynamicMaximum { get; set; }
        public bool Invert { get; set; }
        public float Maximum { get; set; }
        public float Minimum { get; set; }

        public Graph()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(69, 77, 74);

            Maximum = 100f;
            Minimum = 0;
            DynamicMaximum = true;

            DataEntries = new UI.DataEntryCollection();
            DataEntries.EntryAdded += (o, e) => {
                this.Invalidate();
                e.Element.Data.ValueAdded += ValueAdded;
            };
            DataEntries.EntryRemoved += (o, e) => {
                this.Invalidate();
                e.Element.Data.ValueAdded -= ValueAdded;
            };
        }

        private void ValueAdded(object sender, EventArgs args)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DataEntries.Count == 0)
                return;

            if (!DataEntries.All(x => x.Data.Capacity == DataEntries[0].Data.Capacity))
                return;

            var max = Maximum;
            if (DynamicMaximum)
            {
                max = float.MinValue;
                for(int w = 0; w < DataEntries[0].Data.Capacity; w++)
                {
                    var sum = DataEntries.Sum(x => x.Data[w]);
                    if (sum > max)
                        max = sum;
                }
                if (max < Minimum)
                    max = Minimum;
            }

            var brushes = new SolidBrush[DataEntries.Count];
            for (int i = 0; i < DataEntries.Count; i++)
                brushes[i] = new SolidBrush(DataEntries[i].Color);

            float width = (float)Width / (float)DataEntries[0].Data.Capacity;
            for (int w = 0; w < DataEntries[0].Data.Capacity; w++)
            {
                float y_raw = 0;
                for(int i = 0; i < DataEntries.Count; i++)
                {
                    var height = DataEntries[i].Data[w];
                    var y = y_raw;
                    var display_y = Invert ? ((float)Height / (float)max * y) : (float)Height - ((float)Height / (float)max * (y + height));
                    var display_height = ((float)Height / (float)max * height);
                    y_raw += height;

                    var x = w * width;
                    e.Graphics.FillRectangle(brushes[i], x, display_y, width, display_height);
                }
            }
            for (int i = 0; i < DataEntries.Count; i++)
                brushes[i].Dispose();
        }
    }
}
