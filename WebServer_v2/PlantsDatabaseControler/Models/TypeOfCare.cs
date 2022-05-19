using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantsDatabaseControler
{
    /// <summary>
    /// Class model that holds informations about Types of Care
    /// </summary>
    public class TypeOfCare
    {
        [Key]
        public int TYPEOFCAREID { get; set; }
        [StringLength(20)]
        public string TYPEOFCARENAME { get; set; }
    }
}
