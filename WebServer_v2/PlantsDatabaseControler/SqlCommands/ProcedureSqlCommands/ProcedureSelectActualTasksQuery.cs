using DatabaseConneciton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands.ProcedureSqlCommands
{
    public class ProcedureSelectActualTasksQuery : SqlCommand
    {
        public virtual string GetAllDataQuery()
        {
            return "Select ActualTask.* , careschedule.* , paletplantstype.* , TypeOfCare.*, Palet.* "+
                    " From ActualTask " +
                    " INNER JOIN careschedule ON actualtask.carescheduleid = careschedule.carescheduleid " +
                    " INNER JOIN paletplantstype ON paletplantstype.paletplantstypeid = careschedule.paletplantstypeid " +
                    " INNER JOIN TypeOfCare ON typeofcare.typeofcareid = careschedule.typeofcareid " +
                    " INNER JOIN Palet ON palet.paletnumber = actualtask.paletid ";
        }
        public virtual string GetImportantDataQuery()
        {
            return "Select actualtask.actualtaskid, actualtask.realizationdate, actualtask.paletid, actualtask.userid, careschedule.timeofcare , careschedule.prioritynumber , paletplantstype.paletplantstypename , typeofcare.typeofcarename , palet.dateofplanting " +
                    " From ActualTask " +
                    " INNER JOIN careschedule ON actualtask.carescheduleid = careschedule.carescheduleid " +
                    " INNER JOIN paletplantstype ON paletplantstype.paletplantstypeid = careschedule.paletplantstypeid " +
                    " INNER JOIN TypeOfCare ON typeofcare.typeofcareid = careschedule.typeofcareid " +
                    " INNER JOIN Palet ON palet.paletnumber = actualtask.paletid ";
        }


        /*
        public virtual string GetBuildProcedureQuery(int userId, int actualTaskId)
        {
            return "";
        }
        */
    }
}
