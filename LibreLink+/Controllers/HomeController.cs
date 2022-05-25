using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreLink_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    public ActionResult Diary()
        {
            ViewBag.Message = "Your Diary Page.";

            return View();
        }
        public ActionResult Reminder()
        {
            ViewBag.Message = "Your Reminder Page.";

            return View();
        }
        public ActionResult LevelGuide()
        {
            ViewBag.Message = "Your Level Guide Page.";

            return View();
        }
    }
}
