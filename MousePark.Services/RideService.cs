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
        private readonly Guid _rideID;
        public RideService(Guid rideID)
        {
            _rideID = rideID;
        }

        public bool CreateRide(RideCreate model)
        {
            var entity =
                new Rides()
                {
                    RideID = _rideID,
                    RideName = model.RideName,
                    RideDescription = model.RideDescription,
                    RideType = model.RideType
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
                    .Where(e => e.RideID == _rideID)
                    .Select(
                        e =>
                        new RideListItem
                        {
                            RideID = e.RideID,
                            RideName = e.RideName,
                        }
                    );
                return query.ToArray();
            }
        }
        public RideDetail GetRideByID(Guid id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Rides
                    .Single(e => e.RideID == id);
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
        public bool DeleteRide(Guid RideID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Rides
                    .Single(e => e.RideID == RideID);

                ctx.Rides.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
