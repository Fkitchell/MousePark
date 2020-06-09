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
using System.Data.Entity.Core.Metadata.Edm;

namespace MousePark.Services
{
    public class EateryService
    {

        public bool CreateEatery(EateryCreate model)
        {
            Eatery food = new Eatery
            {
                Name = model.Name,
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
                       ID = f.ID,
                       Name = f.Name,
                       //CuisineType = f.CuisineType,
                       //DineIn = f.DineIn,
                       //Tier = f.Tier,
                       //AreaName = f.Area.AreaName
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
                    fd.Eateries.Single(f => f.ID == id);
                return
                    new EateryDetail
                    {
                        ID = food.ID,
                        Name = food.Name,
                        AreaName = food.Area.AreaName,
                        ParkName = food.Area.Park.ParkName
                    };
            }
        }
        public IEnumerable<EateryListItem> GetEateriesByArea(int areaId)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food = new List<EateryListItem>();
                foreach (var f in fd.Eateries)
                {
                    if (f.AreaId == areaId)
                    {
                        food.Add(new EateryListItem
                        {
                            ID = f.ID,
                            Name = f.Name,
                            //CuisineType = f.CuisineType,
                            //DineIn = f.DineIn,
                            //Tier = f.Tier,
                            //AreaName = f.Area.AreaName

                        });
                    }
                }
                return food.ToArray();
            }
        }
        public IEnumerable<EateryListItem> GetEateriesByPark(int parkId)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food = new List<EateryListItem>();
                foreach (var f in fd.Eateries.ToList())
                {
                    if (f.Area.ParkId == parkId)
                    {
                        food.Add(new EateryListItem
                        {
                            ID = f.ID,
                            Name = f.Name,
                        });
                    }
                }
                    return food.ToArray();
            }
        }
        public bool UpdateEatery(EateryEdit model)
        {
            using (var fd = new ApplicationDbContext())
            {
                var food =
                    fd
                    .Eateries
                    .Single(f => f.ID == model.ID);
                food.Name = model.Name;
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
                    .Single(f => f.ID == id);
                fd.Eateries.Remove(food);
                return fd.SaveChanges() == 1;
            }
        }
    }
}
