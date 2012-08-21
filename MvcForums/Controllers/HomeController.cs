using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcForums.Models;

namespace MvcForums.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {

        UserMemberProvider provider;

        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            if(Request.IsAuthenticated)
                return RedirectToAction("Index", "Forum");
            return View();
        }


    }
}
