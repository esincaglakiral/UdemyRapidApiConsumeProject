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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffdal;
        private readonly IAboutDal _aboutDal;
        public StaffManager(IStaffDal staffdal, IAboutDal aboutDal)
        {
            _staffdal = staffdal;
            _aboutDal = aboutDal;
        }

        public void TDelete(Staff t)
        {
            _staffdal.Delete(t);
            // About tablosundaki RoomCount değerini güncelliyorum
            var about = _aboutDal.GetList().FirstOrDefault(); // Yalnızca bir About kaydı varsa
            if (about != null)
            {
                about.StafCount = _staffdal.GetStaffCount(); // Güncel oda sayısını alıyorum
                _aboutDal.Update(about);
            }
        }

        public Staff TGetById(int id)
        {
            return _staffdal.GetById(id);
        }

        public List<Staff> TGetLast4StaffList()
        {
            return _staffdal.GetLast4StaffList();
        }

        public List<Staff> TGetList()
        {
            return _staffdal.GetList();
        }

        public List<Staff> TGetListByFilter(Expression<Func<Staff, bool>> where)
        {
            return _staffdal.GetListByFilter(where);
        }

        public int TGetStaffCount()
        {
            return _staffdal.GetStaffCount();
        }

        public void TInsert(Staff t)
        {
            _staffdal.Insert(t);

            var about = _aboutDal.GetList().FirstOrDefault(); 
            if (about != null)
            {
                about.StafCount = _staffdal.GetStaffCount(); // Toplam personel sayısını alıyorum
                _aboutDal.Update(about);
            }
        }

        public void TUpdate(Staff t)
        {
            _staffdal.Update(t);
        }
    }
}
