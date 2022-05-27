using DatabaseConneciton;
using PlantsDatabaseControler.SqlCommands.InsertSqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands
{
    public class UpdateQuery
    {
        public void Update(object model)
        {
            string request = _getRequest(model);
            if (request != "" && request.ToLower().Contains("update"))
            {
                new SqlCommand().PostSqlRequest(request);
            }
        }

        private string _getRequest(object model)
        {
            if (model.GetType() == typeof(ActualTask) && ((ActualTask)model).USERID != null && ((ActualTask)model).REALIZATIONDATE == null)
            {
                return new UpdateUserIdActualTaskQuery().GetUpdateQuery((ActualTask)model);
            }
            if (model.GetType() == typeof(ActualTask) && ((ActualTask)model).USERID == null && ((ActualTask)model).REALIZATIONDATE != null)
            {
                return new UpdateRealizationDateActualTaskQuery().GetUpdateQuery((ActualTask)model);
            }
            return "";
        }
    }
}
