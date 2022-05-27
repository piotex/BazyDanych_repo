using DatabaseConneciton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsDatabaseControler.SqlCommands.InsertSqlCommands
{
    public abstract class AbstractUpdateQuery<T> : SqlCommand
    {
        public abstract string GetUpdateQuery(T t);
    }
}
