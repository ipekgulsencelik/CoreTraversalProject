using System;
using System.Collections.Generic;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Abstract;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDAL _contactUsDAL;

        public ContactUsManager(IContactUsDAL contactUsDAL)
        {
            _contactUsDAL = contactUsDAL;
        }

        public void TAdd(ContactUs entity)
        {
            _contactUsDAL.Insert(entity);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDAL.GetList();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _contactUsDAL.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return _contactUsDAL.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUs entity)
        {
            throw new NotImplementedException();
        }
    }
}