using Microsoft.AspNet.Identity;
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
    [Authorize] //You have to be signed in to hit this point at all. You cannot get to the methods below at all if you're not signed in. Sign-in is still required.
    public class AreaController : ApiController
    {
        private AreaService CreateAreaService()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId()); //We took out the user id from the creation of the AreaService
            var areaService = new AreaService(); //took out userId parameter
            return areaService;
        }
        [AllowAnonymous]
        public IHttpActionResult Get()
        {
            AreaService areaService = CreateAreaService();
            var areas = areaService.GetAreas();
            return Ok(areas);
        }
        public IHttpActionResult Post(AreaCreate area)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateAreaService();
            if (!service.CreateArea(area))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            AreaService areaService = CreateAreaService();
            var area = areaService.GetAreaById(id);
            return Ok(area);
        }
        public IHttpActionResult Put(AreaEdit area)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateAreaService();
            if (!service.UpdateArea(area))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateAreaService();

            if (!service.DeleteArea(id))
                return InternalServerError();
            return Ok();
        }
    }
}
