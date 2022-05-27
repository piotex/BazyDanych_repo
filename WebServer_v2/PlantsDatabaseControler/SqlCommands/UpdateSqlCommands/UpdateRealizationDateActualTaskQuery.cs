using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class UpdateRealizationDateActualTaskQuery : AbstractUpdateQuery<ActualTask>
    {
        public override string GetUpdateQuery(ActualTask user)
        {
            return string.Format(
                            "UPDATE ActualTask SET RealizationDate = sysdate WHERE ActualTaskID = {0}  ",
                            user.ACTUALTASKID
                            ); 
        }
    }
}
