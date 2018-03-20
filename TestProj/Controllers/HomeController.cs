using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ActiveHome = "active";
            ViewBag.ActiveNew = "";
            ViewBag.ActivePopular = "";
            ViewBag.ActiveTop100 = "";
            return View();
        }

        public ActionResult Popular()
        {
            ViewBag.ActiveHome = "";
            ViewBag.ActiveNew = "";
            ViewBag.ActivePopular = "active";
            ViewBag.ActiveTop100 = "";
            ViewBag.Message = "Popular content";

            return View();
        }

        public ActionResult New()
        {
            ViewBag.ActiveHome = "";
            ViewBag.ActiveNew = "active";
            ViewBag.ActivePopular = "";
            ViewBag.ActiveTop100 = "";
            ViewBag.Message = "New content";

            return View();
        }

        public ActionResult Top100()
        {
            ViewBag.ActiveHome = "";
            ViewBag.ActiveNew = "";
            ViewBag.ActivePopular = "";
            ViewBag.ActiveTop100 = "active";
            ViewBag.Message = "Top 100 content";

            return View();
        }
    }
}