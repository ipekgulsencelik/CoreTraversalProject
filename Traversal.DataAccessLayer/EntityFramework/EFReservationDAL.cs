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
    public class EFReservationDAL : GenericRepository<Reservation>, IReservationDAL
    {
        public List<Reservation> GetListWithReservationsByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationsByPassing(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationsByPendingApproval(int id)
        {
            throw new NotImplementedException();
        }
    }
}
