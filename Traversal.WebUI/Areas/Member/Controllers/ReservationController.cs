using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrete;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        public IActionResult MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            return View();
        }
    }
}
