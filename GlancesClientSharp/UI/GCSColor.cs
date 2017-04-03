using SharpDX.Mathematics.Interop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlancesClientSharp.UI
{
    public class GCSColor
    {
        public RawColor4 SharpDxColor { get; private set; }
        public Color DotNetColor { get; private set; }

        public GCSColor(RawColor4 color)
        {
            SharpDxColor = color;
            DotNetColor = Color.FromArgb(
                (int)(255f * color.A),
                (int)(255f * color.R),
                (int)(255f * color.G),
                (int)(255f * color.B));
        }
        public GCSColor(Color color)
        {
            DotNetColor = color;
            SharpDxColor = new RawColor4(
                color.R / 255f,
                color.G / 255f,
                color.B / 255f,
                color.A / 255f
            );
        }

        public static implicit operator RawColor4(GCSColor col)
        {
            return col.SharpDxColor;
        }
        public static implicit operator Color(GCSColor col)
        {
            return col.DotNetColor;
        }
    }
}
