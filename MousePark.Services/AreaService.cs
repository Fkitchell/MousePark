using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class AreaService
    {
        //private readonly Guid _userId;
        //public AreaService(Guid userId) //pass in member variable and store it until it's needed
        //{
        //    _userId = userId;
        //}                                  Commenting out these lines makes it so that I do not need a userId to create an AreaService.
        public bool CreateArea(AreaCreate model)
        {
            var location =
                new Area()
                {
                    AreaName = model.AreaName
                };
            using (var loc = new ApplicationDbContext())
            {
                loc.Areas.Add(location);
                return loc.SaveChanges() == 1;
            }
        }
        public IEnumerable<AreaListItem> GetAreas()
        {
            using (var loc = new ApplicationDbContext())
            {
                var query =
                   loc.Areas
                   .Select(
                       l =>
                   new AreaListItem
                   {
                       AreaId = l.AreaId,
                       AreaName = l.AreaName,
                   }
                   );
                return query.ToArray();
            }
        }
        public AreaDetail GetAreaById(int areaId)
        {
            using (var loc = new ApplicationDbContext())
            {
                var location =
                    loc.Areas.Single(l => l.AreaId == areaId);
                return
                    new AreaDetail
                    {
                        AreaId = location.AreaId,
                        AreaName = location.AreaName,
                    };
            }
        }
        public bool UpdateArea(AreaEdit model)
        {
            using (var loc = new ApplicationDbContext())
            {
                var location =
                    loc
                    .Areas
                    .Single(l => l.AreaId == model.AreaId);
                location.AreaName = model.AreaName;

                return loc.SaveChanges() == 1;
            }
        }
        public bool DeleteArea(int AreaId)
        {
            using (var loc = new ApplicationDbContext())
            {
                var location =
                    loc
                    .Areas
                    .Single(l => l.AreaId == AreaId);
                loc.Areas.Remove(location);
                return loc.SaveChanges() == 1;
            }
        }
    }
}

