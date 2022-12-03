using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EgitimIhtiyac.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        MemberManager needManager = new MemberManager(new EfMemberDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Member p)
        {
            Context c = new Context();
            var datavalue = c.Members.FirstOrDefault( x => x.MemberEmail == p.MemberEmail
            && x.Password == p.Password);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.MemberEmail)
                };
                var useridentity = new ClaimsIdentity(claims,"member");
                var ClaimsPrincipal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(ClaimsPrincipal);
                return RedirectToAction("Index","Need");
            }
            else
            {
                return View();
            }
        }
    }
}
