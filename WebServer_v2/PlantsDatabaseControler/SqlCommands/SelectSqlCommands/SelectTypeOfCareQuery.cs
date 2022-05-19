using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectTypeOfCareQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From TypeOfCare ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From TypeOfCare where TypeOfCareId = {0} ", t);
        }
    }
}
