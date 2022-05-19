using DatabaseConneciton;
using PlantsDatabaseControler.SqlCommands.InsertSqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands
{
    public class InsertQuery
    {
        public void Insert(object model)
        {
            string request = _getRequest(model);
            if (request != "" && request.ToLower().Contains("insert"))
            {
                new SqlCommand().PostSqlRequest(request);
            }
        }

        private string _getRequest(object model)
        {
            if (model.GetType() == typeof(CareSchedule))
            {
                return new InsertCareScheduleQuery().GetInsertQuery((CareSchedule)model);
            }
            if (model.GetType() == typeof(Company))
            {
                return new InsertCompanyQuery().GetInsertQuery((Company)model);
            }
            if (model.GetType() == typeof(InsertPaletPlantsTypeQuery))
            {
                return new InsertPaletPlantsTypeQuery().GetInsertQuery((PaletPlantsType)model);
            }
            if (model.GetType() == typeof(InsertPaletQuery))
            {
                return new InsertPaletQuery().GetInsertQuery((Palet)model);
            }
            if (model.GetType() == typeof(InsertTypeOfCareQuery))
            {
                return new InsertTypeOfCareQuery().GetInsertQuery((TypeOfCare)model);
            }
            if (model.GetType() == typeof(InsertUserCategoryQuery))
            {
                return new InsertUserCategoryQuery().GetInsertQuery((UserCategory)model);
            }
            if (model.GetType() == typeof(InsertUsersQuery))
            {
                return new InsertUsersQuery().GetInsertQuery((Users)model);
            }
            return "";
        }
    }
}
