using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
     class Program
    {
        static void Main(string[] args)
        {
            var client  = new HttpClient();
            var KanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(KanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine(kanyeQuote);
        }
    }
}



