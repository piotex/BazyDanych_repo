using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqPaletPlantsTypeList : BaseMoqList<PaletPlantsType>
    {
        private static MoqPaletPlantsTypeList _instance;
        public static MoqPaletPlantsTypeList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqPaletPlantsTypeList();
                _data = new List<PaletPlantsType>()
                {
                    new PaletPlantsType(){PALETPLANTSTYPEID=1,PALETPLANTSTYPENAME="kawowiec"},
                    new PaletPlantsType(){PALETPLANTSTYPEID=2,PALETPLANTSTYPENAME="chmiel"},
                    new PaletPlantsType(){PALETPLANTSTYPEID=3,PALETPLANTSTYPENAME="kaktus"},
                    new PaletPlantsType(){PALETPLANTSTYPEID=4,PALETPLANTSTYPENAME="tulipan"},
                    new PaletPlantsType(){PALETPLANTSTYPEID=5,PALETPLANTSTYPENAME="jabłoń"},
                    new PaletPlantsType(){PALETPLANTSTYPEID=6,PALETPLANTSTYPENAME="wiśnia"},
                };
            }
            return _instance;
        }
        static MoqPaletPlantsTypeList()
        {

        }
    }
}
