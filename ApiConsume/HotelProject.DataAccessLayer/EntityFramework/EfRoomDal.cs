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
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        private readonly Context _context;
        public EfRoomDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Room> GetLast3RoomList()
        {
            return _context.Rooms.OrderByDescending(x => x.RoomId).Take(3).ToList();  //Id'ye göre sıralar ve son 3 odayı listeler
        }

        public int GetRoomCount()
        {
          
            var value = _context.Rooms.Count();  //toplam oda sayısını bulur
            return value;
        }
    }
}
