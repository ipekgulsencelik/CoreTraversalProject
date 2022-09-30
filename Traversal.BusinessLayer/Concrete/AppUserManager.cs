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
    public class AppUserManager : IAppUserService
    {
        IAppUserDAL _appUserDAL;

        public AppUserManager(IAppUserDAL appUserDAL)
        {
            _appUserDAL = appUserDAL;
        }

        public void TAdd(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _appUserDAL.GetList();
        }

        public void TUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
