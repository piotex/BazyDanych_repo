using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertTypeOfCareQuery : AbstractInsertQuery<TypeOfCare>
    {
        public override string GetInsertQuery(TypeOfCare user)
        {
            return string.Format(
                            "INSERT INTO TypeOfCare " +
                            "(TypeOfCareName) " +
                            "VALUES " +
                            "('{0}') ",
                            user.TYPEOFCARENAME
                            );
        }
    }
}
