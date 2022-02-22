using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _PopulerDestinationsPartial : ViewComponent
    {
        DestinationManager destinationManger = new DestinationManager(new EFDestinationDAL());

        public IViewComponentResult Invoke()
        {
            var values = destinationManger.TGetList();

            return View(values);
        }
    }
}
