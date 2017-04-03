using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("mem")]
    public class Memory
    {
        /*available": 5495345152,
        "used": 2714947584,
        "cached": 5061455872,
        "percent": 33.1,
        "free": 5495345152,
        "inactive": 4673040384,
        "active": 3033247744,
        "total": 8210292736,
        "buffers": 162193408*/
        [JsonProperty(PropertyName = "available")]
        public long Available { get; set; }
        [JsonProperty(PropertyName = "used")]
        public long Used { get; set; }
        [JsonProperty(PropertyName = "cached")]
        public long Cached { get; set; }
        [JsonProperty(PropertyName = "percent")]
        public float Percent { get; set; }
        [JsonProperty(PropertyName = "free")]
        public long Free { get; set; }
        [JsonProperty(PropertyName = "inactive")]
        public long Inactive { get; set; }
        [JsonProperty(PropertyName = "active")]
        public long Active { get; set; }
        [JsonProperty(PropertyName = "total")]
        public long Total { get; set; }
        [JsonProperty(PropertyName = "buffers")]
        public long Buffers { get; set; }
    }
}
