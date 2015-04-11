using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NSUDemo.Controllers
{
    public class BasicController : Controller
    {
        // GET: Basic
        public string Index()
        {
            return "Hello World";
        }

        public string Alim() {
            return "Hello! Alim Ul Karim";
        }
        public ViewResult GiveView() {
            return View();
        }
    }
}