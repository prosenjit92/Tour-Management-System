using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Tour
    {
        [Key]
        public int TourID { get; set; }
        [Required]
        public string TourLocation { get; set; }
    }
}
