using System;
using System.Collections.Generic;

namespace AirLineProject.Model
{
    public class FlightGenerator
    {

        private Flight NewFlight(Aircraft aircraft, int flightnumber, string origin, string destination)
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

        public List<Flight> BuildInitalFlightList(List<Aircraft> fleet)
        {
            List<Flight> flights = new List<Flight>();

            flights.Add(NewFlight(fleet[3], 240, "Chicago", "New York"));
            flights.Add(NewFlight(fleet[1], 240, "Chicago", "Miami"));
            flights.Add(NewFlight(fleet[2], 180, "Chicago", "San Francisco"));
            flights.Add(NewFlight(fleet[3], 180, "New York", "Chicago"));
            flights.Add(NewFlight(fleet[4], 180, "New York", "Miami"));
            flights.Add(NewFlight(fleet[5], 240, "New York", "San Francisco"));
            flights.Add(NewFlight(fleet[6], 180, "Miami", "New York"));
            flights.Add(NewFlight(fleet[7], 240, "Miami", "San Francisco"));
            flights.Add(NewFlight(fleet[8], 180, "Miami", "Chicago"));

            return flights;
        }
    }
}