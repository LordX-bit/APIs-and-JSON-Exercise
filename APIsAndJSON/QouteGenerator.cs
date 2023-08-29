using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QouteGenerator
    {
        public static void KanyeQoute()
        {
            var client = new HttpClient();
            var KanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(KanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"--------------");
            Console.WriteLine($"Kanye: `{kanyeQuote}`");
            Console.WriteLine($"----------------");
        }

        public static void RonQoute()
        {
            var client = new HttpClient();

            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronsResponse = client.GetStringAsync(ronUrl).Result;

            var ronQuote = JArray.Parse(ronsResponse).ToString().Replace('[',' ').Replace(']',' ').Trim();

            Console.WriteLine($"--------------");
            Console.WriteLine($"Ron: `{ronQuote}`");
            Console.WriteLine($"----------------");
        }
    }
}
