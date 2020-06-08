using MousePark.Models;
using MousePark.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MouseParkApi.Controllers
{
    [Authorize]
    public class ShowController : ApiController
    {
        private ShowService CreateShowService()
        {
            ShowService showService = new ShowService();
            return showService;
        }
        [AllowAnonymous]
        public IHttpActionResult Get()
        {
            ShowService showService = CreateShowService();
            var shows = showService.GetShows();
            return Ok(shows);
        }
        public IHttpActionResult Post(ShowCreate show)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            ShowService showService = CreateShowService();
            if (!showService.CreateShow(show))
                return InternalServerError();
            return Ok();
        }
        [AllowAnonymous]
        public IHttpActionResult Get(int id)
        {
            ShowService showService = CreateShowService();
            var show = showService.GetShowById(id);
            return Ok(show);
        }
        [AllowAnonymous]
        [Route("api/Area/{AreaId}/Show")]
        public IHttpActionResult GetByArea(int areaId)
        {
            ShowService showService = CreateShowService();
            var shows = showService.GetShowsByArea(areaId);
            return Ok(shows);
        }
        [AllowAnonymous]
        [Route("api/Park/{ParkId}/Show")]
        public IHttpActionResult GetByPark(int parkId)
        {
            ShowService showService = CreateShowService();
            var shows = showService.GetShowsByArea(parkId);
            return Ok(shows);
        }
        public IHttpActionResult Put(ShowEdit show)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            ShowService service = CreateShowService();

            if (!service.UpdateShow(show))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            ShowService service = CreateShowService();
            //bool b = service.DeleteShow(id);
            //if (!b)
            //return InternalServerError();
            //above is shorthand for below
            if (!service.DeleteShow(id)) //
                return InternalServerError();

            return Ok();
        }
    }
}
