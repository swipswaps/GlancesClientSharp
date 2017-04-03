using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("fs", true)]
    public class FileSystem
    {
        [JsonProperty(PropertyName = "mnt_point")]
        public string MountPoint { get; set; }
        [JsonProperty(PropertyName = "fs_type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "size")]
        public long Size { get; set; }
        [JsonProperty(PropertyName = "used")]
        public long Used { get; set; }
        [JsonProperty(PropertyName = "percent")]
        public float Percent { get; set; }
        [JsonProperty(PropertyName = "device_name")]
        public string DeviceName { get; set; }
    }
}
