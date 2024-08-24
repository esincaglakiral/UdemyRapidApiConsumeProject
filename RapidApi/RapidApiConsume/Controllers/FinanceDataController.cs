using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class FinanceDataController : Controller
    {
        public async Task<IActionResult> Index()
        {
     
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://coinranking1.p.rapidapi.com/stats?referenceCurrencyUuid=yhjMzLPhuIDl"),
                Headers =
    {
        { "x-rapidapi-key", "d17d5b9859mshea9940f0e8e8efbp1e25dfjsnf27a98b2bd65" },
        { "x-rapidapi-host", "coinranking1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<FinanceDataViewModel>(body);
                return View(values.data.bestCoins.ToList());
            }
        }
    }
}
