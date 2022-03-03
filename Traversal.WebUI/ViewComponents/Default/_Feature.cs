using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDAL());

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            //ViewBag.image1 = featureManager.TGetByID(1);

            return View(values);
        }
    }
}
