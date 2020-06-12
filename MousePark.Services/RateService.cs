using MousePark.Data;
using MousePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Services
{
    public class RateService
    {public bool CreateRate(RateCreate model)
        {
            Rate rate = new Rate
            {
                Score = model.Score,
                EateryId = model.EateryId,
            };
            using (var e = new ApplicationDbContext())
            {
                e.Rates.Add(rate);
                return e.SaveChanges() == 1;
            }
        }
    }
}
