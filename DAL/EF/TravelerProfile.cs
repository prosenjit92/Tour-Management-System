using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class TravelerProfile
    {
        [Key]
        public int TravelerID { get; set; }
        [Required]
        public string TravelerName { get; set; }
        [Required]
        [StringLength(11)]
        public string TravelerPhone { get; set; }

        // Add other relevant properties for a traveler
    }
}
