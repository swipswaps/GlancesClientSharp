using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("load")]
    public class Load
    {
        [JsonProperty(PropertyName = "cpucore")]
        public int CpuCore { get; set; }
        [JsonProperty(PropertyName = "min1")]
        public int Min1 { get; set; }
        [JsonProperty(PropertyName = "min5")]
        public int Min5 { get; set; }
        [JsonProperty(PropertyName = "min15")]
        public int Min15 { get; set; }
    }
}
