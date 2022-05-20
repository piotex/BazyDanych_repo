using DatabaseConneciton;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands.ProcedureSqlCommands
{
    public class ProcedureUpdateActualTaskQuery : SqlCommand
    {
        public void PostSqlRunProcedure(int userIDd, int taskIDd)
        {
            using (OracleConnection objConn = new OracleConnection(GetConectionString()))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "UpdateActualTask";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("taskIDd", OracleDbType.Int32).Value = taskIDd;
                objCmd.Parameters.Add("userIDd", OracleDbType.Int32).Value = userIDd;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw;
                }
                objConn.Close();
            }
        }
        /*
        public virtual string GetExecProcedureQuery(int userId, int actualTaskId)
        {
            return string.Format("exec UpdateActualTask({0}, {1});", actualTaskId, userId);
        }
        public virtual string GetBuildProcedureQuery()
        {
            return "CREATE OR REPLACE PROCEDURE UpdateActualTask( taskIDd NUMBER, userIDd NUMBER ) " +
                    " as" +
                    " BEGIN " +
                        " UPDATE ActualTask SET RealizationDate = sysdate, UserID= userIDd WHERE ActualTaskID = taskIDd; " +
                        " COMMIT; " +
                    " END ";
        }
        */
    }
}
