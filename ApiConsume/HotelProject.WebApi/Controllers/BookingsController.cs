using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }


        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok();
        }


        //[HttpPut]
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }


        [HttpGet("GetApprovedBookings")]
        public IActionResult GetApprovedBookings()
        {
            var values = _bookingService.TGetApprovedBookings();
            return Ok(values);
        }

        [HttpGet("GetCancelledBookings")]
        public IActionResult GetCancelledBookings()
        {
            var values = _bookingService.TGetCancelledBookings();
            return Ok(values);
        }

        [HttpGet("GetWaitedBookings")]
        public IActionResult GetWaitedBookings()
        {
            var values = _bookingService.TGetWaitedBookings();
            return Ok(values);
        }


        [HttpGet("Last6Booking")]
        public IActionResult Last6Booking()
        {
            var values = _bookingService.TLast6Bookings();
            return Ok(values);
        }

        [HttpGet("UpdateBookingApproveById")]
        public IActionResult UpdateBookingApproveById(int id)
        {
            _bookingService.TBookingStatusChangeApproved(id);
            return Ok();
        }

        [HttpGet("UpdateBookingCancelById")]
        public IActionResult UpdateBookingCancelByID(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok();
        }

        [HttpGet("UpdateBookingWaitById")]
        public IActionResult UpdateBookingWaitByID(int id)
        {
            _bookingService.TBookingStatusChangeWait(id);
            return Ok();
        }


        [HttpGet("GetByGuestName/{guestName}")]
        public IActionResult GetByGuestName(string guestName)
        {
            var value = _bookingService.TGetBookingByGuestName(guestName);
            return Ok(value);
        }
    }
}
