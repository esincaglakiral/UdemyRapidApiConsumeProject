using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfGuestDal : GenericRepository<Guest>, IGuestDal
    {
        private readonly Context _context;
        public EfGuestDal(Context context) : base(context)
        {
            _context = context;
        }

        public int GetGuestCount()
        {
            var value = _context.Guests.Count();
            return value;
        }
    }
}
