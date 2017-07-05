using FourSSecurity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FourSSecurityPortal
{
    public class BaseController:Controller
    {
        public User GetCurrentUser()
        {
            if (Session["CurrentUser"] != null)
                return (User)Session["CurrentUser"];
            else
                RedirectToAction("Login", "Home");

            return null;
        }

        public void SetCurrentUser(User user)
        {
            Session["CurrentUser"] = user;
        }
    }
}