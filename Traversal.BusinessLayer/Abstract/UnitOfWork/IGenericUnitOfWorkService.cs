using System.Collections.Generic;

namespace Traversal.BusinessLayer.Abstract.UnitOfWork
{
    public interface IGenericUnitOfWorkService<T>
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TMultiUpdate(List<T> entity);
        T TGetByID(int id);
    }
}