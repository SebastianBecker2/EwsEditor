using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Exchange.WebServices.Data;
using EWSEditor.Common;
using Newtonsoft.Json;
using System.Net;

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
            this.Clear();

            string json_part = "";
            var brace_counter = 0;
            foreach (var ch in json)
            {
                if (ch == '{')
                {
                    brace_counter++;
                }

                if (brace_counter >= 1)
                {
                    json_part += ch;
                }

                if (ch == '}')
                {
                    brace_counter--;
                }

                if ((brace_counter == 0) && (!string.IsNullOrWhiteSpace(json_part)))
                {
                    var service = JsonConvert.DeserializeObject<StoredService>(json_part, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                        NullValueHandling = NullValueHandling.Ignore,
                    });

                    var web_cred = service.Service.Credentials as WebCredentials;
                    var net_cred = web_cred.Credentials as NetworkCredential;
                    service.Service.Credentials = new NetworkCredential(net_cred.UserName, net_cred.Password, net_cred.Domain);

                    this.Add(service);

                    json_part = "";
                }
            }
        }
    }
}
