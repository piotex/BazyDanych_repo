using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantsDatabaseControler
{
    /// <summary>
    /// Class model that holds informations about Companies
    /// </summary>
    public class Company
    {
        [Key]
        public int COMPANYID { get; set; }
        [StringLength(20)]
        public string COMPANYNAME { get; set; }

    }
}
