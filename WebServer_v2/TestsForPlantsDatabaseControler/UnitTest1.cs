using NUnit.Framework;
using PlantsDatabaseControler;
using PlantsDatabaseControler.SqlCommands;
using PlantsDatabaseControler.SqlCommands.InsertSqlCommands;

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
    }
}