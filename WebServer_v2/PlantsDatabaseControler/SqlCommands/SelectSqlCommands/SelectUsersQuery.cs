using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectUsersQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From Users ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From Users where UsersId = {0} ", t);
        }
    }
}
