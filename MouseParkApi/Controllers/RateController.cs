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
    public class RateController : ApiController
    {private RateService CreateRateService()
        {
            var rateService = new RateService();
            return rateService;
        }
        public IHttpActionResult Post(RateCreate rate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateRateService();
            if (!service.CreateRate(rate))
                return InternalServerError();
            return Ok();
        }
    }
}
