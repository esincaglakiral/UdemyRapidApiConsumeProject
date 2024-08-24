using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        [HttpGet]  //api controllerlarda mutlaka http attribute'ları belirtilmeli
        public IActionResult ServiceList()
        {
            var values = _servicesService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _servicesService.TInsert(Service);
            return Ok();
        }


        [HttpDelete("{id}")]   //id'ye göre getirme işlemi yaptığımız için id 'yi attribute içerisinde belirtmeliyiz
        public IActionResult DeleteService(int id)
        {
            var values = _servicesService.TGetById(id);
            _servicesService.TDelete(values);
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _servicesService.TUpdate(Service);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetServiceById(int id)
        {
            var values = _servicesService.TGetById(id);
            return Ok(values);
        }
    }
}
