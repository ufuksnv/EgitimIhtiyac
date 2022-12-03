using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EgitimIhtiyac.ViewComponents.Comment
{
    public class CommentListByNeed : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetAll(id);
            return View(values);
        }
    }
}
