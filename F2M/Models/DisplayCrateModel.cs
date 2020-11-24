using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F2M.Models
{
    public class DisplayCrateModel
    {

        [Required]
        public int idFarmer { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please enter the produce of the crate")]
        public string produce { get; set; }

        [Required]
        public string weight { get; set; }

        [Required]
        public string grade { get; set; }

        

    }
}
