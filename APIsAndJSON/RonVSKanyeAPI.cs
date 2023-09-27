using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void RonVKan()
        { 

            HttpClient client = new HttpClient();

            string swonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            string swonResponce = client.GetStringAsync(swonURL).Result;

            JArray swanArray = JArray.Parse(swonResponce);

            string kanyeURL = "https://api.kanye.rest";

            string kanjeResponce = client.GetStringAsync(kanyeURL).Result;

            var kanjeArray = JObject.Parse(kanjeResponce).GetValue("quote");

            Console.WriteLine(swanArray[0]);
            Console.WriteLine();
            Console.WriteLine(kanjeArray);
            Console.WriteLine();

        }
    }
}
