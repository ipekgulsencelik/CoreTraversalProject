using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
