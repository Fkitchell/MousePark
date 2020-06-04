using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class RideService
    {
        //private readonly int _rideId;
        //public RideService(int rideId)
        //{
        //    _rideId = rideId;
        //}

        public bool CreateRide(RideCreate model)
        {
            var entity =
                new Ride()
                {
                    //RideId = _rideId,
                    RideName = model.RideName,
                    RideDescription = model.RideDescription,
                    HeightReq = model.HeightReq,
                    RideType = model.RideType,
                    AreaId = model.AreaId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Rides.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<RideListItem> GetRides()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Rides
                    //.Where(e => e.RideId == _rideId)
                    .Select(
                        e =>
                        new RideListItem
                        {
                            RideId = e.RideId,
                            RideName = e.RideName,
                        }
                    );
                return query.ToArray();
            }
        }
        public RideDetail GetRideByID(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Rides
                    .Single(e => e.RideId == id);
                    return
                    new RideDetail
                    {
                        RideName = entity.RideName,
                        RideDescription = entity.RideDescription,
                        RideType = entity.RideType
                    };
            }
        }
        public bool UpdateRide(RideEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Rides
                    .Single(e => e.RideName == model.RideName);

                entity.RideName = model.RideName;
                entity.RideDescription = model.RideDescription;
                entity.HeightReq = model.HeightReq;

                return ctx.SaveChanges() == 1;
            }

        }
        public bool DeleteRide(int RideId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Rides
                    .Single(e => e.RideId == RideId);

                ctx.Rides.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
