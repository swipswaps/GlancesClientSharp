using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("ip")]
    public class Ip
    {
        [JsonProperty(PropertyName = "public_address")]
        public string PublicAddress { get; set; }
        [JsonProperty(PropertyName = "mask")]
        public string Mask { get; set; }
        [JsonProperty(PropertyName = "mask_cidr")]
        public string MaskCidr { get; set; }
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
    }
}
