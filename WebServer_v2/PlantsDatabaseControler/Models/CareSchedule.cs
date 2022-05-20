using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantsDatabaseControler
{
    /// <summary>
    /// Class model that holds values about Care Shedule
    /// </summary>
    public class CareSchedule
    {
        [Key]
        public int CARESCHEDULEID { get; set; }
        public int TYPEOFCAREID { get; set; }
        public int TIMEOFCARE { get; set; }
        public int PALETPLANTSTYPEID { get; set; }
        public int PRIORITYNUMBER { get; set; }

        
    }
}
