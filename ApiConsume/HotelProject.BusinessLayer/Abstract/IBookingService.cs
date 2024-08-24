using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        List<Booking> TGetApprovedBookings();
        List<Booking> TGetCancelledBookings();
        List<Booking> TGetWaitedBookings();
        void TBookingStatusChangeApproved(int id);
        int TGetBookingCount();
        List<Booking> TLast6Bookings();
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWait(int id);
        List<Booking> TGetBookingByGuestName(string name);
    }
}
