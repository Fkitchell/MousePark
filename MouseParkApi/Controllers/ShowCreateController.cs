using MousePark.Models;
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
        public ActionResult Create(ShowCreate cs)
        {
            ShowController sc = new ShowController();
            sc.Post(cs);
            return View();
        }

    }
}