using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Net;

namespace HomoTTacker_2._0
{

    public class MyJson
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
    public class Data
    {
        [JsonProperty("available")]
        public bool Available { get; set; }
        
    }
    class Whois
    {
        public string urlTxt;

        public void WhoisDomain(string url)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://madchecker.com/domain/api/"+urlTxt+".com?properties=expiration-registrant_email");
            request.ContentType = "application/json; charset=utf-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string finishResponse = reader.ReadToEnd();
            reader.Close();

            var responsej = JsonConvert.DeserializeObject<MyJson>(finishResponse);
            Console.WriteLine("Available Register:{0}",responsej.Data.Available);




        }


    }
}
