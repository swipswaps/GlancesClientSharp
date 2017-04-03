using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("irq", true)]
    public class Irq
    {
        [JsonProperty(PropertyName = "irq_rate")]
        public long IrqRate { get; set; }
        [JsonProperty(PropertyName = "irq_line")]
        public string IrqLine { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "time_since_update")]
        public float TimeSinceUpdate { get; set; }
    }
}
