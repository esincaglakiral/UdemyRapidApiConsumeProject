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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;
        private readonly IAboutDal _aboutDal;
        public GuestManager(IGuestDal guestDal, IAboutDal aboutDal)
        {
            _guestDal = guestDal;
            _aboutDal = aboutDal;
        }

        public void TDelete(Guest t)
        {
            _guestDal.Delete(t);

            // About tablosundaki CustomerCount değerini güncelliyorum
            var about = _aboutDal.GetList().FirstOrDefault(); // Yalnızca bir About kaydı varsa
            if (about != null)
            {
                about.CustomerCount = _guestDal.GetGuestCount(); // Güncel misafir sayısını alıyorum
                _aboutDal.Update(about);
            }
        }

        public Guest TGetById(int id)
        {
            return _guestDal.GetById(id);
        }

        public int TGetGuestCount()
        {
            return _guestDal.GetGuestCount();
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public List<Guest> TGetListByFilter(Expression<Func<Guest, bool>> where)
        {
            return _guestDal.GetListByFilter(where);
        }

        public void TInsert(Guest t)
        {
            _guestDal.Insert(t);

            // About tablosundaki CustomerCount değerini güncelliyorum
            var about = _aboutDal.GetList().FirstOrDefault(); // Yalnızca bir About kaydı varsa
            if (about != null)
            {
                about.CustomerCount = _guestDal.GetGuestCount(); // Güncel misafir sayısını alıyorum
                _aboutDal.Update(about);
            }
        }

        public void TUpdate(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
