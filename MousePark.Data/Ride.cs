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
    public enum RideType {[Description("Roller Coaster")] RollerCoaster=1, Water, Gentle, Thrill, Transportation, Kiddie }
    public class Ride : Attraction
    {
        [Required]
        [Display(Name = "Description of Ride")]
        public string RideDescription { get; set; }
        [Required]
        [Display(Name = "Minimum Height to Ride (Inches)")]

        public int HeightReq { get; set; }
        [Required]
        [Display(Name = "Type of Ride")]
        public RideType RideType { get; set; }
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
