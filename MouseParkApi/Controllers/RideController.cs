using MousePark.Data;
using MousePark.Models;
using MousePark.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MouseParkApi.Controllers
{
    [Authorize]
    public class RideController : ApiController
    {
        private RideService CreateRideService()
        {
            var rideService = new RideService();
            return rideService;
        }
        [AllowAnonymous]
        public IHttpActionResult Get()
        {
            RideService rideService = CreateRideService();
            var rides = rideService.GetRides();
            return Ok(rides);
        }
        public IHttpActionResult Post(RideCreate ride)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateRideService();

            if (!service.CreateRide(ride))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            RideService rideService = CreateRideService();
            var rides = rideService.GetRideByID(id);
            return Ok(rides);
        }
        public IHttpActionResult Put(RideEdit ride)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateRideService();

            if (!service.UpdateRide(ride))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateRideService();

            if (!service.DeleteRide(id))
                return InternalServerError();

            return Ok();
        }
    }
}
