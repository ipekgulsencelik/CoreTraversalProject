using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IReservationDAL : IGenericDAL<Reservation>
    {
        List<Reservation> GetListWithReservationsByPendingApproval(int id);
        List<Reservation> GetListWithReservationsByAccepted(int id);
        List<Reservation> GetListWithReservationsByPassing(int id);
    }
}
