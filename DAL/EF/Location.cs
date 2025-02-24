﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [Required]
        public string LocationName { get; set; }
        [Required]
        [ForeignKey("TourGuide")]
        public int GuideID { get; set; }

        // Navigation property
        public virtual TourGuide TourGuide { get; set; }
    }
}
