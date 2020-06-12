using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TargetAge { Child = 1, Teen, Adult, All }
    public class Show : Attraction
    {
        [Required]
        public TargetAge TargetAge { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int RunTime { get; set; }
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
