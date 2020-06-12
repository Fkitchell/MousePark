using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class ShowListItem
    {
        public int ID { get; set; }
        [Display(Name ="Show Name")]
        public string Name { get; set; }
        public double AverageScore { get; set; }
    }
}
