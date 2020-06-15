using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseParkApi.Controllers
{
    public class AreaCreateController : Controller
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
        public ActionResult Create(AreaCreate ca)
        {
            AreaController ac = new AreaController();
            ac.Post(ca);
            return View();
        }

    }
}