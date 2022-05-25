using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqUsersList : BaseMoqList<Users>
    {
        private static MoqUsersList _instance;
        public static MoqUsersList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqUsersList();
                _data = new List<Users>()
                {
                    new Users(){USERSID= 0,BIRTHDAY=DateTime.Today.AddDays(-365*20),COMPANYID= 1,NAME="Admin", LASTNAME= "Adminowicz",MAIL="admin",PHONE="721545820",USERCATEGORYID=0},
                    new Users(){USERSID= 1,BIRTHDAY=DateTime.Today.AddDays(-365*20),COMPANYID= 1,NAME="Peter", LASTNAME= "Tomaszkiewicz",MAIL="pkubon@gmail.com",PHONE="721545820",USERCATEGORYID=2},
                    new Users(){USERSID= 2,BIRTHDAY=DateTime.Now.AddDays(-365*20),COMPANYID= 1,NAME="Tomasz",LASTNAME= "Latus",        MAIL="tomasz@gmail.com",PHONE="123123123",USERCATEGORYID=1},
                    new Users(){USERSID= 3,BIRTHDAY=DateTime.Now.AddDays(-365*22),COMPANYID= 1,NAME="Kuba",  LASTNAME= "Jankowski",    MAIL="kuba@gmail.com",  PHONE="777555777",USERCATEGORYID=2},
                    new Users(){USERSID= 4,BIRTHDAY=DateTime.Now.AddDays(-365*50),COMPANYID= 2,NAME="Elon",  LASTNAME= "Musk",         MAIL="musk@gmail.com",  PHONE="222000999",USERCATEGORYID=1},
                };
            }
            return _instance;
        }
        static MoqUsersList()
        {

        }
    }
}


