﻿using System;
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
            throw new NotImplementedException();
        }

        public void TDelete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public Guide TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideDAL.GetList();
        }

        public void TUpdate(Guide entity)
        {
            throw new NotImplementedException();
        }
    }
}