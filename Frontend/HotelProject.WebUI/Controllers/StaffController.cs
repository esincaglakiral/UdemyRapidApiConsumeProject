using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();  //istemci oluşturdum
            var responseMessage = await client.GetAsync("https://localhost:7185/api/Staff/");  //swaggerda staff'a ait Get istek url
            if (responseMessage.IsSuccessStatusCode)  //200 durum kodu dönerse
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();  //gelen veri json türünde
                var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);  //json türündeki gelen veriyi deserialize ederek string formata dönüştürüyorum
                return View(values);
            }
            return View();
        }



        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel model)  //AddStaffViewModel den model parametresi türetiyoruz
        {
            var client = _httpClientFactory.CreateClient();  
          
            var jsonData = JsonConvert.SerializeObject(model);  //gönderilen data (string formatta) => json türüne dönüşmesi gerektiği için parametreden gelen değer (model) serialize edilir.
           
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //StringContent bizim içeriğimizin dönüşümü için kullanacağımız bir sınıftır. contentimiz : jsonData, encoding : Encoding.UTF8 (türkçe karakteri de destekleyecek olduğu için utf8), media type: application/json

            var responseMessage = await client.PostAsync("https://localhost:7185/api/Staff/", stringContent);  //PostAsync => ekleme işlemi için, content olarak da stringContent'ten gelen değer gönderilir.
          
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7185/api/Staff/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7185/api/Staff/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateStaffViewModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStaff(UpdateStaffViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7185/api/Staff/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
