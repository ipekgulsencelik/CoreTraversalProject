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
    public class DestinationManager : IDestinationService
    {
        IDestinationDAL _destinationDAL;

        public DestinationManager(IDestinationDAL destinationDAL)
        {
            _destinationDAL = destinationDAL;
        }

        public void TAdd(Destination entity)
        {
            _destinationDAL.Insert(entity);
        }

        public void TDelete(Destination entity)
        {
            _destinationDAL.Delete(entity);
        }

        public Destination TGetByID(int id)
        {
            return _destinationDAL.GetByID(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDAL.GetList();
        }

        public void TUpdate(Destination entity)
        {
            _destinationDAL.Update(entity);
        }
    }
}
