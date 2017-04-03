using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("system")]
    public class System
    {
        [JsonProperty(PropertyName = "os_name")]
        public string OsName { get; set; }
        [JsonProperty(PropertyName = "os_version")]
        public string OsVersion { get; set; }
        [JsonProperty(PropertyName = "linux_distro")]
        public string LinuxDistro { get; set; }
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }
        [JsonProperty(PropertyName = "hr_name")]
        public string HumanReadableName { get; set; }
    }
}
