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
    public class ReservationManager : IReservationService
    {
        IReservationDAL _reservationDAL;

        public ReservationManager(IReservationDAL reservationDAL)
        {
            _reservationDAL = reservationDAL;
        }

        public List<Reservation> GetListWithReservationsByAccepted(int id)
        {
            return _reservationDAL.GetListWithReservationsByAccepted(id);
        }

        public List<Reservation> GetListWithReservationsByPassing(int id)
        {
            return _reservationDAL.GetListWithReservationsByPassing(id);
        }

        public List<Reservation> GetListWithReservationsByPendingApproval(int id)
        {
            return _reservationDAL.GetListWithReservationsByPendingApproval(id);
        }

        public void TAdd(Reservation entity)
        {
            _reservationDAL.Insert(entity);
        }

        public void TDelete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
