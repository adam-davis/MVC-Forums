using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForums.Models;

namespace MvcForums.Controllers
{
    public class RegisterController : Controller
    {
        UserMemberProvider provider;
        // GET: /Register/
       
        public ActionResult Index()
        {


            if(Request.HttpMethod == "GET")
                return View();



            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(UserValidationModel newUser)
        {
            if (!ModelState.IsValid)
                return View();

            provider = new UserMemberProvider();
            if (provider.CreateUser(Request.Form["UserName"], Request.Form["Password"], "") != null)
                return View("Success");
            else
                return View();
            
        }


    }
}
