using NUnit.Framework;
using Oracle.ManagedDataAccess.Client;
using PlantsDatabaseControler;
using PlantsDatabaseControler.SqlCommands;
using PlantsDatabaseControler.SqlCommands.InsertSqlCommands;
using System;
using System.Data;
using System.IO;

namespace TestsForPlantsDatabaseControler
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertTest()
        {
            Company company = new Company()
            {
                COMPANYNAME = "OgroCorp2",
            };

            new InsertQuery().Insert(company);
            Assert.Pass();
        }
        [Test]
        public void SelectTest()
        {
            var result = new SelectQuery().Select<Users>();
            var result2 = new SelectQuery().Select<ActualTask>();
            Assert.Pass();
        }
        [Test]
        public void AddActualTasksProcedureTest()
        {
            int paletNumber = 33337;
            int paletPlantsType = 1;
            new ProcedureQuery().AddActualTasksProcedure(paletNumber, paletPlantsType);
            Assert.Pass();
        }
        [Test]
        public void UpdateActualTaskTest()
        {
            int userId = 7;
            int actualTaskId =4;
            new ProcedureQuery().UpdateActualTaskProcedure(userId, actualTaskId);
            Assert.Pass();
        }
        [Test]
        public void SelectActualTaskTest()
        {
            var data1 = new ProcedureQuery().SelectActualTasksProcedureAllData();
            var data2 = new ProcedureQuery().SelectActualTasksProcedureImportantData();
            Assert.Pass();
        }


        //dateOfPlanting Date, paletNumber NUMBER, paletPlantsTypeIDdd NUMBER

        [Test]
        public void Sqltest()
        {
            string path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Keys\oracle_db_ConnectionString.txt";
            string connectionStr = File.ReadAllText(path);

            using (OracleConnection objConn = new OracleConnection(connectionStr))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "AddActualTasks";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("dateOfPlanting", OracleDbType.Date).Value = DateTime.Now;
                objCmd.Parameters.Add("paletNumber", OracleDbType.Int32).Value = 2000;
                objCmd.Parameters.Add("paletPlantsTypeIDdd", OracleDbType.Int32).Value = 2;
                //objCmd.Parameters.Add("pout_count", OracleDbType.Int32).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    //System.Console.WriteLine("Number of employees in department 20 is {0}", objCmd.Parameters["pout_count"].Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }
                objConn.Close();
            }
            Assert.Pass();
        }
    }
}