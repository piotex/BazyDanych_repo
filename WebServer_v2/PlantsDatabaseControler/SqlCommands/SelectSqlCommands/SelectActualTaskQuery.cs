using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectActualTaskQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From ActualTask ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From ActualTask where actualtaskid = {0} ", t);
        }
    }
}
