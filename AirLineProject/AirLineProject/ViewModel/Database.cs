using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model
{
    public class Database
    {
        private List<Flight> FlightList;
        private List<Aircraft> Fleet;
        private List<Seat> SeatingList;
        private List<String> Prices;
        private Fleet fleet = new Fleet();
        private SeatingChart seatingchart = new SeatingChart();
        private FlightGenerator flightgenerator = new FlightGenerator();


        public Database()
        {
            this.Prices = new List<string>() { "$150.00" };
            this.FlightList = new List<Flight>();
            this.Fleet = new List<Aircraft>();
            this.SeatingList = seatingchart.GenerateSeatingChart(9, 6);

            Fleet = fleet.BuildInitalFleet();
            FlightList = flightgenerator.BuildInitalFlightList(Fleet);
        }
        public List<Flight> _flightlist
        {
            get
            {
                return FlightList;
            }
        }
        public List<Aircraft> _fleet
        {
            get
            {
                return Fleet;
            }
        }
        public List<Seat> _seatingchart
        {
            get
            {
                return SeatingList;
            }
        }
        public List<string> _prices
        {
            get
            {
                return Prices;
            }
        }
    }
}
