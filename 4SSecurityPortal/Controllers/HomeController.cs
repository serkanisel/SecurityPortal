using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FourSSecurity.Entity;

namespace FourSSecurityPortal.Controllers
{
    [AuthenticationAction]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            User user = GetCurrentUser();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyLessons()
        {
            return View();
        }

        public ActionResult ShowVideo(string url)
        {
            ViewBag.URL = url;
            return View();
        }
    }
}