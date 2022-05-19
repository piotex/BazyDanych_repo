using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertCompanyQuery : AbstractInsertQuery<Company>
    {
        public override string GetInsertQuery(Company user)
        {
            return string.Format(
                            "INSERT INTO Company " +
                            "(CompanyName) " +
                            "VALUES " +
                            "('{0}') ",
                            user.COMPANYNAME
                            );
        }
    }
}
