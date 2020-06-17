using MousePark.Data;
using MousePark.Models;
using MousePark.Services;
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
        private ParkService GetParkService()
        {
            var service = new ParkService();
            return service;
        }
        public ActionResult Index()
        {
            var service = GetParkService();
            return View(service.GetParks());
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