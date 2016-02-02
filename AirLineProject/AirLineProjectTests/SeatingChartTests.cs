using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirLineProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Tests
{
    [TestClass()]
    public class SeatingChartTests
    {
        [TestMethod()]
        public void SeatingChartTest()
        {
            SeatingChart Chart = new SeatingChart(1,1);

            List<Seat> Expected = new List<Seat>();

            Expected.Add(new Seat(1, "A"));


            Assert.AreEqual(Chart.SeatList[0].ToString(),Expected[0].ToString());
        }
    }
}