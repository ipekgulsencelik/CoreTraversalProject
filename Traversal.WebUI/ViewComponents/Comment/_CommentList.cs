using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.WebUI.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        //DestinationManager destinationManger = new DestinationManager(new EFDestinationDAL());

        public IViewComponentResult Invoke()
        {
            //var values = destinationManger.TGetList();

            return View();
        }
    }
}
