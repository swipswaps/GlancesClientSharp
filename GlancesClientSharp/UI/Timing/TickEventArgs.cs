using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlancesClientSharp.UI.Timing
{
    public class TickEventArgs : EventArgs
    {
        public bool Stop { get; set; }
        public Time Time { get; private set; }
        public TickCounter Counter { get; private set; }

        public TickEventArgs(Time time, TickCounter tps)
        {
            Time = time;
            Counter = tps;
            Stop = false;
        }
    }
}
