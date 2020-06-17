using MousePark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class RideListItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
       // public RideType RideType { get; set; }
        public double AverageScore { get; set; }
    }
}
