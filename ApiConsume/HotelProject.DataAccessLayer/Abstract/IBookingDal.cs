using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        List<Booking> GetApprovedBookings(); 
        List<Booking> GetCancelledBookings(); 
        List<Booking> GetWaitedBookings();

        void BookingStatusChangeApproved(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
        List<Booking> GetBookingByGuestName(string name);
    }
}
