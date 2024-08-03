using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TravelerProfileDTO
    {
        public int TravelerID { get; set; }
        [Required]
        public string TravelerName { get; set; }
        
        public string TravelerPhone { get; set; }

    }
}
