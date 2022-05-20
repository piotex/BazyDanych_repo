using DatabaseConneciton;
using PlantsDatabaseControler.SqlCommands.Enums;
using PlantsDatabaseControler.SqlCommands.InsertSqlCommands;
using PlantsDatabaseControler.SqlCommands.ProcedureSqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands
{
    public class ProcedureQuery
    {
        public void AddActualTasksProcedure(int paletNumber, int paletPlantsTypeId)
        {
            new ProcedureAddActualTasksQuery().PostSqlRunProcedure(paletNumber, paletPlantsTypeId);
        }

        public List<ActualTaskAllData> SelectActualTasksProcedureAllData()
        {
            string request = new ProcedureSelectActualTasksQuery().GetAllDataQuery();
            return new SqlCommand().GetSqlRequest<ActualTaskAllData>(request);
        }


        public List<ActualTaskImportantData> SelectActualTasksProcedureImportantData()
        {
            string request = new ProcedureSelectActualTasksQuery().GetImportantDataQuery();
            return new SqlCommand().GetSqlRequest<ActualTaskImportantData>(request);
        }


        public void UpdateActualTaskProcedure(int userId, int actualTaskId)
        {
            new ProcedureUpdateActualTaskQuery().PostSqlRunProcedure(userId, actualTaskId);
        }




    }
}
