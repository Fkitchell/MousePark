using MousePark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class ShowEdit
    {
        public int ShowId { get; set; }
        public string ShowName { get; set; }
        public TargetAge TargetAge { get; set; }
        public int Capacity { get; set; }
        public int RunTime { get; set; }
        public int AreaId { get; set; }
    }
}
