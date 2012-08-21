using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForums.Models;

namespace MvcForums.Controllers
{
    public class ForumController : Controller
    {
        //
        // GET: /Forum/

        MvcForumsEntities _entities;

        public ActionResult Index()
        {
            _entities = new MvcForumsEntities();
            
            var tempForums = (from forum in _entities.Forum select forum);

            _entities = null;
            return View(tempForums.Select(forum => forum).ToList<Forum>());
        }


        [ActionName("View")]
        public ActionResult View(int id)
        {
            _entities = new MvcForumsEntities();

            Forum requestedForum = _entities.Forum.Include("Thread").Single(forum => forum.id == id);
            requestedForum.Thread.Load();

            return View(requestedForum);

        }

    }
}
