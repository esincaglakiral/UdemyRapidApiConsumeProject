using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.GuestDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(CreateGuestDto guest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var mappedvalues = _mapper.Map<Guest>(guest);
            _guestService.TInsert(mappedvalues);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var value = _guestService.TGetById(id);
            _guestService.TDelete(value);
            return Ok();
        }



        [HttpPut]
        public IActionResult UpdateGuest(UpdateGuestDto guest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Guest>(guest);
            _guestService.TUpdate(values);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetGuestById(int id)
        {
            var value = _guestService.TGetById(id);
            return Ok(value);
        }


    }
}
