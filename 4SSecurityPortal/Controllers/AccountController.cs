using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using FourSSecurityPortal.Models;
using FourSSecurity.UnitOfWork;
using FourSSecurity.Entity;
using FourSSecurity.UnitOfWork.Business;
using FourSSecurity.UnitOfWork.Contract;
using System.Web.Security;

namespace FourSSecurityPortal.Controllers
{
    public class AccountController : BaseController
    {
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string loginname, string pass)
        {
            IUser iuser = new BSUser();

            User user = iuser.loginUser(loginname, pass);

            if (user != null)
            {
                SetCurrentUser(user);
                FormsAuthentication.SetAuthCookie(loginname, false);
                return Content("");
            }
            else //login işlemi başarısız                
                throw new Exception("Kullanıcı adı ve/veya şifre hatalı");

        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}