using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForums.Models;

namespace MvcForums.Controllers
{
    [Authorize(Roles="admin")]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Forums()
        {
            return View();

        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Forums(ForumViewModel newForum)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                MvcForumsEntities entities;
                using (entities = new MvcForumsEntities())
                {
                    Forum forum = new Forum() { description = newForum.Description, name = newForum.Name };
                    entities.AddToForum(forum);
                    entities.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }

            return View();
        }
    }
}
