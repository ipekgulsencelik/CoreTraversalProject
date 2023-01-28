using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.WebUI.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManger = new DestinationManager(new EFDestinationDAL());

        public IActionResult Index()
        {
            var values = destinationManger.TGetList();

            return View(values);
        }

        //[HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.destination = id;

            var values = destinationManger.TGetByID(id);

            return View(values);
        }

        //[HttpPost]
        //public IActionResult DestinationDetails(Destination destination)
        //{
        //    return View();
        //}
    }
}
