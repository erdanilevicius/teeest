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
    internal class Actions
    {
        public string[] Action(string tokenas, string SRVID)
        {

            string headeris = "Authorization: Bearer " + tokenas;
            string rezultatas;

            WebRequest request = WebRequest.Create("https://api.cherryservers.com/v1/servers/"+SRVID+"/actions");
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
                JObject ats = JObject.Parse("{\"ACT\":" + serv + "}");
                List<string> strings = new List<string>();
                foreach (var atss in ats["ACT"])
                {
                    Act myDeserializedClass = JsonConvert.DeserializeObject<Act>(atss.ToString());
                    strings.Add(myDeserializedClass.type.ToString());
;

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



    //public class OsPartitionSize
    //{
    //    public bool supported { get; set; }
    //    public int minimum { get; set; }
    //    public int maximum { get; set; }
    //    public int current { get; set; }
    //    public string unit { get; set; }
    //}

    public class Act
    {
        public string type { get; set; }
      //  public bool disabled { get; set; }
      // public OsPartitionSize os_partition_size { get; set; }
    }



}
