using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EgitimIhtiyac.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        MemberManager needManager = new MemberManager(new EfMemberDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Member p)
        {
            MemberValidator validationRules = new MemberValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                p.MemberStatus = true;
                needManager.TAdd(p);
                return RedirectToAction("Index", "Need");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
