using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Aircraft
    {
        private string AircraftID;
        private int Capacity;
        private int Range;
        public bool IsAircraftUndergoingMaintinance;
        public List<Flight> Schedule;
        public Aircraft(string aircraftID,int capacity, int range, bool IsAircraftUndergoingMaintinance)
        {
            this.AircraftID = aircraftID;
            this.Capacity = capacity;
            this.Range = range;
            this.IsAircraftUndergoingMaintinance = IsAircraftUndergoingMaintinance;
            Schedule = new List<Flight>();
        }
        public string _aircraftid
        {
            get
            {
                return AircraftID;
            }
        }
        public int _capacity
        {
            get
            {
                return Capacity;
            }
        }
        public int _range
        {
            get
            {
                return Range;
            }
        }
        public List<Flight> _schedule
        {
            get
            {
                return Schedule;
            }
        }
    }
}
