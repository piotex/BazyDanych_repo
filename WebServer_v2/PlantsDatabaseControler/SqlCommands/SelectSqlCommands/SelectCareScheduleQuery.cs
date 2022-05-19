using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectCareScheduleQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From CareSchedule ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From CareSchedule where CareScheduleId = {0} ", t);
        }
    }
}
