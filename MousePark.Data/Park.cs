﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MousePark.Data
{
    public class Park
    {
        [Key]
        public int ParkId { get; set; }
        [Required]
        [Display(Name = "Name of Park")]
        public string  ParkName { get; set; }
        [Required]
        [Display(Name = "Admission Price")]
        public double AdmissionPrice { get; set; }
    }
}
