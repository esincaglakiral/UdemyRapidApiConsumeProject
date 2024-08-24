using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminBookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7185/api/Bookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ListByGuestName(string guestName)   //isme göre arama yapabilmek için
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7185/api/Bookings/GetByGuestName/{guestName}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View("Index", values);
            }
            return View("Index", new List<ResultBookingDto>()); 
        }



        public async Task<IActionResult> UpdateApproveReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7185/api/Bookings/UpdateBookingApproveById?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var updatedResponseMessage = await client.GetAsync("https://localhost:7185/api/Bookings");
                if (updatedResponseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await updatedResponseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                    return View("Index", values);
                }
            }

            return View("Error");
        }


        public async Task<IActionResult> UpdateCancelReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7185/api/Bookings/UpdateBookingCancelById?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var updatedResponseMessage = await client.GetAsync("https://localhost:7185/api/Bookings");
                if (updatedResponseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await updatedResponseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                    return View("Index", values);
                }
            }

            return View("Error");
        }


        public async Task<IActionResult> UpdateWaitReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7185/api/Bookings/UpdateBookingWaitById?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var updatedResponseMessage = await client.GetAsync("https://localhost:7185/api/Bookings");
                if (updatedResponseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await updatedResponseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                    return View("Index", values);
                }
            }

            return View("Error");
        }


        // Onaylı Rezervasyonları Listele
        public async Task<IActionResult> ListApprovedBookings()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7185/api/Bookings/GetApprovedBookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View("Index", values);
            }
            return View("Index", new List<ResultBookingDto>());
        }


        // Bekletilen Rezervasyonları Listele
        public async Task<IActionResult> ListWaitedBookings()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7185/api/Bookings/GetWaitedBookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View("Index", values);
            }
            return View("Index", new List<ResultBookingDto>());
        }

        // İptal Edilen Rezervasyonları Listele
        public async Task<IActionResult> ListCancelledBookings()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7185/api/Bookings/GetCancelledBookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View("Index", values);
            }
            return View("Index", new List<ResultBookingDto>());
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBooking(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7185/api/Bookings/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<UpdateBookingDto>(jsonData);
                return View(result);

            }
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBookingDto);
            StringContent str = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7185/api/Bookings/UpdateBooking", str);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Icon"] = "success";
                TempData["Result"] = "Rezervasyon Güncellendi";
                return RedirectToAction("Index");
            }
            return View();
        }



        public async Task<IActionResult> DeleteReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7185/api/Bookings/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var updatedResponseMessage = await client.GetAsync("https://localhost:7185/api/Bookings");
                if (updatedResponseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await updatedResponseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                    return View("Index", values);
                }
            }
            return View("Error");
        }

        public async Task<IActionResult> Details(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7185/api/Bookings/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultBookingDto>(jsonData);
                return View(result);
            }
            return View("Error");
        }




    }

}
