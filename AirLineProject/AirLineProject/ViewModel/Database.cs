using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model
{
    public class Database
    {
        public List<Flight> FlightList;
        public List<Aircraft> Fleet;
        public List<Seat> SeatingList;
        public int Price;
        public Fleet fleet = new Fleet();
        public SeatingChart seatingchart = new SeatingChart();
        public FlightGenerator flightgenerator = new FlightGenerator();


        public Database()
        {
            this.Price = 100;
            this.FlightList = new List<Flight>();
            this.Fleet = new List<Aircraft>();
            this.SeatingList = seatingchart.GenerateSeatingChart(10, 6);

            Fleet = fleet.BuildInitalFleet();
            FlightList = flightgenerator.BuildInitalFlightList(Fleet);
        }

    }
}
