using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricketApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to My Cricket App";

            return View();
        }

        public ActionResult Match()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult News()
        {
            return View();
        }
        public ActionResult Series()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me";

            return View();
        }
    }
}
