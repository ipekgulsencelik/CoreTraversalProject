using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;
using Traversal.EntityLayer.Concrete;

namespace Traversal.WebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentDAL());

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.DestinationID = id;

            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;

            comment.DestinationID = 3;

            commentManager.TAdd(comment);

            return RedirectToAction("Index", "Destnation");
        }
    }
}
