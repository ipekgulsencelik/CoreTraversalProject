using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Abstract;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void TAdd(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetDestinationByID(int id)
        {
            return _commentDAL.GetListByFilter(x => x.DestinationID == id);
        }

        public void TUpdate(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
