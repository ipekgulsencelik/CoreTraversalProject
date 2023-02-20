using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.WebUI.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDAL());

        Context context = new Context();
        
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x => x.DestinationID == id).Count();

            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            
            return View(values);
        }
    }
}