using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }


        [HttpGet]  //api controllerlarda mutlaka http attribute'ları belirtilmeli
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }


        [HttpGet("getLastRoomList")]
        public IActionResult getLastRoomList()
        {
            var values = _roomService.TGetLast3RoomList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)  // RoomAddDto'da parametre alır
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();  //Model state valid değilse olumsuz istek BadRequest gönderilir
            }
            var values = _mapper.Map<Room>(roomAddDto); //roomAddDto parametresini mapliyoruz
            _roomService.TInsert(values);
            return Ok("Başarıyla Eklendi");
        }


        [HttpDelete("{id}")]   //id'ye göre getirme işlemi yaptığımız için id 'yi attribute içerisinde belirtmeliyiz
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok("Başarıyla Silindi");
        }


        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDto roomUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomUpdateDto);
            _roomService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }


        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }

    }
}
