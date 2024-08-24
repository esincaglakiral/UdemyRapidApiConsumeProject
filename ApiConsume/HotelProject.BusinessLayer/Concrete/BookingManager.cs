using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }


        public void TBookingStatusChangeApproved(int id)
        {
            _bookingDal.BookingStatusChangeApproved(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeWait(int id)
        {
            _bookingDal.BookingStatusChangeWait(id);
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public List<Booking> TGetApprovedBookings()
        {
            return _bookingDal.GetListByFilter(b => b.Status == "Onaylandı");
        }

        public List<Booking> TGetBookingByGuestName(string name)
        {
            return _bookingDal.GetBookingByGuestName(name);
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> TGetCancelledBookings()
        {
            return _bookingDal.GetListByFilter(b => b.Status == "İptal Edildi");
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public List<Booking> TGetListByFilter(Expression<Func<Booking, bool>> where)
        {
            return _bookingDal.GetListByFilter(where);
        }

        public List<Booking> TGetWaitedBookings()
        {
            return _bookingDal.GetListByFilter(b => b.Status == "Beklemede, Müşteri Aranacak");
        }

        public void TInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public List<Booking> TLast6Bookings()
        {
            return _bookingDal.Last6Bookings();
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
