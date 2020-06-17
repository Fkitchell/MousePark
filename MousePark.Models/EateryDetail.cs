using MousePark.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class EateryDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CuisineType { get; set; }
        [Description("Dine-In Y / N")]
        public bool DineIn { get; set; }
        [Description("Price Tier")]
        public PriceTier Tier { get; set; }
        public string AreaName { get; set; }
        public string ParkName { get; set; }
        public double AverageScore { get; set; }
    }
}
