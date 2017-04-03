using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("batpercent", true)]
    public class BatPercent
    {
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        [JsonProperty(PropertyName = "value")]
        public float[] Value { get; set; }
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}
