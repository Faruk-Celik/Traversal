using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        public void TDelete ( int id )
        {
            throw new NotImplementedException();
        }

        public Newsletter TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> TGetListAll ()
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> TGetListByFilter ( Func<Newsletter, bool> filter )
        {
            throw new NotImplementedException();
        }

        public void TInsert ( Newsletter entity )
        {
            throw new NotImplementedException();
        }

        public void TUpdate ( Newsletter entity )
        {
            throw new NotImplementedException();
        }
    }
}
