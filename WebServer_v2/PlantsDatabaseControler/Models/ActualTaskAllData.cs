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
    public class ActualTaskAllData
    {
        [Key]
        public int ACTUALTASKID { get; set; }
        public DateTime? REALIZATIONDATE { get; set; }               
        public int PALETID { get; set; }
        public int? USERID { get; set; }                          
        public int CARESCHEDULEID { get; set; }
        public int CARESCHEDULEID_1 { get; set; }
        public int TYPEOFCAREID { get; set; }
        public int TIMEOFCARE { get; set; }
        public int PALETPLANTSTYPEID { get; set; }
        public int PRIORITYNUMBER { get; set; }
        public int PALETPLANTSTYPEID_1 { get; set; }
        public string PALETPLANTSTYPENAME { get; set; }
        public int TYPEOFCAREID_1 { get; set; }
        public string TYPEOFCARENAME { get; set; }
        public int PALETID_1 { get; set; }
        public int PALETNUMBER { get; set; }
        public int PALETPLANTSTYPEID_2 { get; set; }
        public DateTime DATEOFPLANTING { get; set; }

    }
}
