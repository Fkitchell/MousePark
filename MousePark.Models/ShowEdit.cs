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
        public int ID { get; set; }
        public string Name { get; set; }
        public TargetAge TargetAge { get; set; }
        public int Capacity { get; set; }
        public int RunTime { get; set; }
        public int AreaId { get; set; }
       // public int ParkId { get; set; }
    }
}
