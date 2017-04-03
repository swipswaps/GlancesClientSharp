using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances.Plugins
{
    [GlancesPluginAttribute("core")]
    public class Core
    {
        /*phys": 4,
         "log": 4*/

        [JsonProperty(PropertyName = "phys")]
        public int Physical { get; set; }
        [JsonProperty(PropertyName = "log")]
        public int Logical { get; set; }
    }
}
