using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConneciton
{
    public class DatabaseConnection
    {
        public virtual string GetConectionString()
        {
            string path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Keys\oracle_db_ConnectionString.txt";
            return File.ReadAllText(path);
        }
    }
}
