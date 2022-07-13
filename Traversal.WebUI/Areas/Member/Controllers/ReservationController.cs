using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;
using Traversal.EntityLayer.Concrete;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        DestinationManager destinationManger = new DestinationManager(new EFDestinationDAL());
        ReservationManager reservationManager = new ReservationManager(new EFReservationDAL());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        public IActionResult MyOldReservation()
        {
            return View();
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            //ViewBag.valuesID = values.Id;

            var valuesList = reservationManager.GetListApprovalReservations(values.Id);

            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManger.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();

            ViewBag.values = values;

            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserID = 1003;

            reservation.Status = "Onay Bekliyor";

            reservationManager.TAdd(reservation);

            return RedirectToAction("MyCurrentReservation");
        }
    }
}
