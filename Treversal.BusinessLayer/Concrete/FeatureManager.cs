using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Abstact;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager ( IFeatureDal featureDal )
        {
            _featureDal = featureDal;
        }

        public void TDelete ( int id )
        {
           _featureDal.Delete ( id );
        }

        public Feature TGetById ( int id )
        {
           return _featureDal.GetById ( id );
        }

        public List<Feature> TGetListAll ()
        {
           return _featureDal.GetListAll();
        }

        public void TInsert ( Feature entity )
        {
             _featureDal.Insert ( entity );
        }

        public void TUpdate ( Feature entity )
        {
            _featureDal.Update ( entity );
        }
    }
}
