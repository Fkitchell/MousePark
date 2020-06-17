using MousePark.Models;
using MousePark.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MouseParkApi.Controllers
{
    public class ShowCreateController : Controller
    {
        // GET: ParkView
        private ShowService GetShowService()
        {
            var service = new ShowService();
            return service;
        }
        public ActionResult Index()
        {
            var service = GetShowService();
            return View(service.GetShows());
        }
        public ActionResult Details(int id)
        {
            var svc = GetShowService();
            var model = svc.GetShowById(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ShowCreate cs)
        {
            ShowController sc = new ShowController();
            sc.Post(cs);
            return View();
        }
        public ActionResult Edit(int id)
        {
            var service = GetShowService();
            var detail = service.GetShowById(id);
            var model =
            new ShowEdit
            {
                Name = detail.Name,
                TargetAge = detail.TargetAge,
                Capacity = detail.Capacity,
                RunTime = detail.RunTime,
            };
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var svc = GetShowService();
            var model = svc.GetShowById(id);

            return View(model);
        }
    }
}