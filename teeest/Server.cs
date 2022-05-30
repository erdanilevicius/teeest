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
    internal class Server
    {
        public string Servas(string tokenas, string SRVID)
        {

            string headeris = "Authorization: Bearer " + tokenas;
            string rezultatas;

            WebRequest request = WebRequest.Create("https://api.cherryservers.com/v1/servers/"+SRVID);
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
                string serv = responseFromServer.ToString();
                //JObject ats = JObject.Parse("{\"SERVAI\":" + serv + "}");
                //List<string> strings = new List<string>();
                //foreach (var atss in ats["SERVAI"])
                //{
                //    Servai myDeserializedClass = JsonConvert.DeserializeObject<Servai>(atss.ToString());
                //    strings.Add(myDeserializedClass.id.ToString());
                //    // strings.Add(myDeserializedClass.name.ToString());
                //    strings.Add(myDeserializedClass.hostname.ToString());

                //}
                //string[] testas = strings.ToArray();
                string json = JsonConvert.DeserializeObject(responseFromServer).ToString();
                var rezarr = json.Split(',');
                rezultatas = String.Join(",", rezarr);
                return rezultatas;
            }
            response.Close();
        }







    }
}
