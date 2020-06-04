using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Data
{
    public enum TargetAge { Child, Teen, Adult, All }
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
        [Required]
        public string ShowName { get; set; }
        [Required]
        public TargetAge TargetAge { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int RunTime { get; set; }
        [ForeignKey("Area")]
        [Required]
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
    }
}
