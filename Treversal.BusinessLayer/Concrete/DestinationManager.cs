﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Abstact;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager ( IDestinationDal destinationDal )
        {
            _destinationDal = destinationDal;
        }

        public void TDelete ( int id )
        {
            _destinationDal.Delete ( id );
            
        }

        public Destination TGetById ( int id )
        {
           return _destinationDal.GetById ( id );
        }

        public List<Destination> TGetListAll ()
        {
            return _destinationDal.GetListAll ();
        }

        public List<Destination> TGetListByFilter ( Func<Destination, bool> filter )
        {
            throw new NotImplementedException();
        }

        public void TInsert ( Destination entity )
        {
           _destinationDal.Insert ( entity );
        }

        public void TUpdate ( Destination entity )
        {
            _destinationDal.Update ( entity );
        }
    }
}
