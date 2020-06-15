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
    public class RatingController : ApiController
    {
        private RatingService CreateRatingService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var ratingService = new RatingService(userId);
            return ratingService;
        }
        public IHttpActionResult Post(RatingCreate rating)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateRatingService();
            if (!service.CreateRating(rating))
                return InternalServerError();
            return Ok();
        }
        //[AllowAnonymous]
        //public IHttpActionResult Get()
        //{
        //    RatingService ratingService = CreateRatingService();
        //    var ratings = ratingService.GetRatings();
        //    return Ok(ratings);
        //}
        [AllowAnonymous]
        //[Route("api/Account/{RatingId}")]
        public IHttpActionResult GetRatingsByUser()
        {
            RatingService ratingService = CreateRatingService();
            var ratings = ratingService.GetRatingsByUser();
            return Ok(ratings);
        }
        [AllowAnonymous]
        [Route("api/Rating/{RatingId}")]
        public IHttpActionResult GetRatingByIdByUser(int id)
        {
            RatingService ratingService = CreateRatingService();
            var ratings = ratingService.GetRatingByIdByUser(id);
            return Ok(ratings);
        }
        public IHttpActionResult Put(RatingEdit rating)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            RatingService service = CreateRatingService();

            if (!service.UpdateRating(rating))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            RatingService service = CreateRatingService();

            if (!service.DeleteRating(id))
                return InternalServerError();

            return Ok();
        }
    }
}
