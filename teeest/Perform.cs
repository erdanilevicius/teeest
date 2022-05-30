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
using Flurl.Http;
using RestSharp;

namespace teeest
{
    internal class Perform
    {
        
        public string Perf(string tokenas, string SRVID, string SAct)
        {

            string quotes = "\"" + SAct + "\"";
            string rezultatas;

            var request = (HttpWebRequest)WebRequest.Create("https://api.cherryservers.com/v1/servers/" + SRVID + "/actions");
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + tokenas;
            request.ContentType = "application/json";

            var data = @"{""type"" : " +quotes +"}";
            MessageBox.Show(data);

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(data);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                rezultatas = result;
            }

            return rezultatas;

        }
    }
}
