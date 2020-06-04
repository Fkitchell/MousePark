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
    public enum RideType {[Description("Roller Coaster")] RollerCoaster, Water, Gentle, Thrill, Transportation, Kiddie }
    public class Ride
    {
        [Key]
        public Guid RideId { get; set; }
        [Required]
        [Display(Name = "Name of Ride")]
        public string RideName { get; set; }
        [Required]
        [Display(Name = "Description of Ride")]
        public string RideDescription { get; set; }
        [Required]
        [Display(Name = "Minimum Height to Ride (Inches)")]

        public int HeightReq { get; set; }
        [Required]
        [Display(Name = "Type of Ride")]
        public RideType RideType { get; set; }
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
    }
}
