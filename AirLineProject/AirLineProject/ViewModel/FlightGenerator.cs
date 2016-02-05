using System;
using System.Collections.Generic;

namespace AirLineProject.Model
{
    public class FlightGenerator
    {

        private Flight NewFlight(Aircraft aircraft, int flightnumber, string origin, string destination)
        {
            switch (aircraft.IsAircraftUndergoingMaintinance)
            {
                case (false):
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

            flights.Add(NewFlight(fleet[3], 0102, "Chicago", "New York"));
            flights.Add(NewFlight(fleet[1], 0103, "Chicago", "Miami"));
            flights.Add(NewFlight(fleet[2], 0104, "Chicago", "San Francisco"));
            flights.Add(NewFlight(fleet[3], 0201, "New York", "Chicago"));
            flights.Add(NewFlight(fleet[4], 0203, "New York", "Miami"));
            flights.Add(NewFlight(fleet[5], 0204, "New York", "San Francisco"));
            flights.Add(NewFlight(fleet[6], 0302, "Miami", "New York"));
            flights.Add(NewFlight(fleet[7], 0304, "Miami", "San Francisco"));
            flights.Add(NewFlight(fleet[8], 0301, "Miami", "Chicago"));

            return flights;
        }
    }
}