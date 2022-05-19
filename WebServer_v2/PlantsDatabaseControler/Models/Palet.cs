using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantsDatabaseControler
{
    /// <summary>
    /// Class model that holds informations about Palets
    /// </summary>
    public class Palet
    {
        [Key]
        public int PALETID { get; set; }
        public int PALETNUMBER { get; set; }
        public int PALETPLANTSTYPEID { get; set; }
        public DateTime DATEOFPLANTING { get; set; }

    }
}
