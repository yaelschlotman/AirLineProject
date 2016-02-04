using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirLineProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model.Tests
{
    [TestClass()]
    public class DatabaseTests
    {
        [TestMethod()]
        public void DatabaseTest()
        {
            Database database = new Database();

            Console.WriteLine(  database.FlightList[0]);

            Assert.Fail();
        }
    }
}