using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);  //DataAccess katmanındaki Generic Interfaceteki metotların aynısı aslında, business katmanındakileri ayırmak adına başlarına T ekledik
        void TDelete(T t);
        void TUpdate(T t);
        T TGetById(int id);
        List<T> TGetList();
        List<T> TGetListByFilter(Expression<Func<T, bool>> where);
    }
}
