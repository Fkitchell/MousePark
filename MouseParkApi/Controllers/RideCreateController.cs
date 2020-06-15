using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseParkApi.Controllers
{
    public class RideCreateController : Controller
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
        public ActionResult Create(RideCreate cr)
        {
            RideController rc = new RideController();
            rc.Post(cr);
            return View();
        }

    }
}