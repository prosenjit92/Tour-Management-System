using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class TourGuide
    {
        [Key]
        public int GuideID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Uname { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }      

    }
}

