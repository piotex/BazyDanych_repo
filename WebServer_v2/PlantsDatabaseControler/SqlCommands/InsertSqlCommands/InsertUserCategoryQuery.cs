using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertUserCategoryQuery : AbstractInsertQuery<UserCategory>
    {
        public override string GetInsertQuery(UserCategory user)
        {
            return string.Format(
                            "INSERT INTO UserCategory " +
                            "(UserCategoryName) " +
                            "VALUES " +
                            "('{0}') ",
                            user.USERCATEGORYNAME
                            );
        }
    }
}
