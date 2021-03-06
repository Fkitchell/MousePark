﻿using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class ShowService
    {
        public bool CreateShow(ShowCreate model)
        {
            Show show = new Show
            {
                Name = model.Name,
                TargetAge = model.TargetAge,
                Capacity = model.Capacity,
                RunTime = model.RunTime,
                AreaId = model.AreaId,
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shows.Add(show);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ShowListItem> GetShows()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Shows
                    .ToList();
                List<ShowListItem> Result = new List<ShowListItem>();
                foreach (Show e in query)
                {
                    ShowListItem show = new ShowListItem
                    {
                        ID = e.ID,
                        Name = e.Name,
                        AverageScore = e.AverageScore
                    };
                    Result.Add(show);
                }
                return Result;
            }
        }
        public ShowDetail GetShowById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Show show = ctx.Shows.Single(e => e.ID == id);
                return new ShowDetail
                {
                    ID = show.ID,
                    Name = show.Name,
                    TargetAge = show.TargetAge,
                    Capacity = show.Capacity,
                    RunTime = show.RunTime,
                    AreaName = show.Area.AreaName,
                    ParkName = show.Area.Park.ParkName,
                    AverageScore = show.AverageScore
                };
            }
        }
        public IEnumerable<ShowListItem> GetShowsByArea(int areaId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var items = new List<ShowListItem>();
                foreach (var e in ctx.Shows)
                {
                    if (e.AreaId == areaId)
                    {
                        items.Add(new ShowListItem
                        {
                            ID = e.ID,
                            Name = e.Name
                        });
                    }
                }
                return items.ToArray();
            }
        }
        public IEnumerable<ShowListItem> GetShowsByPark(int parkId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var items = new List<ShowListItem>();
                foreach (var e in ctx.Shows.ToList())
                {
                    if (e.Area.ParkId == parkId)
                    {
                        items.Add(new ShowListItem
                        {
                            ID = e.ID,
                            Name = e.Name
                        });
                    }
                }
                return items.ToArray();
            }
        }
        public bool UpdateShow(ShowEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Show show = ctx.Shows.Single(e => e.ID == model.ID);

                show.Name = model.Name;
                show.TargetAge = model.TargetAge;
                show.Capacity = model.Capacity;
                show.RunTime = model.RunTime;
                show.AreaId = model.AreaId;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteShow(int showId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Show show = ctx.Shows.Single(e => e.ID == showId);
                ctx.Shows.Remove(show);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
