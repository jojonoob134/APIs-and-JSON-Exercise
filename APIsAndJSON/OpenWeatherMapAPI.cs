using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {

        public static void WhatIsTemp()
        {
            HttpClient client = new HttpClient();

            Console.WriteLine("What is your city's name");

            string WhatIsCityName = Console.ReadLine();

            string APIKey = "6ca8afff8b2318f9070e61c35179e376";

            string TempAroundMe = $"https://api.openweathermap.org/data/2.5/weather?q={WhatIsCityName}&appid={APIKey}&units=imperial";

            string TempResponce = client.GetStringAsync(TempAroundMe).Result;

            var TownArray = JObject.Parse(TempResponce);

            var tempVar = (double)TownArray["main"]["temp"];
            Console.WriteLine($"The temperature in {WhatIsCityName} is {tempVar} Fahrenheit");
        }
    }
}
