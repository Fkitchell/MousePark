using MousePark.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class RideCreate
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Ride name is too long.")]
        public string Name { get; set; }
        [Required]
        [MaxLength(5000)]
        public string RideDescription { get; set; }
        [Required]
        public int HeightReq { get; set; }
        [Required]
        public RideType RideType { get; set; }
        [Required]
        public int AreaId { get; set; }       
    }
}
