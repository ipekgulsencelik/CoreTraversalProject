using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();

            return View(values);
        }
    }
}
