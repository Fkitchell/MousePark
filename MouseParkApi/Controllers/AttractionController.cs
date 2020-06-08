using MousePark.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MouseParkApi.Controllers
{
    public class AttractionController : ApiController
    {
        private AttractionService CreateAttractionService()
        {
            return new AttractionService();
        }

        public IHttpActionResult GetAttractions()
        {
            AttractionService attractionService = CreateAttractionService();
            var attractions = attractionService.GetAttractions();
            return Ok(attractions);
        }

        [Route("api/Park/{ParkId}/Attraction")]
        public IHttpActionResult GetAttractionsByPark(int parkId)
        {
            AttractionService attractionService = CreateAttractionService();
            var attractions = attractionService.GetAttractionsByPark(parkId);
            return Ok(attractions);
        }

        [Route("api/Area/{ParkId}/Attraction")]
        public IHttpActionResult GetAttractionsByArea(int areaId)
        {
            AttractionService attractionService = CreateAttractionService();
            var attractions = attractionService.GetAttractionsByArea(areaId);
            return Ok(attractions);
        }
    }
}