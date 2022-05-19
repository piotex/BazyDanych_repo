using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertCareScheduleQuery : AbstractInsertQuery<CareSchedule>
    {
        public override string GetInsertQuery(CareSchedule user)
        {
            string formattedDate = user.TIMEOFCARE.ToString("yyyy/MM/dd HH:mm:ss");
            return string.Format(
                            "INSERT INTO CareSchedule " +
                            "(TypeOfCare_Id, PaletPlantsType_Id, PriorityNumber, TimeOfCare) " +
                            "VALUES " +
                            "('{0}', '{1}', '{2}', (TO_DATE('{3}', 'yyyy/mm/dd hh24:mi:ss'))) ",
                            user.TYPEOFCAREID, user.PALETPLANTSTYPEID, user.PRIORITYNUMBER, formattedDate
                            );
        }
    }
}
