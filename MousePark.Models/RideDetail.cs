using MousePark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class RideDetail
    {
        public string Name { get; set; }
        public string RideDescription { get; set; }
        public int HeightReq { get; set; }
        public RideType RideType { get; set; }
        public string AreaName { get; set; }
        public string ParkName { get; set; }
        public double AverageScore { get; set; }
    }
}
