using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("memswap")]
    public class MemSwap
    {
        [JsonProperty(PropertyName = "used")]
        public long Used { get; set; }
        [JsonProperty(PropertyName = "free")]
        public long Free { get; set; }
        [JsonProperty(PropertyName = "percent")]
        public float Percent { get; set; }
        [JsonProperty(PropertyName = "total")]
        public long Total { get; set; }
        [JsonProperty(PropertyName = "sout")]
        public long SOut { get; set; }
        [JsonProperty(PropertyName = "sin")]
        public long SIn { get; set; }
    }
}
