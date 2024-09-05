using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert ( T entity );
        void TUpdate ( T entity );
        void TDelete ( int id );
        List<T> TGetListAll ();
        T TGetById ( int id );
        List<T> TGetListByFilter ( Func<T, bool> filter );
    }
}
