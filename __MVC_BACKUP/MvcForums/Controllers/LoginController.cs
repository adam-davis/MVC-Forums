using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcForums.Models;

namespace MvcForums.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        UserMemberProvider provider;
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(string returnUrl)
        {
            provider = new UserMemberProvider();
            if (!ValidateLogOn(Request.Form["userName"], Request.Form["password"]))
            {
                return View();
            }

            User user = provider.User;
            FormsAuthentication.SetAuthCookie(user.UserName, false);
            if (!String.IsNullOrEmpty(returnUrl) && returnUrl != "/")
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        private bool ValidateLogOn(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName))
            {
                ModelState.AddModelError("username", "You must specify a username.");
            }
            if (String.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("password", "You must specify a password.");
            }
            if (!provider.ValidateUser(userName, password))
            {
                ModelState.AddModelError("_FORM", "The username or password provided is incorrect.");
            }

            return ModelState.IsValid;
        }

    }
}
