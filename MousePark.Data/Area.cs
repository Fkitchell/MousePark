using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Data
{
    public class Area
    {
       [Key]
        public int AreaId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Area Name")]
        public string AreaName { get; set; }

        [ForeignKey("Park")]
        [Required]
        public int ParkId { get; set; }
        public virtual Park Park { get; set; } 

     
    }
}
