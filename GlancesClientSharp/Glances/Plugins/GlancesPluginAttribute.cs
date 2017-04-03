using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    public class GlancesPluginAttribute : Attribute
    {
        public string PluginName { get; private set; }
        public bool ReturnsArray { get; private set; }

        public GlancesPluginAttribute(string name, bool retArray)
        {
            PluginName = name;
            ReturnsArray = retArray;
        }
        public GlancesPluginAttribute(string name) : this (name, false) { }
    }
}
