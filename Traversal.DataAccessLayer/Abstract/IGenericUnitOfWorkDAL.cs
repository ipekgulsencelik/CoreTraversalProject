using System.Collections.Generic;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IGenericUnitOfWorkDAL<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void MultiUpdate(List<T> t);
        T GetByID(int id);
    }
}
