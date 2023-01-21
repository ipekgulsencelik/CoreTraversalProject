using System.Collections.Generic;
using Traversal.BusinessLayer.Abstract.UnitOfWork;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.UnitOfWork;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete.UnitOfWork
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDAL _accountDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public AccountManager(IAccountDAL accountDAL, IUnitOfWorkDAL unitOfWorkDAL)
        {
            _accountDAL = accountDAL;
            _unitOfWorkDAL = unitOfWorkDAL;
        }

        public Account TGetByID(int id)
        {
            return _accountDAL.GetByID(id);
        }

        public void TInsert(Account entity)
        {
            _accountDAL.Insert(entity);
            _unitOfWorkDAL.Save();
        }

        public void TMultiUpdate(List<Account> entity)
        {
            _accountDAL.MultiUpdate(entity);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(Account entity)
        {
            _accountDAL.Update(entity);
            _unitOfWorkDAL.Save();
        }
    }
}
