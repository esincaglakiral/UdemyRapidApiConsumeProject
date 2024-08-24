namespace RapidApiConsume.Models
{
    public class FinanceDataViewModel
    {

            public string status { get; set; }
            public Data data { get; set; }
    

        public class Data
        {
            public int referenceCurrencyRate { get; set; }
            public int totalCoins { get; set; }
            public int totalMarkets { get; set; }
            public int totalExchanges { get; set; }
            public string totalMarketCap { get; set; }
            public string total24hVolume { get; set; }
            public float btcDominance { get; set; }
            public Bestcoin[] bestCoins { get; set; }
            public Newestcoin[] newestCoins { get; set; }
        }

        public class Bestcoin
        {
            public string uuid { get; set; }
            public string symbol { get; set; }
            public string name { get; set; }
            public string iconUrl { get; set; }
            public string coinrankingUrl { get; set; }
        }

        public class Newestcoin
        {
            public string uuid { get; set; }
            public string symbol { get; set; }
            public string name { get; set; }
            public string iconUrl { get; set; }
            public string coinrankingUrl { get; set; }
        }


    }
}
