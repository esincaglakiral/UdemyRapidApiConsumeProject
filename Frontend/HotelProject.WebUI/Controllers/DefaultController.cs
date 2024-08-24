using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

      
        public PartialViewResult _DefaultSubscribeComponentPartial()
        {
            return PartialView();
        }



        public async Task<JsonResult> SubscribeByEmail(string Email)
        {
            try
            {
                ResultSubscribeDto resultSubscribeDto = new ResultSubscribeDto()
                {
                    Email = Email,
                };

                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(resultSubscribeDto);
                StringContent str = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7185/api/Subscribe", str);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return Json("success");
                }
                else
                {
                 
                    return Json("API request failed with status: " + responseMessage.StatusCode);
                }
            }
            catch (Exception ex)
            {
             
                return Json("Error: " + ex.Message);
            }
        }


    }
}
