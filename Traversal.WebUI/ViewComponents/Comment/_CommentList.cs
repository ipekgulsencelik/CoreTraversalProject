using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.WebUI.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDAL());

        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDestinationByID(id);

            return View(values);
        }
    }
}
