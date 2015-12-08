using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {            
            //ViewBag.Name = "Georgios Tzavaras";
            //ViewBag.Location = "Englewood, NJ";

            var model = new AboutModel();
            model.Name = "Georgios Tzavaras";
            model.Location = "Englewood, NJ";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}