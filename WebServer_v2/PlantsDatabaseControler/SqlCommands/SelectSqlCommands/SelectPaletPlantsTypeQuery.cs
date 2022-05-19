using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class SelectPaletPlantsTypeQuery : AbstractSelectQuery
    {
        public override string GetSelectQuery()
        {
            return "Select * From PaletPlantsType ";
        }

        public override string GetSelectQuery(int t)
        {
            return string.Format("Select * From PaletPlantsType where PaletPlantsTypeId = {0} ", t);
        }
    }
}
