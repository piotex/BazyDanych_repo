using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectUserCategoryQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From UserCategory ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From UserCategory where UserCategoryId = {0} ", t);
        }
    }
}
