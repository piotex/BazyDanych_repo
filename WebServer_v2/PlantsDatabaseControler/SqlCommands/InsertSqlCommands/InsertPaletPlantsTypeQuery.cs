using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertPaletPlantsTypeQuery : AbstractInsertQuery<PaletPlantsType>
    {
        public override string GetInsertQuery(PaletPlantsType user)
        {
            return string.Format(
                            "INSERT INTO PaletPlantsType " +
                            "(PaletPlantsTypeName) " +
                            "VALUES " +
                            "('{0}') ",
                            user.PALETPLANTSTYPENAME
                            );
        }
    }
}
