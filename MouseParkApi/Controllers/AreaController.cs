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
    [Authorize]
    public class AreaController : ApiController
    {
        private AreaService CreateAreaService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var areaService = new AreaService(userId);
            return areaService;
        }
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
        public IHttpActionResult Get(int areaId)
        {
            AreaService areaService = CreateAreaService();
            var area = areaService.GetAreaById(areaId);
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
        public IHttpActionResult Delete(int areaId)
        {
            var service = CreateAreaService();

            if (!service.DeleteArea(areaId))
                return InternalServerError();
            return Ok();
        }
    }
}
