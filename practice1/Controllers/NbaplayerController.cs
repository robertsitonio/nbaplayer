using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.Models;

namespace practice1.Controllers
{
    public class NbaplayerController : Controller
    {
        // GET: Nbaplayer
        public ActionResult Index()

        {
            Nbaplayer thisplayer=   new Nbaplayer();
            thisplayer.id = 1;
            thisplayer.fname = "Kevin";
            thisplayer.lname = "Durant";
            thisplayer.team = "Nets";





            return View(thisplayer);
        }
    }
}