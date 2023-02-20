using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;
using Traversal.EntityLayer.Concrete;

namespace Traversal.WebUI.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();

            return View(values);
        }

        // [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.destination = id;
            ViewBag.destID = id;

            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;

            var values = destinationManager.TGetDestinationWithGuide(id);
            
            return View(values);
        }

        //[HttpPost]
        //public IActionResult DestinationDetails(Destination destination)
        //{
        //    return View();
        //}
    }
}
