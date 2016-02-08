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


        public Flight(Aircraft aircraft, int flightnumber, string origin, string destination)
        {
            this.Aircraft = aircraft;
            this.FlightNumber = flightnumber;
            this.Origin = origin;
            this.Destination = destination;
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
        public Aircraft _aircraft
        {
            get
            {
                return Aircraft;
            }
        }
        public override string ToString()
        {
            return (FlightNumber.ToString() + " from " + Origin + " to " + Destination);
        }
    }

}
