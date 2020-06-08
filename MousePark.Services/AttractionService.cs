using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class AttractionService
    {
        public IEnumerable<AttractionListAll> GetAttractions()
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<AttractionListAll> items = new List<AttractionListAll>();
                foreach (var e in ctx.Shows)
                {
                    items.Add(new AttractionListAll
                    {
                        AttractionType = AttractionType.Show,
                        ID = e.ID,
                        Name = e.Name,
                        ParkName = e.Park.ParkName,
                        AreaName = e.Area.AreaName
                    });
                }
                foreach (var e in ctx.Rides)
                {
                    items.Add(new AttractionListAll
                    {
                        AttractionType = AttractionType.Ride,
                        ID = e.ID,
                        Name = e.Name,
                        ParkName = e.Park.ParkName,
                        AreaName = e.Area.AreaName
                    });
                }
                foreach (var e in ctx.Eateries)
                {
                    items.Add(new AttractionListAll
                    {
                        AttractionType = AttractionType.Eatery,
                        ID = e.ID,
                        Name = e.Name,
                        ParkName = e.Park.ParkName,
                        AreaName = e.Area.AreaName
                    });
                }
                return items.ToArray();
            }
        }
        public IEnumerable<AttractionListItem> GetAttractionsByArea(int areaId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<AttractionListItem> items = new List<AttractionListItem>();
                foreach (var e in ctx.Shows)
                {
                    if (e.AreaId == areaId)
                    {
                        items.Add(new AttractionListItem
                        {
                            AttractionType = AttractionType.Show,
                            ID = e.ID,
                            Name = e.Name
                        });
                    }
                }
                foreach (var e in ctx.Rides)
                {
                    if (e.AreaId == areaId)
                    {
                        items.Add(new AttractionListItem
                        {
                            AttractionType = AttractionType.Ride,
                            ID = e.ID,
                            Name = e.Name,
                        });
                    }
                }
                foreach (var e in ctx.Eateries)
                {
                    if (e.AreaId == areaId)
                    {
                        items.Add(new AttractionListItem
                        {
                            AttractionType = AttractionType.Eatery,
                            ID = e.ID,
                            Name = e.Name
                        });
                    }
                }
                return items.ToArray();
            }
        }
        public IEnumerable<AttractionListItem> GetAttractionsByPark(int parkId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<AttractionListItem> items = new List<AttractionListItem>();
                foreach (var e in ctx.Shows)
                {
                    if (e.AreaId == parkId)
                    {
                        items.Add(new AttractionListItem
                        {
                            AttractionType = AttractionType.Show,
                            ID = e.ID,
                            Name = e.Name
                        });
                    }
                }
                foreach (var e in ctx.Rides)
                {
                    if (e.AreaId == parkId)
                    {
                        items.Add(new AttractionListItem
                        {
                            AttractionType = AttractionType.Ride,
                            ID = e.ID,
                            Name = e.Name,
                        });
                    }
                }
                foreach (var e in ctx.Eateries)
                {
                    if (e.AreaId == parkId)
                    {
                        items.Add(new AttractionListItem
                        {
                            AttractionType = AttractionType.Eatery,
                            ID = e.ID,
                            Name = e.Name
                        });
                    }
                }
                return items.ToArray();
            }
        }
    }
}
