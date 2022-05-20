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
    public class ProcedureAddActualTasksQuery : SqlCommand
    {
        public void PostSqlRunProcedure(int paletNumber, int paletPlantsTypeId)
        {
            using (OracleConnection objConn = new OracleConnection(GetConectionString()))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "AddActualTasks";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("dateOfPlanting", OracleDbType.Date).Value = DateTime.Now;
                objCmd.Parameters.Add("paletNumber", OracleDbType.Int32).Value = paletNumber;
                objCmd.Parameters.Add("paletPlantsTypeIDdd", OracleDbType.Int32).Value = paletPlantsTypeId;
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
        public virtual string GetExecProcedureQuery(int paletNumber, int paletPlantsTypeId)
        {
            return "begin AddActualTasks(sysdate, 3199, 1);  end; ";
            return string.Format("exec AddActualTasks(sysdate, {0}, {1}) ", paletNumber, paletPlantsTypeId);
        }
        */
        /*
        public virtual string GetBuildProcedureQuery()
        {
            return "CREATE OR REPLACE PROCEDURE AddActualTasks( " +
                            " dateOfPlanting Date, paletNumber NUMBER, paletPlantsTypeIDdd NUMBER " +
                    " ) " +
                    " as " +
                    " BEGIN " +
                        " DECLARE " +
                        " CURSOR c_product " +
                        " IS " +
                            " SELECT CareScheduleID, PaletPlantsTypeID FROM CareSchedule WHERE PaletPlantsTypeID = paletPlantsTypeIDdd; " +
                        " BEGIN " +
                            " FOR r_product IN c_product " +
                            " LOOP " +
                                " INSERT INTO ActualTask(PaletID, CareScheduleID) VALUES(paletNumber, r_product.CareScheduleID); " +
                            " END LOOP; " +
                        " END; " +
                        " INSERT INTO Palet(DateOfPlanting, PaletNumber, PaletPlantsTypeID) VALUES(dateOfPlanting, paletNumber, paletPlantsTypeIDdd); " +
                        " COMMIT; " +
                    " END AddActualTasks ";
        }
        */
    }
}
