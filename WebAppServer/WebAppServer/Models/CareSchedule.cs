﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppServer.Models
{
    /// <summary>
    /// Class model that holds values about Care Shedule
    /// </summary>
    public class CareSchedule
    {
        [Key]
        public int CareScheduleId { get; set; }
        public int TypeOfCare_Id { get; set; }
        public DateTime TimeOfCare { get; set; }
        public int PaletPlantsType_Id { get; set; }
        public int PriorityNumber { get; set; }
    }
}
