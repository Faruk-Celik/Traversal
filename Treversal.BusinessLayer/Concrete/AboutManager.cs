using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        public void TDelete ( int id )
        {
            throw new NotImplementedException();
        }

        public About TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<About> TGetListAll ()
        {
            throw new NotImplementedException();
        }

        public List<About> TGetListByFilter ( Func<About, bool> filter )
        {
            throw new NotImplementedException();
        }

        public void TInsert ( About entity )
        {
            throw new NotImplementedException();
        }

        public void TUpdate ( About entity )
        {
            throw new NotImplementedException();
        }
    }
}
