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
            this.Aircraft = aircraft;
            this.FlightNumber = flightnumber;
            this.Origin = origin;
            this.Destination = destination;
            PassengerManifest = new List<Passenger>();
        }

        public Flight()
        {
        }
        public int _flightnumber
        {
            get
            {
                return FlightNumber;
            }
        }
        public String _origin
        {
            get
            {
                return Origin;
            }
        }
        public string _destination
        {
            get
            {
                return Destination;
            }
        }
        public List<Passenger> _passengermanifest
        {
            get
            {
                return PassengerManifest;
            }
        }
        public Aircraft _aircraft
        {
            get
            {
                return Aircraft;
            }
        }

        public void AddPassengerToManifest (Passenger passenger)
        {
            PassengerManifest.Add(passenger);
        }
        public override string ToString()
        {
            return (FlightNumber.ToString() + " from " + Origin + " to " + Destination);
        }
    }

}
