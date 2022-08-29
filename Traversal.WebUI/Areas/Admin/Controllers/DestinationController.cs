using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;
using Traversal.EntityLayer.Concrete;

namespace Traversal.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManger = new DestinationManager(new EFDestinationDAL());

        public IActionResult Index()
        {
            var values = destinationManger.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            destinationManger.TAdd(destination);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            var values = destinationManger.TGetByID(id);
            destinationManger.TDelete(values);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = destinationManger.TGetByID(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            destinationManger.TUpdate(destination);

            return RedirectToAction("Index");
        }
    }
}
