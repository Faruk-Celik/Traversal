using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        public void TDelete ( int id )
        {
            throw new NotImplementedException();
        }

        public Contact TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetListAll ()
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetListByFilter ( Func<Contact, bool> filter )
        {
            throw new NotImplementedException();
        }

        public void TInsert ( Contact entity )
        {
            throw new NotImplementedException();
        }

        public void TUpdate ( Contact entity )
        {
            throw new NotImplementedException();
        }
    }
}
