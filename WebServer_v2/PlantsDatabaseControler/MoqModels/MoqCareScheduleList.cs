using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqCareScheduleList : BaseMoqList<CareSchedule>
    {
        private static MoqCareScheduleList _instance;
        public static MoqCareScheduleList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqCareScheduleList();
                _data = new List<CareSchedule>()
                {
                    new CareSchedule(){ CARESCHEDULEID=1, TIMEOFCARE=5,  PALETPLANTSTYPEID=1, PRIORITYNUMBER=5, TYPEOFCAREID=1 },
                    new CareSchedule(){ CARESCHEDULEID=2, TIMEOFCARE=7,  PALETPLANTSTYPEID=1, PRIORITYNUMBER=2, TYPEOFCAREID=2 },
                    new CareSchedule(){ CARESCHEDULEID=3, TIMEOFCARE=7,  PALETPLANTSTYPEID=1, PRIORITYNUMBER=2, TYPEOFCAREID=3 },
                    new CareSchedule(){ CARESCHEDULEID=4, TIMEOFCARE=10, PALETPLANTSTYPEID=1, PRIORITYNUMBER=2, TYPEOFCAREID=5 },
                    new CareSchedule(){ CARESCHEDULEID=5, TIMEOFCARE=15, PALETPLANTSTYPEID=1, PRIORITYNUMBER=2, TYPEOFCAREID=4 },
                    new CareSchedule(){ CARESCHEDULEID=6, TIMEOFCARE=3,  PALETPLANTSTYPEID=2, PRIORITYNUMBER=2, TYPEOFCAREID=6 },
                    new CareSchedule(){ CARESCHEDULEID=7, TIMEOFCARE=17, PALETPLANTSTYPEID=2, PRIORITYNUMBER=3, TYPEOFCAREID=2 },
                    new CareSchedule(){ CARESCHEDULEID=8, TIMEOFCARE=88, PALETPLANTSTYPEID=3, PRIORITYNUMBER=2, TYPEOFCAREID=1 },
                    new CareSchedule(){ CARESCHEDULEID=9, TIMEOFCARE=72, PALETPLANTSTYPEID=4, PRIORITYNUMBER=2, TYPEOFCAREID=3 },
                    new CareSchedule(){ CARESCHEDULEID=10,TIMEOFCARE=25, PALETPLANTSTYPEID=5, PRIORITYNUMBER=1, TYPEOFCAREID=5 },
                };
            }
            return _instance;
        }
        static MoqCareScheduleList()
        {

        }
    }
}




