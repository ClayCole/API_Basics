using Newtonsoft.Json.Linq;

for (int i = 0; i < 5; i++)
{

 var client1 = new HttpClient();

 var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

 var ronResponses = client1.GetStringAsync(ronSwansonURL).Result;

 var ronQuote = JArray.Parse(ronResponses);


    Console.WriteLine("Ron:");
 Console.WriteLine($"{ronQuote[0]}");



 var client2 = new HttpClient();

 var kanyeURL = "https://api.kanye.rest";

 var kanyeResponses = client2.GetStringAsync(kanyeURL).Result;

 var kanyeQuote = JObject.Parse(kanyeResponses).GetValue("quote").ToString();
    Console.WriteLine("Kanye:");
 Console.WriteLine($"{kanyeQuote}");
    Console.WriteLine();

}
