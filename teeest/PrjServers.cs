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
    internal class PrjServers
    {
        public string[] PrServers(string tokenas, string PrjID)
        {

            string headeris = "Authorization: Bearer " + tokenas;
            string rezultatas;

            WebRequest request = WebRequest.Create("https://api.cherryservers.com/v1/projects/"+PrjID+"/servers");
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
                JObject ats = JObject.Parse("{\"SERVAI\":" + serv + "}");
                List<string> strings = new List<string>();
                foreach (var atss in ats["SERVAI"])
                {
                    Servai myDeserializedClass = JsonConvert.DeserializeObject<Servai>(atss.ToString());
                    strings.Add(myDeserializedClass.id.ToString());
                   // strings.Add(myDeserializedClass.name.ToString());
                    strings.Add(myDeserializedClass.hostname.ToString());

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



    public class Servai
    {
        public int id { get; set; }
        public string name { get; set; }
    //    public string href { get; set; }
        public string hostname { get; set; }
    //    public string image { get; set; }
    //    public bool spot_instance { get; set; }
    //    public Region region { get; set; }
    //    public string state { get; set; }
    //    public Bgp bgp { get; set; }
    //    public Software software { get; set; }
    //    public Plan plan { get; set; }
    //    public Pricing pricing { get; set; }
    //    public List<IpAddress> ip_addresses { get; set; }
    //    public List<SshKey> ssh_keys { get; set; }
    //    public int vlan { get; set; }
    //    public Tags tags { get; set; }
    //    public string termination_date { get; set; }
    //    public bool upgradable { get; set; }
    //    public DateTime created_at { get; set; }
    //    public Project project { get; set; }
        }

    //public class AssignedTo
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string href { get; set; }
    //    public string hostname { get; set; }
    //    public bool spot_instance { get; set; }
    //    public Region region { get; set; }
    //    public string state { get; set; }
    //    public Software software { get; set; }
    //    public Tags tags { get; set; }
    //    public string termination_date { get; set; }
    //    public bool upgradable { get; set; }
    //    public DateTime created_at { get; set; }
    //    public Project project { get; set; }
    //}

    //public class AvailableRegion
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string region_iso_2 { get; set; }
    //    public int stock_qty { get; set; }
    //    public int spot_qty { get; set; }
    //    public string href { get; set; }
    //    public Bgp bgp { get; set; }
    //    public string location { get; set; }
    //}

    //public class Bandwidth
    //{
    //    public string name { get; set; }
    //}

    //public class Bgp
    //{
    //    public List<string> hosts { get; set; }
    //    public int asn { get; set; }
    //    public bool enabled { get; set; }
    //    public int local_asn { get; set; }
    //    public bool available { get; set; }
    //    public string status { get; set; }
    //    public int routers { get; set; }
    //    public int connected { get; set; }
    //    public int limit { get; set; }
    //    public int active { get; set; }
    //    public List<object> routes { get; set; }
    //    public DateTime updated { get; set; }
    //}

    //public class Cpus
    //{
    //    public int count { get; set; }
    //    public string name { get; set; }
    //    public int cores { get; set; }
    //    public double frequency { get; set; }
    //    public string unit { get; set; }
    //}

    //public class IpAddress
    //{
    //    public string id { get; set; }
    //    public string address { get; set; }
    //    public int address_family { get; set; }
    //    public string cidr { get; set; }
    //    public string gateway { get; set; }
    //    public string type { get; set; }
    //    public Region region { get; set; }
    //    public AssignedTo assigned_to { get; set; }
    //    public string ptr_record { get; set; }
    //    public string a_record { get; set; }
    //    public bool ddos_scrubbing { get; set; }
    //    public Tags tags { get; set; }
    //    public Project project { get; set; }
    //    public TargetedTo targeted_to { get; set; }
    //    public string href { get; set; }
    //    public int? vlan_id { get; set; }
    //}

    //public class Memory
    //{
    //    public int count { get; set; }
    //    public int total { get; set; }
    //    public string unit { get; set; }
    //    public string name { get; set; }
    //}

    //public class Nics
    //{
    //    public string name { get; set; }
    //}

    //public class Plan
    //{
    //    public int id { get; set; }
    //    public string href { get; set; }
    //    public string name { get; set; }
    //    public string title { get; set; }
    //    public bool custom { get; set; }
    //    public string category { get; set; }
    //    public Specs specs { get; set; }
    //    public List<AvailableRegion> available_regions { get; set; }
    //}

    //public class Pricing
    //{
    //    public int id { get; set; }
    //    public string currency { get; set; }
    //    public string unit { get; set; }
    //    public double unit_price { get; set; }
    //    public double discount { get; set; }
    //    public bool discount_percentage { get; set; }
    //    public double price_subtotal { get; set; }
    //    public bool taxed { get; set; }
    //    public double price_total { get; set; }
    //    public double price { get; set; }
    //    public int quantity { get; set; }
    //    public double billable_amount { get; set; }
    //}

    //public class Project
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public Bgp bgp { get; set; }
    //    public string href { get; set; }
    //}

    //public class Region
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string region_iso_2 { get; set; }
    //    public string href { get; set; }
    //    public Bgp bgp { get; set; }
    //    public string location { get; set; }
    //}

    //public class Software
    //{
    //    public List<object> addons { get; set; }
    //}

    //public class Specs
    //{
    //    public Cpus cpus { get; set; }
    //    public Memory memory { get; set; }
    //    public List<Storage> storage { get; set; }
    //    public Nics nics { get; set; }
    //    public Bandwidth bandwidth { get; set; }
    //}

    //public class SshKey
    //{
    //    public int id { get; set; }
    //    public string href { get; set; }
    //}

    //public class Storage
    //{
    //    public int count { get; set; }
    //    public string name { get; set; }
    //    public int size { get; set; }
    //    public string unit { get; set; }
    //    public string type { get; set; }
    //}

    //public class Tags
    //{
    //}

    //public class TargetedTo
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string href { get; set; }
    //    public string hostname { get; set; }
    //    public bool spot_instance { get; set; }
    //    public Region region { get; set; }
    //    public string state { get; set; }
    //    public Software software { get; set; }
    //    public Tags tags { get; set; }
    //    public DateTime termination_date { get; set; }
    //    public bool upgradable { get; set; }
    //    public DateTime created_at { get; set; }
    //    public Project project { get; set; }
    //}

}
