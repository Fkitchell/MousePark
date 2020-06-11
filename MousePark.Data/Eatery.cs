using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceTier { Low = 1, MidLow, Middle, MidHigh, High }
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
        public double AverageScore
        {
            get
            {
                if (Ratings.Count == 0)
                {
                    return 0;
                }
                return Ratings.Select(r => r.Score).Average();
            }

        }
        public virtual ICollection<Rating> Ratings { get; set; }


    }
}

