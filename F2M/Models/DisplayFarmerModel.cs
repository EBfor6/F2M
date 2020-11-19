using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F2M.Models
{
    public class DisplayFarmerModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "First name is too long.")]
        [MinLength(2, ErrorMessage = "First name is too short.")]
        public string firstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Last name is too long.")]
        [MinLength(2, ErrorMessage = "Last name is too short.")]
        public string lastName { get; set; }

        [Required]
        public string phoneNumber { get; set; }
    }
}
