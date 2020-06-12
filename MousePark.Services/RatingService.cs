using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class RatingService
    {
        public bool CreateRating(RatingCreate model)
        {
            Rating rating = new Rating
            {
                Score = model.Score,
                EateryId = model.EateryId,
                RideId = model.RideId,
                ShowId = model.ShowId,
            };
            using (var e = new ApplicationDbContext())
            {
                e.Ratings.Add(rating);
                return e.SaveChanges() == 1;
            }
        }
    }
}
