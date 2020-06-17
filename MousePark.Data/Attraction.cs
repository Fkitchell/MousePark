using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MousePark.Data
{
    public class Attraction
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
       
        [ForeignKey("Area")]
        [Required]
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
    }
}
