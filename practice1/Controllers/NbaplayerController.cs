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
            List<Nbaplayer> list = new List<Nbaplayer>();
            Nbaplayer thisplayer=   new Nbaplayer();
            thisplayer.id = 1;
            thisplayer.fname = "Kevin";
            thisplayer.lname = "Durant";
            thisplayer.team = "Nets";
            list.Add(thisplayer);


            Nbaplayer thisplayer2 = new Nbaplayer();
            thisplayer2.id = 2;
            thisplayer2.fname = "LB";
            thisplayer2.lname = "James";
            thisplayer2.team = "Nets";
            list.Add(thisplayer2);

            return View(list);
        }
    }
}