using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.Areas.Member.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
