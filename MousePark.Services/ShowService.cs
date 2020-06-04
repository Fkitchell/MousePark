using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
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
                ShowName = model.ShowName,
                TargetAge = model.TargetAge,
                Capacity = model.Capacity,
                RunTime = model.RunTime,
                AreaId = model.AreaId
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
                List<ShowListItem> items = new List<ShowListItem>();
                //foreach (var e in ctx.Shows)
                //{
                //    items.Add(new ShowListItem
                //    {
                //        ShowId = e.ShowId,
                //        ShowName = e.ShowName     
                //    });
                //}
                //return items.ToArray();
                //Below is simply shorthand for above.

                var query = ctx.Shows.Select(
                    e => new ShowListItem
                    {
                        ShowId = e.ShowId,
                        ShowName = e.ShowName
                    }
                    );
                return query.ToArray();
            }
        }
        public ShowDetail GetShowById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Show show = ctx.Shows.Single(e => e.ShowId == id);
                return new ShowDetail
                {
                    ShowId = show.ShowId,
                    ShowName = show.ShowName,
                    TargetAge = show.TargetAge,
                    Capacity = show.Capacity,
                    RunTime = show.RunTime,
                    AreaId = show.AreaId
                };
            }
        }
        public bool UpdateShow(ShowEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Show show = ctx.Shows.Single(e => e.ShowId == model.ShowId);

                show.ShowName = model.ShowName;
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
                Show show = ctx.Shows.Single(e => e.ShowId == showId);
                ctx.Shows.Remove(show);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
