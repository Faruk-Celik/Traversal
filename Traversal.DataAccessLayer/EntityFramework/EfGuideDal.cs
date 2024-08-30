using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Abstact;
using Traversal.DataAccessLayer.Context;
using Traversal.DataAccessLayer.Repositories;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public EfGuideDal ( TraversalContext context ) : base(context)
        {
        }
    }
}
