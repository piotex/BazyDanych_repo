using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantsDatabaseControler
{
    /// <summary>
    /// Class model that holds values about actual and done tasks
    /// </summary>
    public class ActualTask
    {
        [Key]
        public int ACTUALTASKID { get; set; }
        public DateTime? REALIZATIONDATE { get; set; }               
        public int PALETID { get; set; }
        public int? USERID { get; set; }                            // id usera który wykonal zadanie
        public int CARESCHEDULEID { get; set; }

    }
}
