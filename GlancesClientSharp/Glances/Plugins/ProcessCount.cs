using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("processcount")]
    public class ProcessCount
    {
        [JsonProperty(PropertyName = "running")]
        public int Running { get; set; }
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
        [JsonProperty(PropertyName = "pid_max")]
        public int PidMax { get; set; }
        [JsonProperty(PropertyName = "thread")]
        public int Thread { get; set; }
        [JsonProperty(PropertyName = "sleeping")]
        public int Sleeping { get; set; }
    }
}
