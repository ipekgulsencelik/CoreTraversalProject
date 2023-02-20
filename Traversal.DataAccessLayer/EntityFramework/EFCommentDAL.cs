using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete;
using Traversal.DataAccessLayer.Repository;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.EntityFramework
{
    public class EFCommentDAL : GenericRepository<Comment>, ICommentDAL
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using(var context = new Context())
            {
                return context.Comments.Include(x => x.Destination).ToList();
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(x => x.DestinationID == id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
