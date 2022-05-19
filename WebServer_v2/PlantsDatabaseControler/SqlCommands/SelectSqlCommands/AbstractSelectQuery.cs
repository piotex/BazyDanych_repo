using DatabaseConneciton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public abstract class AbstractSelectQuery : SqlCommand
    {
        public abstract string GetSelectQuery();
        public abstract string GetSelectQuery(int id);
    }
}
