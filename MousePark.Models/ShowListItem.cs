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
        public int ShowId { get; set; }
        [Display(Name ="Show Name")]
        public string ShowName { get; set; }
    }
}
