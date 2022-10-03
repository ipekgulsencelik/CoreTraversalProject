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
    public class GuideManager : IGuideService
    {
        IGuideDAL _guideDAL;

        public GuideManager(IGuideDAL guideDAL)
        {
            _guideDAL = guideDAL;
        }

        public void TAdd(Guide entity)
        {
            _guideDAL.Insert(entity);
        }

        public void TChangeToFalseByGuide(int id)
        {
            throw new NotImplementedException();
        }

        public void TChangeToTrueByGuide(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide entity)
        {
            _guideDAL.Delete(entity);
        }

        public Guide TGetByID(int id)
        {
            return _guideDAL.GetByID(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDAL.GetList();
        }

        public void TUpdate(Guide entity)
        {
            _guideDAL.Update(entity);
        }
    }
}
