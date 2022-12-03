using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EgitimIhtiyac.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _needManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment p)
        {          
            p.CommentStatus = true;
            _needManager.TAdd(p);
            return RedirectToAction("GetNeedDetails", "Need", new { id = p.NeedId });
            
        }
    }
}
