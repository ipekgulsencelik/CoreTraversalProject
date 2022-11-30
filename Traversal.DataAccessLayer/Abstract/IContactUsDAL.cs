﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IContactUsDAL : IGenericDAL<ContactUs>
    {
        List<ContactUs> GetListContactUsByTrue();
        List<ContactUs> GetListContactUsByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
