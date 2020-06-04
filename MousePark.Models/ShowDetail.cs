using MousePark.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class ShowDetail
    {
        public int ShowId { get; set; }
        [Display(Name ="Show Name")]
        public string ShowName { get; set; }
        [Display(Name ="Target Age Group")]
        public TargetAge TargetAge { get; set; }
        public int Capacity { get; set; }
        [Display(Name = "Run Time (Minutes)")]
        public int RunTime { get; set; }
        [Display(Name = "Area")]
        public int AreaId { get; set; }
    }
}
