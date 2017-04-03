using GlancesClientSharp.UI.Timing;
using SharpDX.DXGI;
using SharpDX;
using SharpDX.Windows;
using SharpDX.Direct2D1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.UI
{
    public class frmWindow
    {

        protected Loop Loop { get; private set; }
        public RenderForm Form { get; private set; }
        protected WindowRenderTarget RenderTarget { get; private set; }
        public GCSColor BackColor { get; set; }

        private SharpDX.Direct2D1.Factory fact = new SharpDX.Direct2D1.Factory(SharpDX.Direct2D1.FactoryType.SingleThreaded);
        private SolidColorBrush scenebrush;
        private RenderTargetProperties rndTargProperties;
        private HwndRenderTargetProperties hwndProperties;

        public frmWindow()
        {
            BackColor = new GCSColor(System.Drawing.Color.Blue);

            Loop = new Loop();

            Form = new RenderForm();
            Form.Text = "GlancesClientSharp";
            Form.Width = 800;
            Form.Height = 600;
            Form.ResizeEnd += (o, e) => InitDevice();
            Form.Shown += (_, e) =>
            {
                Loop.LogicTick += (o, te) =>
                {
                    OnLogicTick(te);
                };
                Loop.DrawTick += (o, te) =>
                {
                    if (RenderTarget != null)
                    {
                        RenderTarget.BeginDraw();
                        OnDrawTick(te);
                        RenderTarget.EndDraw();
                    }
                };
                if (RenderTarget == null || RenderTarget.IsDisposed)
                    InitDevice();
            };
            Loop.RunAsync();

            //Form.Show();
        }

        protected virtual void OnLogicTick(TickEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("Ticks: " + args.Counter.TPS);
        }

        protected virtual void OnDrawTick(TickEventArgs args)
        {
            RenderTarget.Clear(BackColor);
            RenderTarget.DrawRectangle(new SharpDX.Mathematics.Interop.RawRectangleF(10, 10, 70, 10 + (float)args.Counter.TPS), scenebrush, 1);
        }

        protected virtual void InitDevice()
        {
            rndTargProperties = new RenderTargetProperties(new PixelFormat(Format.B8G8R8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Premultiplied));

            hwndProperties = new HwndRenderTargetProperties()
            {
                Hwnd = Form.Handle,
                PixelSize = new Size2(Form.ClientSize.Width, Form.ClientSize.Height),
                PresentOptions = PresentOptions.None
            };
            RenderTarget = new WindowRenderTarget(fact, rndTargProperties, hwndProperties);

            scenebrush = new SolidColorBrush(RenderTarget, new GCSColor(System.Drawing.Color.Red));
        }
    }
}
