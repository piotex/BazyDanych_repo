using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConneciton
{
    public class SqlCommand : DatabaseConnection
    {
        public void PostSqlRequest(string query)
        {
            using (OracleConnection conn = new OracleConnection(GetConectionString()))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteReader();
                }
                conn.Dispose();
            }
        }

        public List<T> GetSqlRequest<T>(string query) where T : new()
        {
            List<T> resultList = new List<T>();
            using (OracleConnection conn = new OracleConnection(GetConectionString()))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteReader();


                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        List<string> columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();

                        while (reader.Read())
                        {
                            T model = new T();
                            foreach (string column in columns)
                            {
                                try
                                {
                                    string typ = reader[column].GetType().Name;

                                    PropertyInfo propertyInfo = model.GetType().GetProperty(column);
                                    string readedValue = reader[column].ToString();

                                    if (typ == "Decimal")
                                    {
                                        propertyInfo.SetValue(model, Convert.ChangeType(readedValue, typeof(int)), null);
                                        continue;
                                    }
                                    if (typ == "DateTime")
                                    {
                                        propertyInfo.SetValue(model, Convert.ChangeType(readedValue, typeof(DateTime)), null);
                                        continue;
                                    }
                                    propertyInfo.SetValue(model, Convert.ChangeType(readedValue, propertyInfo.PropertyType), null);
                                }
                                catch (Exception eee)
                                {

                                }
                            }
                            resultList.Add(model);
                        }
                    }
                }
                conn.Dispose();
            }
            return resultList;
        }
    }
}
