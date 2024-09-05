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
    public class CommentManager : ICommentService
    {
    private readonly ICommentDal _commentDal;

        public CommentManager ( ICommentDal commentDal )
        {
            _commentDal = commentDal;
        }

        public void TDelete ( int id )
        {
            throw new NotImplementedException();
        }

        public Comment TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListAll ()
        {
            throw new NotImplementedException();
        }

        public void TInsert ( Comment entity )
        {
            throw new NotImplementedException();
        }

        public void TUpdate ( Comment entity )
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetDestinationById ( int id )
        {
           return _commentDal.GetListByFilter (x => x.DestinationID ==id);
        }

        public List<Comment> TGetListByFilter ( Func<Comment, bool> filter )
        {
            throw new NotImplementedException();
        }
    }
}
