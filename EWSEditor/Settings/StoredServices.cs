using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Exchange.WebServices.Data;
using EWSEditor.Common;
using Newtonsoft.Json;

namespace EWSEditor.Settings
{
    public class StoredService
    {
        public string Name { get; set; }
        public ExchangeService Service { get; set; }
        public EwsEditorAppSettings AppSettings { get; set; }
    }

    public class StoredServices : List<StoredService>
    {
        public string Serialize()
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.TypeNameHandling = TypeNameHandling.Auto;
            settings.Formatting = Formatting.Indented;

            return JsonConvert.SerializeObject(this, settings);
        }

        public void Deserialize(string json)
        {
            var services = JsonConvert.DeserializeObject<StoredServices>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore,
            });
            this.Clear();
            this.AddRange(services);
        }
    }
}
