using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OpenWeatherAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherKey = "fdfdfea07bc979251d2b0060cf97076d";
            var client = new HttpClient();
            Console.WriteLine("Input city name");
            var cityName = Console.ReadLine();
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={weatherKey}&units=imperial";
            var response = client.GetStringAsync(weatherURL).Result;
            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
            Console.WriteLine(formattedResponse);
            Console.ReadLine();

        }
    }
}
