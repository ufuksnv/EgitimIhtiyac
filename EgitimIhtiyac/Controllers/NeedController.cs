using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Reflection.Metadata;

namespace EgitimIhtiyac.Controllers
{
    public class NeedController : Controller
    {
        NeedManager needManager = new NeedManager(new EfNeedDal());
        public IActionResult Index()
        {
            using var c = new Context();
            var values = needManager.TGetList();
            return View(values);
        }

        public IActionResult GetNeedDetails(int id)
        {
            ViewBag.i=id;
            ViewBag.CommentId = id;
            var values = needManager.TGetByID(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return View(values);
            }

        }

        public IActionResult NeedListByMember()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerID = c.Members.Where(x => x.MemberEmail == usermail).Select(y =>
            y.MemberId).FirstOrDefault();
             var values = needManager.GetNeedListByMember(writerID);
             return View(values);
        }

        public IActionResult DeleteNeed(int id)
        {
            var values = needManager.TGetByID(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                needManager.TDelete(values);
                return View();
            }
        }

        [HttpGet]
        public IActionResult AddNeed()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNeed(Need p)
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerID = c.Members.Where(x => x.MemberEmail == usermail).Select(y =>
            y.MemberId).FirstOrDefault();
            NeedValidator needValidator = new NeedValidator();
            ValidationResult results = needValidator.Validate(p);
            if (results.IsValid)
            {
                p.Status = true;               
                p.MemberId = writerID;
                needManager.TAdd(p);
                return RedirectToAction("NeedListByMember", "Need");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult EditNeed(int id)
        {
           var needvalue = needManager.TGetByID(id);
            return View(needvalue);
        }
        [HttpPost]
        public IActionResult EditNeed(Need p)
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerID = c.Members.Where(x => x.MemberEmail == usermail).Select(y =>
            y.MemberId).FirstOrDefault();

            p.MemberId=writerID;
            p.Status=true;
            needManager.TUpdate(p);
            return RedirectToAction("NeedListByMember", "Need");
        }
    }
}
