using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectPaletQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From Palet ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From Palet where PaletId = {0} ", t);
        }
    }
}
