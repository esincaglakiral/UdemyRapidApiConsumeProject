namespace RapidApiConsume.Models
{
    public class ExchangeViewModel
    {
        public Result[] result { get; set; }

        public class Result
        {
            public int city_id { get; set; }
            public string name { get; set; }
            public int nr_hotels { get; set; }
            public string country { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string timezone_name { get; set; }
            public int timezone_offset { get; set; }
        }

    }
}
