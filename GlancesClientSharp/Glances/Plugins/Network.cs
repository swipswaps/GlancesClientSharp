using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("network", true)]
    public class Network
    {
        [JsonProperty(PropertyName = "time_since_update")]
        public float TimeSinceUpdate { get; set; }
        [JsonProperty(PropertyName = "is_up")]
        public bool IsUp { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "speed")]
        public long Speed { get; set; }
        [JsonProperty(PropertyName = "interface_name")]
        public string InterfaceName { get; set; }

        [JsonProperty(PropertyName = "cx")]
        public long Cx { get; set; }
        [JsonProperty(PropertyName = "tx")]
        public long Tx { get; set; }
        [JsonProperty(PropertyName = "rx")]
        public long Rx { get; set; }

        [JsonProperty(PropertyName = "cumulative_rx")]
        public long CommulativeRx { get; set; }
        [JsonProperty(PropertyName = "cumulative_tx")]
        public long CommulativeTx { get; set; }
        [JsonProperty(PropertyName = "cumulative_cx")]
        public long CommulativeCx { get; set; }


    }
}
