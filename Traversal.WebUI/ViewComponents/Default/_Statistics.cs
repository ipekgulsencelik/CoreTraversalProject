using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Concrete;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();

            ViewBag.destination = c.Destinations.Count();
            ViewBag.guide = c.Guides.Count();
            ViewBag.customer = "285";

            return View();
        }
    }
}
