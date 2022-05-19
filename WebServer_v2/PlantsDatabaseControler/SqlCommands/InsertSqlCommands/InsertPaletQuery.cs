using DatabaseConneciton;
using System;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public class InsertPaletQuery : AbstractInsertQuery<Palet>
    {
        public override string GetInsertQuery(Palet user)
        {
            string formattedDate = user.DATEOFPLANTING.ToString("yyyy/MM/dd HH:mm:ss");
            //2003/05/03 21:02:44
            return string.Format(
                            "INSERT INTO Palet " +
                            "(PaletNumber, PaletPlantsType_Id, DateOfPlanting) " +
                            "VALUES " +
                            "('{0}', '{1}', (TO_DATE('{2}', 'yyyy/mm/dd hh24:mi:ss'))) ",
                            user.PALETNUMBER, user.PALETPLANTSTYPEID, formattedDate
                            );
        }
    }
}
