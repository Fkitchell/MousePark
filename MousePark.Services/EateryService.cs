using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class EateryService
    {

        public bool CreateEatery(EateryCreate model)
        {
            Eatery food = new Eatery
            {
                EateryName = model.EateryName,
                CuisineType = model.CuisineType,
                DineIn = model.DineIn,
                Tier = ToEnum(model.Tier),
                AreaId = model.AreaId
            };
            if (food.Tier == PriceTier.None)
                return false;
            using (var fd = new ApplicationDbContext())
            {
                fd.Eateries.Add(food);
                return fd.SaveChanges() == 1;
            }
        }
        public PriceTier ToEnum(string priceTier)
        {
            PriceTier parsedPriceTier;
            if (Enum.TryParse<PriceTier>(priceTier, true, out parsedPriceTier))
            {
                return parsedPriceTier;
            }
            return PriceTier.None;
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
                       CuisineType = f.CuisineType,
                       DineIn = f.DineIn,
                       Tier = f.Tier,
                       AreaId = f.AreaId,
                   }
                   );
                return query.ToArray();
            }
        }
        public EateryDetail GetEateryById(int areaId)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food =
                    fd.Eateries.Single(f => f.EateryId == areaId);
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
        public bool DeleteEatery(int EateryId)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food =
                    fd
                    .Eateries
                    .Single(f => f.EateryId == EateryId);
                fd.Eateries.Remove(food);
                return fd.SaveChanges() == 1;
            }
        }
    }
}
