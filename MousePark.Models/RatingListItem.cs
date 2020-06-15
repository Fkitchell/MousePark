using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class RatingListItem
    {
        public int RatingId { get; set; }
        public int Score { get; set; }
        public Guid UserId { get; set; }
        public int? EateryId { get; set; }
        public int? RideId { get; set; }
        public int? ShowId { get; set; }
    }
}
