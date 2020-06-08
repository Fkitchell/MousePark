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
    public class EateryController : ApiController
    {
        private EateryService CreateEateryService()
        {
            var eateryService = new EateryService();
            return eateryService;
        }
        [AllowAnonymous]
        public IHttpActionResult Get()
        {
            EateryService eateryService = CreateEateryService();
            var food = eateryService.GetEateries();
            return Ok(food);
        }
        public IHttpActionResult Post(EateryCreate food)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateEateryService();
            if (!service.CreateEatery(food))
                return InternalServerError();
            return Ok();
        }
        [AllowAnonymous]
        public IHttpActionResult Get(int id)
        {
            EateryService eateryService = CreateEateryService();
            var food = eateryService.GetEateryById(id);
            return Ok(food);
        }
        public IHttpActionResult Put(EateryEdit food)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateEateryService();

            if (!service.UpdateEatery(food))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateEateryService();

            if (!service.DeleteEatery(id))
                return InternalServerError();

            return Ok();
        }
    }
}


