using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertUsersQuery : AbstractInsertQuery<Users>
    {
        public override string GetInsertQuery(Users user)
        {
            string formattedDate = user.BIRTHDAY.ToString("yyyy/MM/dd HH:mm:ss");
            return string.Format(
                            "INSERT INTO Users " +
                            "(Name, LastName, Mail, Phone, Birthday, UserCategory_Id, Company_Id) " +
                            "VALUES " +
                            "('{0}', '{1}', '{2}', '{3}', (TO_DATE('{4}', 'yyyy/mm/dd hh24:mi:ss')), {5}, {6}) ",
                            user.NAME, user.LASTNAME, user.MAIL, user.PHONE, formattedDate, user.USERCATEGORYID, user.COMPANYID
                            );
        }
    }
}
