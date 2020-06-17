using MousePark.Models;
using MousePark.Services;
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
        private AreaService GetAreaService()
        {
            var service = new AreaService();
            return service;
        }
        public ActionResult Index()
        {
            var service = GetAreaService();
            return View(service.GetAreas());
        }
        public ActionResult Details(int id)
        {
            var svc = GetAreaService();
            var model = svc.GetAreaById(id);

            return View(model);
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
        public ActionResult Delete(int id)
        {
            var svc = GetAreaService();
            var model = svc.GetAreaById(id);

            return View(model);
        }
    }
}