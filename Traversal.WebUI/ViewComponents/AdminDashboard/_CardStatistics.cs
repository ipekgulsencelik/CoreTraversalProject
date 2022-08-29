using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Concrete;

namespace Traversal.WebUI.ViewComponents.AdminDashboard
{
    public class _CardStatistics : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.destination = context.Destinations.Count();
            ViewBag.user = context.Users.Count();

            return View();
        }
    }
}
