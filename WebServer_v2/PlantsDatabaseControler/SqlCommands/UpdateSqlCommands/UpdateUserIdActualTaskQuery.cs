using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class UpdateUserIdActualTaskQuery : AbstractUpdateQuery<ActualTask>
    {
        public override string GetUpdateQuery(ActualTask user)
        {
            return string.Format(
                            "UPDATE ActualTask SET UserID = {0} WHERE ActualTaskID = {1} ",
                            user.USERID, user.ACTUALTASKID
                            );
        }
    }
}
