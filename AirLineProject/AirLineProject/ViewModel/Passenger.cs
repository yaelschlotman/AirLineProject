using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Passenger
    {
        string Name;
        string SeatAssignment;
        Flight Flight;
        public Passenger(string name, string seatassignment, Flight flight)
        {
            this.Name = name;
            this.SeatAssignment = seatassignment;
            this.Flight = flight;
        }
        public string _name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string _seatassignment
        {
            get
            {
                return SeatAssignment;
            }
        }
        public Flight _flight
        {
            get
            {
                return Flight;
            }
        }
    }
}
