﻿using System;
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
    public class EFContactUsDAL : GenericRepository<ContactUs>, IContactUsDAL
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using (var context = new Context())
            {
                var values = context.ContactUs.Where(x => x.MessageStatus == false).ToList();

                return values;
            }
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactUs.Where(x => x.MessageStatus == true).ToList();

                return values;
            }
        }
    }
}