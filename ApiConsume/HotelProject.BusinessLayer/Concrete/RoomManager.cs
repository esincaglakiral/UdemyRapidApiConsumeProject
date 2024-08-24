using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;
        private readonly IAboutDal _aboutDal;
        public RoomManager(IRoomDal roomDal, IAboutDal aboutDal)
        {
            _roomDal = roomDal;
            _aboutDal = aboutDal;
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);

            // About tablosundaki RoomCount değerini güncelliyorum
            var about = _aboutDal.GetList().FirstOrDefault(); // Yalnızca bir About kaydı varsa
            if (about != null)
            {
                about.RoomCount = _roomDal.GetRoomCount(); // Güncel oda sayısını alıyorum
                _aboutDal.Update(about);
            }
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> TGetLast3RoomList()
        {
            return _roomDal.GetLast3RoomList();
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public List<Room> TGetListByFilter(Expression<Func<Room, bool>> where)
        {
            return _roomDal.GetListByFilter(where);
        }

        public int TGetRoomCount()
        {
            return _roomDal.GetRoomCount();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
            // About tablosundaki RoomCount değerini güncelliyorum
            var about = _aboutDal.GetList().FirstOrDefault(); // Yalnızca bir About kaydı varsa
            if (about != null)
            {
                about.RoomCount = _roomDal.GetRoomCount(); // Toplam oda sayısını alıyorum
                _aboutDal.Update(about);
            }
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
