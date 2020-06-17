using MousePark.Models;
using MousePark.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseParkApi.Controllers
{
    public class EateryCreateController : Controller
    {
        // GET: ParkView
        private EateryService GetEateryService()
        {
            var service = new EateryService();
            return service;
        }
        public ActionResult Index()
        {
            var service = GetEateryService();
            return View(service.GetEateries());
        }
        public ActionResult Details(int id)
        {
            var svc = GetEateryService();
            var model = svc.GetEateryById(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EateryCreate ce)
        {
            EateryController ec = new EateryController();
            ec.Post(ce);
            return View();
        }
        public ActionResult Edit(int id)
        {
            var service = GetEateryService();
            var detail = service.GetEateryById(id);
            var model =
            new EateryEdit
            {
                Name = detail.Name,
                CuisineType = detail.CuisineType,
                DineIn = detail.DineIn,
                Tier = detail.Tier,
            };
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var svc = GetEateryService();
            var model = svc.GetEateryById(id);

            return View(model);
        }
    }
}