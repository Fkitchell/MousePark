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
        [Required]
        public int RatingId { get; set; }
        [Range (1,5, ErrorMessage = "Value must be between 1 & 5.")]
        [Required]
        public int Score { get; set; }
        //public string Comment { get; set; }


        public int ID { get; set; }
        public virtual Eatery Eatery { get; set; }
    }
}
