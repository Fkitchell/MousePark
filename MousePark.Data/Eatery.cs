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
    public class Eatery
    {
        [Key]
        public int EateryId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string EateryName { get; set; }
        [Required]
        public string CuisineType { get; set; }
        [Required]
        [Description("Dine-In Y / N")]
        public bool DineIn { get; set; }
        [Required]
        [Description("Price Tier")]
        public PriceTier Tier { get; set; }

        [ForeignKey("Area")]
        [Required]
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
    }
}
