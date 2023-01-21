using System.Collections.Generic;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete;

namespace Traversal.DataAccessLayer.Repository
{
    public class GenericUnitOfWorkRepository<T> : IGenericUnitOfWorkDAL<T> where T : class
    {
        private readonly Context _context;

        public GenericUnitOfWorkRepository(Context context)
        {
            _context = context;
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Add(entity);
        }

        public void MultiUpdate(List<T> entity)
        {
            _context.UpdateRange(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}