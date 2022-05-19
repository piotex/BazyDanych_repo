using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantsDatabaseControler
{
    /// <summary>
    /// Class model that holds informations about Palest Types
    /// </summary>
    public class PaletPlantsType
    {
        [Key]
        public int PALETPLANTSTYPEID { get; set; }
        [StringLength(20)]
        public string PALETPLANTSTYPENAME { get; set; }

    }
}
