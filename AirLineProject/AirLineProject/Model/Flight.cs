using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Flight
    {
        Aircraft Aircraft;
        int FlightNumber;
        string Origin;
        string Destination;
        List<Passenger> PassengerManifest;

        public Flight(Aircraft aircraft, int flightnumber, string origin, string destination)
        {
            this.FlightNumber = flightnumber;
            this.Origin = origin;
            this.Destination = destination;
            PassengerManifest = new List<Passenger>();
        }

        public Flight()
        {
        }

        public Flight NewFlight(Aircraft aircraft, int flightnumber, string origin, string destination)
        {
            switch (aircraft.MaintinanceStatus)
            {
                case false:
                    {
                        Flight flight = new Flight(aircraft, flightnumber, origin, destination);
                        aircraft.Schedule.Add(flight);
                        return flight;
                    }
                default:
                    {
                        throw new Exception("The Aircraft Specified for flight is currently undergoing maintenance.");
                    }
            }
        }

        public void BuildInitalFlightList(List<Flight> flightList, List<Aircraft> fleet)
        {
            flightList.Add(NewFlight(fleet[3], 240, "Chicago", "New York"));
            flightList.Add(NewFlight(fleet[1], 240, "Chicago", "Miami"));
            flightList.Add(NewFlight(fleet[2], 180, "Chicago", "San Francisco"));
            flightList.Add(NewFlight(fleet[3], 180, "New York", "Chicago"));
            flightList.Add(NewFlight(fleet[4], 180, "New York", "Miami"));
            flightList.Add(NewFlight(fleet[5], 240, "New York", "San Francisco"));
            flightList.Add(NewFlight(fleet[6], 180, "Miami", "New York"));
            flightList.Add(NewFlight(fleet[7], 240, "Miami", "San Francisco"));
            flightList.Add(NewFlight(fleet[8], 180, "Miami", "Chicago"));
        }
    }
    /*public void AddPassengerToManifest()
        {
           // PassengerManifest.Add();e
        }*/

}
