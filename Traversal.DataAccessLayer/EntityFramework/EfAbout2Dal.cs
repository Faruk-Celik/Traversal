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
    public class EfAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
        public EfAbout2Dal ( TraversalContext context ) : base(context)
        {
        }
    }
}
