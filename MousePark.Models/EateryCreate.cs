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
    public class EateryCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Description("Name")]
        public string Name { get; set; }
        [Required]
        [Description("Cuisine Type")]
        public string CuisineType { get; set; }
        [Required]
        [Description("Dine-In Y / N")]
        public bool DineIn { get; set; }
        [Required]
        [Description("Price Tier")]
        public PriceTier Tier { get; set; }
        public int AreaId { get; set; }
    }
}
