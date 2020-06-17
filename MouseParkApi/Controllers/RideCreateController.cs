using Microsoft.AspNet.Identity;
using MousePark.Data;
using MousePark.Models;
using MousePark.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MouseParkApi.Controllers
{
    public class RideCreateController : Controller
    {
        // GET: ParkView
        //public ActionResult Index()
        //{
        //    //IEnumerable<Ride> rides = null;

        //    //using (var client = new HttpClient())
        //    //{
        //    //    client.BaseAddress = new Uri("https://localhost:44391/api/");
        //    //    var responseTask = client.GetAsync("ride");
        //    //    responseTask.Wait();

        //    //    var result = responseTask.Result;
        //    //    if (result.IsSuccessStatusCode)
        //    //    {
        //    //        var readTask = result.Content.ReadAsAsync<IList<Ride>>();
        //    //        readTask.Wait();

        //    //        rides = readTask.Result;
        //    //    }
        //    //    else
        //    //    {
        //    //        rides = Enumerable.Empty<Ride>();

        //    //        ModelState.AddModelError(string.Empty, "Server Error.");
        //    //    }
        //    //}
        //    return View(/*rides*/);
        //}
        private RideService GetRideService()
        {
            var service = new RideService();
            return service;
        }
        public ActionResult Index()
        {
            var service = GetRideService();
            return View(service.GetRides());
        }
        public ActionResult Details(int id)
        {
            var svc = GetRideService();
            var model = svc.GetRideByID(id);

            return View(model);
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
        //[HttpPut]
        //public ActionResult Edit(RideEdit pr)
        //{
        //    RideController rp = new RideController();
        //    rp.Put(pr);
        //    return View();
        //}
        public ActionResult Edit(int id)
        {
            var service = GetRideService();
            var detail = service.GetRideByID(id);
            var model =
            new RideEdit
            {
                Name = detail.Name,
                RideDescription = detail.RideDescription,
                HeightReq = detail.HeightReq,
                RideType = detail.RideType
            };
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var svc = GetRideService();
            var model = svc.GetRideByID(id);

            return View(model);
        }
    }
}