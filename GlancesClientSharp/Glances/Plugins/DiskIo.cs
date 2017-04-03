using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("diskio", true)]
    public class DiskIo
    {
        [JsonProperty(PropertyName = "read_count")]
        public long ReadCount { get; set; }
        [JsonProperty(PropertyName = "write_bytes")]
        public long WriteBytes { get; set; }
        [JsonProperty(PropertyName = "write_count")]
        public long WriteCount { get; set; }
        [JsonProperty(PropertyName = "time_since_update")]
        public float TimeSinceUpdate { get; set; }
        [JsonProperty(PropertyName = "read_bytes")]
        public long ReadBytes { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "disk_name")]
        public string DiskName { get; set; }
    }
}
