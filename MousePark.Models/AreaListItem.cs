﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Models
{
    public class AreaListItem
    {
        public int AreaId { get; set; }
        [Display(Name = "Area Name")]
        public string AreaName { get; set; }
        public int ParkId { get; set; }
    }
}
