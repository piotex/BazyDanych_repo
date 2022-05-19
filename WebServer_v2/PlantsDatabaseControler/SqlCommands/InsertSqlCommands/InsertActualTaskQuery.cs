using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertActualTaskQuery : AbstractInsertQuery<ActualTask>
    {
        public override string GetInsertQuery(ActualTask user)
        {
            string formattedDate = "";
            if (user.REALIZATIONDATE != null)
            {
                formattedDate = ((DateTime)user.REALIZATIONDATE).ToString("yyyy/MM/dd HH:mm:ss");
            }
            //2003/05/03 21:02:44
            return string.Format(
                            "INSERT INTO ActualTask " +
                            "(ActualTaskId, RealizationDate, Palet_Id, User_Id, CareSchedule_Id) " +
                            "VALUES " +
                            "('{0}', (TO_DATE('{1}', 'yyyy/mm/dd hh24:mi:ss')), '{2}', '{3}', '{4}' ) ",
                            user.ACTUALTASKID, formattedDate, user.PALETID, user.USERID, user.CARESCHEDULEID
                            ); 
        }
    }
}
