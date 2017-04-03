using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlancesClientSharp.UI.Timing
{
    public class Loop
    {
        private int tickRate, timePerTick;
        private TickCounter cntrDraw, cntrLogic;
        private Thread thread;
        private bool working;

        public int TickRate
        {
            get { return tickRate; }
            set
            {
                if (tickRate != value)
                {
                    tickRate = Math.Max(1, value);
                    timePerTick = (int)System.Math.Floor(1000.0 / tickRate);
                }
            }
        }
        public int TimePerTick
        {
            get { return timePerTick; }
            set
            {
                if (timePerTick != value)
                {
                    timePerTick = Math.Max(1, value);
                    tickRate = (int)System.Math.Floor(1000.0 / timePerTick);
                }
            }
        }
        public bool LimitFrames { get; set; }
        public double DrawTPS { get { return cntrDraw.TPS; } }
        public double LogicTPS { get { return cntrLogic.TPS; } }

        public EventHandler<TickEventArgs> LogicTick { get; set; }
        public EventHandler<TickEventArgs> DrawTick { get; set; }
        public EventHandler<EventArgs> BeforeRun { get; set; }
        public EventHandler<EventArgs> AfterRun { get; set; }

        public Loop()
        {
            cntrDraw = new TickCounter();
            cntrLogic = new TickCounter();
            LimitFrames = true;
            TickRate = 60;
        }

        public void RunAsync()
        {
            if (thread == null)
            {
                thread = new Thread(() => Run());
                thread.IsBackground = true;
                thread.Start();
            }
        }

        public void Stop()
        {
            if (thread != null)
            {
                working = false;
                thread.Join();
                thread = null;
            }
        }

        private void Run()
        {
            BeforeRun?.Invoke(this, new EventArgs());
            int lastTick = Environment.TickCount;
            int firstTick = lastTick;
            int currentTick = 0;
            working = true;

            while (working)
            {
                currentTick = Environment.TickCount;
                cntrLogic.Tick();
                TickEventArgs args = new TickEventArgs(new Time(TimeSpan.FromMilliseconds(Environment.TickCount - firstTick), TimeSpan.FromMilliseconds(currentTick - lastTick)), cntrLogic);
                LogicTick?.Invoke(this, args);
                DrawTick?.Invoke(this, args);

                if (args.Stop)
                    break;
                
                lastTick = Environment.TickCount;

                if (this.LimitFrames)
                {
                    long passed = lastTick - currentTick + 1;
                    if (passed <= timePerTick)
                        Thread.Sleep((int)(timePerTick - passed));
                }
            }
            AfterRun?.Invoke(this, new EventArgs());
        }
    }
}
