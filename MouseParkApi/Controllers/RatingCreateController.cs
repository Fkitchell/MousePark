using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseParkApi.Controllers
{
    public class RatingCreateController : Controller
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
        public ActionResult Create(RatingCreate cr)
        {
            RatingController rc = new RatingController();
            rc.Post(cr);
            return View();
        }

    }
}