using MousePark.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
   public class EateryEdit
    {
        public int EateryId { get; set; }
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Description("Name")]
        public string EateryName { get; set; }

        [Description("Cuisine Type")]
        public string CuisineType { get; set; }

        [Description("Dine-In Y / N")]
        public bool DineIn { get; set; }

        [Description("Price Tier")]
        public PriceTier Tier { get; set; }
        public int AreaId { get; set; }
    }
}
