﻿using System.Web.Mvc;
using System.Configuration;

namespace ps_90000.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var fromConfig = new Models.FromConfig { Message = ConfigurationManager.AppSettings["greeting"] };
            return View(fromConfig);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}