using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectCompanyQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From Company ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From Company where CompanyId = {0} ", t);
        }
    }
}
