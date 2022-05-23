using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqUserCategoryList : BaseMoqList<UserCategory>
    {
        private static MoqUserCategoryList _instance;
        public static MoqUserCategoryList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqUserCategoryList();
                _data = new List<UserCategory>()
                {
                    new UserCategory(){USERCATEGORYID=-1,USERCATEGORYNAME="unemployed"},
                    new UserCategory(){USERCATEGORYID=0,USERCATEGORYNAME="admin"},
                    new UserCategory(){USERCATEGORYID=1,USERCATEGORYNAME="manager"},
                    new UserCategory(){USERCATEGORYID=2,USERCATEGORYNAME="worker"},
                };
            }
            return _instance;
        }
        static MoqUserCategoryList()
        {

        }
    }
}


