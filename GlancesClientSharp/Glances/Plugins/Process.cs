using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("processlist", true)]
    public class Process
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = "cpu_times")]
        public float[] CpuTimes { get; set; }
        [JsonProperty(PropertyName = "pid")]
        public int Pid { get; set; }
        [JsonProperty(PropertyName = "io_counters")]
        public float[] IoCounter { get; set; }
        [JsonProperty(PropertyName = "cmdline")]
        public string[] CommandLine { get; set; }
        [JsonProperty(PropertyName = "memory_info")]
        public long[] MemoryInfo { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "mandatory_stats")]
        public bool MandatoryStats { get; set; }
        [JsonProperty(PropertyName = "memory_percent")]
        public float MemoryPercent { get; set; }
        [JsonProperty(PropertyName = "ppid")]
        public int Ppid { get; set; }
        [JsonProperty(PropertyName = "time_since_update")]
        public float TimeSinceUpdate { get; set; }
        [JsonProperty(PropertyName = "nice")]
        public int Nice { get; set; }
    }
}
