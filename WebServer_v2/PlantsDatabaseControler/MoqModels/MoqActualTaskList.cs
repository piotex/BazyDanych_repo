using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqActualTaskList : BaseMoqList<ActualTask>
    {
        private static MoqActualTaskList _instance;
        public static MoqActualTaskList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqActualTaskList();
                _data = new List<ActualTask>()
                {
                    new ActualTask(){ACTUALTASKID= 1, CARESCHEDULEID= 1, PALETID= 1, REALIZATIONDATE= DateTime.Now.AddHours(-5), USERID= 1},
                    new ActualTask(){ACTUALTASKID= 2, CARESCHEDULEID= 3, PALETID= 2, REALIZATIONDATE= null, USERID= null},
                    new ActualTask(){ACTUALTASKID= 3, CARESCHEDULEID= 4, PALETID= 3, REALIZATIONDATE= null, USERID= null},
                    new ActualTask(){ACTUALTASKID= 4, CARESCHEDULEID= 2, PALETID= 4, REALIZATIONDATE= null, USERID= null},
                    new ActualTask(){ACTUALTASKID= 5, CARESCHEDULEID= 6, PALETID= 5, REALIZATIONDATE= null, USERID= null},
                    new ActualTask(){ACTUALTASKID= 6, CARESCHEDULEID= 3, PALETID= 6, REALIZATIONDATE= null, USERID= null},
                    new ActualTask(){ACTUALTASKID= 7, CARESCHEDULEID= 2, PALETID= 7, REALIZATIONDATE= null, USERID= null},
                    new ActualTask(){ACTUALTASKID= 8, CARESCHEDULEID= 7, PALETID= 8, REALIZATIONDATE= null, USERID= null},
                    new ActualTask(){ACTUALTASKID= 9, CARESCHEDULEID= 2, PALETID= 9, REALIZATIONDATE= null, USERID= null},
                };
            }
            return _instance;
        }
        static MoqActualTaskList()
        {

        }
    }
}
