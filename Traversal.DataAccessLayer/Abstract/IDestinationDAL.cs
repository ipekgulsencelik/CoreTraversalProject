using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IDestinationDAL : IGenericDAL<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
    }
}
