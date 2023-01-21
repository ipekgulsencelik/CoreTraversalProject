using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete;
using Traversal.DataAccessLayer.Repository;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.EntityFramework
{
    public class EFAccountDAL : GenericUnitOfWorkRepository<Account>, IAccountDAL
    {
        public EFAccountDAL(Context context) : base(context)
        {

        }
    }
}
