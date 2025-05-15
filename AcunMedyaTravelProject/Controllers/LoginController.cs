using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AcunMedyaTravelProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin model)
        {
            var values = _context.Admins.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);

            if (values == null)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı Adı Ve Şifre Hatalı!");
                return View(model);
            }

            FormsAuthentication.SetAuthCookie(model.UserName, false);

            Session["currentUser"] = model.UserName;

            return RedirectToAction("Index", "Statistics");
        }
    }
}