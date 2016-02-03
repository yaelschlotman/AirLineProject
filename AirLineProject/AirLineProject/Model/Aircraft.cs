using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Aircraft
    {
        public string AircraftID;
        public int Capacity;
        public int Range;
        public bool MaintinanceStatus;
        public List<Flight> Schedule;

        public Aircraft(string aircraftID,int capacity, int range, bool maintenanceStatus)
        {
            this.AircraftID = aircraftID;
            this.Capacity = capacity;
            this.Range = range;
            this.MaintinanceStatus = maintenanceStatus;
            Schedule = new List<Flight>();
        }
    }
}
