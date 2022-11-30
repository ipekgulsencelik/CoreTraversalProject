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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDAL _announcementDAL;

        public AnnouncementManager(IAnnouncementDAL announcementDAL)
        {
            _announcementDAL = announcementDAL;
        }

        public void TAdd(Announcement entity)
        {
            _announcementDAL.Insert(entity);
        }

        public void TDelete(Announcement entity)
        {
            _announcementDAL.Delete(entity);
        }

        public Announcement TGetByID(int id)
        {
            return _announcementDAL.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDAL.GetList();
        }

        public void TUpdate(Announcement entity)
        {
            _announcementDAL.Update(entity);
        }
    }
}