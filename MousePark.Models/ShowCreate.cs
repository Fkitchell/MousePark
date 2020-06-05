using MousePark.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class ShowCreate
    {
        [Required]
        public string ShowName { get; set; }
        public string TargetAge { get; set; }
        public int Capacity { get; set; }
        public int RunTime { get; set; }
        [Required]
        public int AreaId { get; set; }
    }
}
