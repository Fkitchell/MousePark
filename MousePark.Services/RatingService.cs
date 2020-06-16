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
        private readonly Guid _userId;
        public RatingService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateRating(RatingCreate model)
        {
            Rating rating = new Rating
            {
                UserId = _userId,
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
        public IEnumerable<RatingListItem> GetRatings()
        {
            using (var rtg = new ApplicationDbContext())
            {
                var query =
                    rtg.Ratings
                    .ToList();
                List<RatingListItem> Result = new List<RatingListItem>();
                foreach (Rating r in query)
                {
                    RatingListItem rating = new RatingListItem
                    {
                        RatingId = r.RatingId,
                        Score = r.Score,
                        UserId = r.UserId,
                        EateryId = r.EateryId,
                        RideId = r.RideId,
                        ShowId = r.ShowId,
                    };
                    Result.Add(rating);
                }
                return Result;
            }
        }
        public IEnumerable<RatingListItem> GetRatingsByUser()
        {
            using (var rtg = new ApplicationDbContext())
            {
                var query =
                    rtg.Ratings
                    .Where(r => r.UserId == _userId)
                    .Select(
                        r =>
                        new RatingListItem
                        {
                            RatingId = r.RatingId,
                            Score = r.Score,
                            UserId = r.UserId,
                            EateryId = r.EateryId,
                            RideId = r.RideId,
                            ShowId = r.ShowId,
                        }
                        );
                return query.ToArray();
            }
        }
        public RatingDetail GetRatingByIdByUser(int id)
        {
            using (var rtg = new ApplicationDbContext())
            {
                var entity =
                    rtg
                        .Ratings
                        .Single(r => r.RatingId == id && r.UserId == _userId);
                return
                    new RatingDetail
                    {
                        RatingId = entity.RatingId,
                        Score = entity.Score,
                        EateryId = entity.EateryId,
                        RideId = entity.RideId,
                        ShowId = entity.ShowId
                    };
            }
        }
        public bool UpdateRating(RatingEdit model)
        {
            using (var rtg = new ApplicationDbContext())
            {
                Rating rating = rtg.Ratings.Single(r => r.RatingId == model.RatingId && r.UserId == _userId);
                rating.Score = model.Score;
                rating.EateryId = model.EateryId;
                rating.RideId = model.RideId;
                rating.ShowId = model.ShowId;

                return rtg.SaveChanges() == 1;
            }
        }
        public bool DeleteRating(int ratingId)
        {
            using (var rtg = new ApplicationDbContext())
            {
                Rating rating = rtg.Ratings.Single(r => r.RatingId == ratingId && r.UserId == _userId);
                rtg.Ratings.Remove(rating);

                return rtg.SaveChanges() == 1;
            }
        }
    }
}


