using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("percpu", true)]
    public class PerCpu
    {
        [JsonProperty(PropertyName = "cpu_number")]
        public int CpuNumber { get; set; }
        [JsonProperty(PropertyName = "guest_nice")]
        public float GuestNice { get; set; }
        [JsonProperty(PropertyName = "softirq")]
        public float SoftIrq { get; set; }
        [JsonProperty(PropertyName = "iowait")]
        public float IoWait { get; set; }
        [JsonProperty(PropertyName = "system")]
        public float System { get; set; }
        [JsonProperty(PropertyName = "guest")]
        public float Guest { get; set; }
        [JsonProperty(PropertyName = "idle")]
        public float Idle { get; set; }
        [JsonProperty(PropertyName = "user")]
        public float User { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "irq")]
        public float Irq { get; set; }
        [JsonProperty(PropertyName = "total")]
        public float Total { get; set; }
        [JsonProperty(PropertyName = "steal")]
        public float Steal { get; set; }
        [JsonProperty(PropertyName = "nice")]
        public float Nice { get; set; }
    }
}
