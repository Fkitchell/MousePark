using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseParkApi.Controllers
{
    public class ParkViewController : Controller
    {
        // GET: ParkView
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ParkCreate cp)
        {
            ParkController pc = new ParkController();
            pc.Post(cp);
            return View();
        }

    }
}