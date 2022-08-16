using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.Models;

namespace practice1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        
            Students thisstudents = new Students();
            thisstudents.id = 1;
            thisstudents.fname = "Robert";
            thisstudents.lname = "Sitonio";
            return View(thisstudents);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}