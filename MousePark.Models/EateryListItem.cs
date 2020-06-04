using MousePark.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class EateryListItem
    {
        public int EateryId { get; set; }
        public string EateryName { get; set; }
        public string CuisineType { get; set; }
        [Description("Dine-In Y / N")]
        public bool DineIn { get; set; }
        [Description("Price Tier")]
        public PriceTier Tier { get; set; }
        public int AreaId { get; set; }
    }
}
