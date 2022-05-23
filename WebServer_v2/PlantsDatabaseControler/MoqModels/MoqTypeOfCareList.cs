using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqTypeOfCareList : BaseMoqList<TypeOfCare>
    {
        private static MoqTypeOfCareList _instance;
        public static MoqTypeOfCareList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqTypeOfCareList();
                _data = new List<TypeOfCare>()
                {
                    new TypeOfCare(){TYPEOFCAREID=1,TYPEOFCARENAME="podlewanie"},
                    new TypeOfCare(){TYPEOFCAREID=2,TYPEOFCARENAME="przycinanie"},
                    new TypeOfCare(){TYPEOFCAREID=3,TYPEOFCARENAME="plewienie"},
                    new TypeOfCare(){TYPEOFCAREID=4,TYPEOFCARENAME="oprysl"},
                    new TypeOfCare(){TYPEOFCAREID=5,TYPEOFCARENAME="naworzenie"},
                    new TypeOfCare(){TYPEOFCAREID=6,TYPEOFCARENAME="przegląd"},
                    new TypeOfCare(){TYPEOFCAREID=7,TYPEOFCARENAME="sprzedaż"},
                };
            }
            return _instance;
        }
        static MoqTypeOfCareList()
        {

        }
    }
}
