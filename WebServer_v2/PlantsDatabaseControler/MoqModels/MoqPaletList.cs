using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqPaletList : BaseMoqList<Palet>
    {
        private static MoqPaletList _instance;

        public static MoqPaletList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqPaletList();
                _data = new List<Palet>()
                {
                    new Palet(){PALETID=1, PALETNUMBER=1155, PALETPLANTSTYPEID=1, DATEOFPLANTING=DateTime.Now.AddDays(-7*2)},
                    new Palet(){PALETID=2, PALETNUMBER=2255, PALETPLANTSTYPEID=1, DATEOFPLANTING=DateTime.Now.AddDays(-7*3)},
                    new Palet(){PALETID=3, PALETNUMBER=3355, PALETPLANTSTYPEID=2, DATEOFPLANTING=DateTime.Now.AddDays(-7*4)},
                    new Palet(){PALETID=4, PALETNUMBER=1222, PALETPLANTSTYPEID=3, DATEOFPLANTING=DateTime.Now.AddDays(-7*5)},
                    new Palet(){PALETID=5, PALETNUMBER=5888, PALETPLANTSTYPEID=3, DATEOFPLANTING=DateTime.Now.AddDays(-7*6)},
                    new Palet(){PALETID=6, PALETNUMBER=1354, PALETPLANTSTYPEID=4, DATEOFPLANTING=DateTime.Now.AddDays(-7*7)},
                    new Palet(){PALETID=7, PALETNUMBER=9988, PALETPLANTSTYPEID=4, DATEOFPLANTING=DateTime.Now.AddDays(-7*15)},
                };
            }
            return _instance;
        }
        static MoqPaletList()
        {

        }
    }
}
