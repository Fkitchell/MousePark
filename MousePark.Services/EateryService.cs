using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class EateryService
    {
       
        public bool CreateEatery(EateryCreate model)
        {
            var food =
                new Eatery()
                {
                    EateryName = model.EateryName,
                    CuisineType = model.CuisineType,
                    DineIn = model.DineIn,
                    Tier = model.Tier,
                    AreaId = model.AreaId
                };
            using (var fd = new ApplicationDbContext())
            {
                fd.Eateries.Add(food);
                return fd.SaveChanges() == 1;
            }
        }
        public IEnumerable<EateryListItem> GetEateries()
        {
            using (var fd = new ApplicationDbContext())
            {
                var query =
                   fd.Eateries
                   .Select(
                       f =>
                   new EateryListItem
                   {
                       EateryId = f.EateryId,
                       EateryName = f.EateryName,
                       AreaId = f.AreaId
                   }
                   );
                return query.ToArray();
            }
        }
        public EateryDetail GetEateryById(int id)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food =
                    fd.Eateries.Single(f => f.EateryId == id);
                return
                    new EateryDetail
                    {
                        EateryId = food.EateryId,
                        EateryName = food.EateryName,
                        AreaId = food.AreaId
                    };
            }
        }
        public bool UpdateEatery(EateryEdit model)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food =
                    fd
                    .Eateries
                    .Single(f => f.EateryId == model.EateryId);
                food.EateryName = model.EateryName;
                food.AreaId = model.AreaId;

                return fd.SaveChanges() == 1;
            }
        }
        public bool DeleteEatery(int id)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food =
                    fd
                    .Eateries
                    .Single(f => f.EateryId == id);
                fd.Eateries.Remove(food);
                return fd.SaveChanges() == 1;
            }
        }
    }
}
