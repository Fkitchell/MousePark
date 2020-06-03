using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class ParkListItem
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public double AdmissionPrice { get; set; }
    }
}
