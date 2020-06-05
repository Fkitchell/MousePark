using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class ParkService
    {
        //private readonly Guid _userId;

        //public ParkService(Guid userId)
        //{
        //    _userId = userId;
        //}
        public bool CreatePark(ParkCreate model)
        {
            var entity = new Park()
            {
                ParkName = model.ParkName,
                AdmissionPrice = model.AdmissionPrice,
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Parks.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ParkListItem> GetParks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Parks
                    .Select
                    (e =>
                    new ParkListItem
                    {
                        ParkId = e.ParkId,
                        ParkName = e.ParkName,
                        AdmissionPrice = e.AdmissionPrice
                    });
                return query.ToArray();
            }
        }
        public ParkListItem GetParkById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Parks
                    .Single(e => e.ParkId == id);

                return new ParkListItem
                {
                    ParkId = entity.ParkId,
                    AdmissionPrice = entity.AdmissionPrice,
                    ParkName = entity.ParkName
                };
            }
        }
        public bool UpdatePark(ParkEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Parks
                    .Single(e => e.ParkId == model.ParkId);

                entity.ParkName = model.ParkName;
                entity.AdmissionPrice = model.AdmissionPrice;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePark(int parkId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Parks
                    .Single(e => e.ParkId == parkId);

                ctx.Parks.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
