using GlancesClientSharp.Glances.Plugins;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlancesClientSharp.Glances
{
    public class GlancesServer
    {
        private RestClient client;

        public string Address { get; private set; }

        public GlancesServer(string address)
        {
            Address = address;
            client = new RestClient(Address);
        }

        private GlancesPluginAttribute GetTypeAttribute<T>()
        {
            var type = typeof(T);
            var attrs = type.GetCustomAttributes(true);
            if (!attrs.Any(x => x is GlancesPluginAttribute))
                return null;
            return (GlancesPluginAttribute)attrs.First(x => x is GlancesPluginAttribute);
        }

        public object PerformQuery<T>() where T : new()
        {
            var attr = GetTypeAttribute<T>();
            if (attr == null)
                throw new Exception("Type does not provide any GlancesPluginAttribute");

            var request = new RestRequest("api/2/" + attr.PluginName, Method.GET);
            if (attr.ReturnsArray)
            {
                var resp = client.Execute<List<T>>(request);
                return resp.Data.ToArray();
            } else
            {
                var resp = client.Execute<T>(request);
                return resp.Data;
            }
        }
    }
}
