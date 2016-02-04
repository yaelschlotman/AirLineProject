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

    }
    /*public void AddPassengerToManifest()
        {
           // PassengerManifest.Add();e
        }*/

}
