using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model
{
    public class Database
    {
        List<Flight> FlightList;
        List<Aircraft> Fleet;

        public Database()
        {
            this.FlightList = new List<Flight>();
            this.Fleet = new List<Aircraft>();

        }
        public void NewFlight(Aircraft aircraft, int flightnumber, string origin, string destination)
        {
            if (aircraft.MaintinanceStatus == false)
            {
                Flight NewFlight = new Flight(aircraft, flightnumber, origin, destination);

                FlightList.Add(NewFlight);
                aircraft.Schedule.Add(NewFlight);
            }
            else if (aircraft.MaintinanceStatus == true)
            {
                throw new Exception("The Aircraft Specified for flight is currently undergoing maintenance.");

            }
        }
    }
}