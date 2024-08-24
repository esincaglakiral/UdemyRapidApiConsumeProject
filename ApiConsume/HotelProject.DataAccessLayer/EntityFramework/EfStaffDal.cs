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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        private readonly Context _context;
        public EfStaffDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Staff> GetLast4StaffList()
        {
            var context = new Context();
            return context.Staffs.OrderByDescending(x => x.StaffId).Take(4).ToList();
        }

        public int GetStaffCount()
        {
            
          var value = _context.Staffs.Count();
          return value;
        }
    }
}
