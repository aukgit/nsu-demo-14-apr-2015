using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NSUDemo.Models;

namespace NSUDemo.Controllers {
    public class EventCategoriesController : Controller {
        EntityDatabase db = new EntityDatabase();
        public ActionResult Index() {
            var categories = db.EventCategories.ToList();
            return View(categories);
        }

        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EventCategory category) {
            if (ModelState.IsValid) {
                db.EventCategories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

    }
}