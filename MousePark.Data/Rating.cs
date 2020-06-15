
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Data
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        [Range(1, 5, ErrorMessage = "Value must be between 1 & 5.")]
        [Required]
        public int Score { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("Ride")]
        public int? RideId { get; set; }
        public virtual Ride Ride { get; set; }

        [ForeignKey("Eatery")]
        public int? EateryId { get; set; }
        public virtual Eatery Eatery { get; set; }

        [ForeignKey("Show")]
        public int? ShowId { get; set; }
        public virtual Show Show { get; set; }
    }
}
