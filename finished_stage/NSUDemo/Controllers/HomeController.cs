using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NSUDemo.Models;

namespace NSUDemo.Controllers {
    public class HomeController : Controller {

        EntityDatabase db = new EntityDatabase();
        public ActionResult Index() {
            var events = db.Events.OrderByDescending(n=> n.EventID).Take(3);
            return View(events);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}