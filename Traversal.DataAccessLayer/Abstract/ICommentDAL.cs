using System.Collections.Generic;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface ICommentDAL : IGenericDAL<Comment>
    {
        public List<Comment> GetListCommentWithDestination();
        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
