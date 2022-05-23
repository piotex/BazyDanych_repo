using System;
using System.Collections.Generic;

namespace PlantsDatabaseControler.MoqModels
{
    public class MoqCompanyList : BaseMoqList<Company>
    {
        private static MoqCompanyList _instance;
        public static MoqCompanyList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MoqCompanyList(); 
                _data = new List<Company>()
                {
                    new Company(){COMPANYID=1,COMPANYNAME="Capgemini"},
                    new Company(){COMPANYID=2,COMPANYNAME="BTS"},
                    new Company(){COMPANYID=3,COMPANYNAME="Google"},
                    new Company(){COMPANYID=4,COMPANYNAME="PWr"},
                };
            }
            return _instance;
        }
        static MoqCompanyList()
        {
            
        }
    }
}
