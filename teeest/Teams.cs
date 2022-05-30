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
    internal class Prisijungimas
    {

        public string[] Prisijungti(string tokenas)
        {
        
            string headeris = "Authorization: Bearer " + tokenas;
            string rezultatas;

            WebRequest request = WebRequest.Create("https://api.cherryservers.com/v1/teams");
            request.Method = "GET";

            request.Headers.Add(headeris);
            request.ContentType = "application/json";

            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream()) {

                StreamReader reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();

                using JsonDocument document = JsonDocument.Parse(responseFromServer);
                using var stream = new MemoryStream();
                using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions() { Indented = true });
                document.WriteTo(writer);
                writer.Flush();

                string bandymas = responseFromServer.ToString();
                JObject ats = JObject.Parse("{\"TEAMS\":" + bandymas + "}");
               List<string> strings = new List<string>();
                foreach (var atss in ats["TEAMS"]) {

                    Teams myDeserializedClass = JsonConvert.DeserializeObject<Teams>(atss.ToString());
                    strings.Add(myDeserializedClass.id.ToString());
                    strings.Add(myDeserializedClass.name.ToString());
                }

                string[] testas = strings.ToArray();

                return testas;
                 //Json failo spausdinimas, paskirstymas i eilutes

                 //var rezarr = json.Split(',');
                 //rezultatas = String.Join(",", rezarr);
                 //rezultatas = json.Id.ToString(); 
            }
            response.Close();

        }
    }

    public class Teams
    {
        public int id { get; set; }
        public string name { get; set; }
        //public Credit credit { get; set; }
        //public Billing billing { get; set; }
        //public string href { get; set; }
    }
    ////////////////////////////////////////////// 
    // Testui  nereikalingas info is Json failo //
    //////////////////////////////////////////////



    //public class Account
    //{
    //    public double remaining { get; set; }
    //    public double usage { get; set; }
    //    public string currency { get; set; }
    //}

    //public class Billing
    //{
    //    public string type { get; set; }
    //    public string company_name { get; set; }
    //    public string company_code { get; set; }
    //    public string first_name { get; set; }
    //    public string last_name { get; set; }
    //    public string address_1 { get; set; }
    //    public string address_2 { get; set; }
    //    public string country_iso_2 { get; set; }
    //    public string city { get; set; }
    //    public Vat vat { get; set; }
    //    public bool cc_verified { get; set; }
    //    public string currency { get; set; }
    //}

    //public class Credit
    //{
    //    public Account account { get; set; }
    //    public Promo promo { get; set; }
    //    public Resources resources { get; set; }
    //}

    //public class Pricing
    //{
    //    public double price { get; set; }
    //    public bool taxed { get; set; }
    //    public string currency { get; set; }
    //    public string unit { get; set; }
    //}

    //public class Promo
    //{
    //    public double remaining { get; set; }
    //    public double usage { get; set; }
    //    public string currency { get; set; }
    //}

    //public class Remaining
    //{
    //    public int time { get; set; }
    //    public string unit { get; set; }
    //}

    //public class Resources
    //{
    //    public Pricing pricing { get; set; }
    //    public Remaining remaining { get; set; }
    //}


    //public class Vat
    //{
    //    public int amount { get; set; }
    //    public string number { get; set; }
    //    public bool valid { get; set; }
    //}







}









