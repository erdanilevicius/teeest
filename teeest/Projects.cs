using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace teeest
{
    internal class Projects
    {
        public string[] Projekt(string tokenas, string Teamidas)
        {

            string headeris = "Authorization: Bearer " + tokenas;
            string rezultatas;

            WebRequest request = WebRequest.Create("https://api.cherryservers.com/v1/teams/"+Teamidas+ "/projects");
            request.Method = "GET";

            request.Headers.Add(headeris);
            request.ContentType = "application/json";

            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();

                using JsonDocument document = JsonDocument.Parse(responseFromServer);
                using var stream = new MemoryStream();
                using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions() { Indented = true });
                document.WriteTo(writer);
                writer.Flush();
                string komanda = responseFromServer.ToString();
                JObject ats = JObject.Parse("{\"PROJE\":"+ komanda + "}");
                List<string> strings = new List<string>();
                foreach (var atss in ats["PROJE"]) {
                    Proje myDeserializedClass = JsonConvert.DeserializeObject<Proje>(atss.ToString());
                    strings.Add(myDeserializedClass.id.ToString());
                    strings.Add(myDeserializedClass.name.ToString());
                
                }
                string[] testas = strings.ToArray();
                //string json = JsonConvert.DeserializeObject(responseFromServer).ToString();
                //var rezarr = json.Split(',');
                //rezultatas = String.Join(",", rezarr);
                return testas;
            }
            response.Close();
        }
    }
    //public class Bgp
    //{
    //    public bool enabled { get; set; }
    //    public int local_asn { get; set; }
    //}

    public class Proje
    {
        public int id { get; set; }
        public string name { get; set; }
        //public Bgp bgp { get; set; }
        //public string href { get; set; }
    }

}
