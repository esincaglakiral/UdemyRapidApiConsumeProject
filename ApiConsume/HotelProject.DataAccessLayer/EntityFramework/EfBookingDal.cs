using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly Context _context;
        public EfBookingDal(Context context) : base(context)
        {
            _context = context;
        }



        public void BookingStatusChangeApproved(int id)
        {
            var value = _context.Bookings.Find(id);
            value.Status = "Onaylandı";

            _context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var value = _context.Bookings.Find(id);
            value.Status = "İptal Edildi";
            _context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var value = _context.Bookings.Find(id);
            value.Status = "Beklemede, Müşteri Aranacak";
            _context.SaveChanges();
        }

        public List<Booking> GetApprovedBookings()
        {
            return _context.Bookings.Where(x => x.Status == "Onaylandı").ToList();
        }

        public List<Booking> GetBookingByGuestName(string name)
        {
            return _context.Bookings.Where(x => x.NameSurname == name).ToList();
        }

        public int GetBookingCount()
        {
            return _context.Bookings.Count();
        }

        public List<Booking> GetCancelledBookings()
        {
            return _context.Bookings.Where(x => x.Status == "İptal Edildi").ToList();
        }

        public List<Booking> GetWaitedBookings()
        {
            return _context.Bookings.Where(x => x.Status == "Beklemede, Müşteri Aranacak").ToList();
        }

        public List<Booking> Last6Bookings()
        {
            return _context.Bookings.OrderByDescending(x => x.BookingId).Take(6).ToList();
        }
    }
}
