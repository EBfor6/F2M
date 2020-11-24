using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class CrateModel
    {
        public int idCrate { get; set; }

        public string produce { get; set; }

        public string weight { get; set; }

        public string grade { get; set; }

        public int idFarmer { get; set; }
    }
}
