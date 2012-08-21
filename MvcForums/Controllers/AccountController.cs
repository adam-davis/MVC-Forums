using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForums.Models;
using System.Web.Security;

namespace MvcForums.Controllers
{
    public class AccountController : Controller
    {
       
        UserMemberProvider provider;

        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
                return View("Index", "Forum");
            return View();

        }
       
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(string returnUrl)
        {
            provider = new UserMemberProvider();
            if (!ValidateLogOn(Request.Form["UserName"], Request.Form["Password"]))
            {
                return View();
            }

            User user = provider.User;
 
            Session["Role"] = user.role == 2 ? "admin" : "pleeb";
    

            FormsAuthentication.SetAuthCookie(user.UserName, false);
            if (!String.IsNullOrEmpty(returnUrl) && returnUrl != "/")
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Forum");
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

        public ActionResult Register()
        {
            return View();

        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Register(UserValidationModel newUser)
        {
            if (!ModelState.IsValid)
                return View();

            provider = new UserMemberProvider();
            if (provider.CreateUser(Request.Form["UserName"], Request.Form["Password"], Request.Form["Email"]) != null)
                return View("Index", "Forum");
            else
                return View();
        }


        public ActionResult Logout()
        {
            if (Request.IsAuthenticated)
            {
                Session.Clear();
                Session.Abandon();
                FormsAuthentication.SignOut();

            }
            return RedirectToAction("Index", "Home");

        }
        
    }
}
