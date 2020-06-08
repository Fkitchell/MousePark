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
            //var entity =
                Ride ride = new Ride
                {
                    RideName = model.RideName,
                    RideDescription = model.RideDescription,
                    HeightReq = model.HeightReq,
                    RideType = model.RideType,
                    AreaId = model.AreaId
                };
            if (ride.RideType == RideType.None)
                return false;
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Rides.Add(ride);
                return ctx.SaveChanges() == 1;
            }
        }
        public RideType ToEnum(string rideType)
        {
            RideType parsedRideType;
            if (Enum.TryParse<RideType>(rideType, true, out parsedRideType))
            {
                return parsedRideType;
            }
            return RideType.None;
        }
        public IEnumerable<RideListItem> GetRides()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Rides
                    .Select(
                        e =>
                        new RideListItem
                        {
                            RideId = e.RideId,
                            RideName = e.RideName,
                            RideType = e.RideType,
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
                        HeightReq = entity.HeightReq,
                        RideType = entity.RideType,
                        AreaId = entity.AreaId
                    };
            }
        }
        public IEnumerable<RideListItem> GetRidesByArea(int areaId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var items = new List<RideListItem>();
                foreach (var e in ctx.Rides)
                {
                    if (e.AreaId == areaId)
                    {
                        items.Add(new RideListItem
                        {
                            RideId = e.RideId,
                            RideName = e.RideName,
                            RideType = e.RideType
                        });
                    }
                }
                return items.ToArray();
            }
        }
        public bool UpdateRide(RideEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Rides
                    .Single(e => e.RideId == model.RideId);

                entity.RideName = model.RideName;
                entity.RideDescription = model.RideDescription;
                entity.HeightReq = model.HeightReq;
                entity.RideType = model.RideType;
                entity.AreaId = model.AreaId;

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
