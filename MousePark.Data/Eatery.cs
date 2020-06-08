using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceTier {None, Lowest, MidLow, Middle, MidHigh, High}
    public class Eatery : Attraction
    {      
        [Required]
        public string CuisineType { get; set; }
        [Required]
        [Description("Dine-In Y / N")]
        public bool DineIn { get; set; }
        [Required]
        [Description("Price Tier")]
        public PriceTier Tier { get; set; }
    }
}
