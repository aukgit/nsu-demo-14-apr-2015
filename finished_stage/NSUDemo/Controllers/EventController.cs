using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NSUDemo.Models;

namespace NSUDemo.Controllers {
    public class EventController : Controller {

        private EntityDatabase db = new EntityDatabase();
        void GetDropDown() {
            ViewBag.EventCategoryId = new SelectList(db.EventCategories.ToList(), "EventCategoryId", "EventCategoryName");
        }
        public ActionResult Index() {
            var events = db.Events.ToList();
            return View(events);
        }

        // GET: Event/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: Event/Create
        public ActionResult Create() {
            GetDropDown();
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(Event @event) {
            try {
                if (ModelState.IsValid) {
                    db.Events.Add(@event);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            } catch {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }
    }
}
