using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Aircraft
    {
        int Capacity;
        int Range;
        bool MaintinanceStatus;
        List<Flight> Schedule;

        public Aircraft(int capacity, int range, bool maintenanceStatus)
        {
            this.Capacity = capacity;
            this.Range = range;
            this.MaintinanceStatus = maintenanceStatus;
            Schedule = new List<Flight>();

        }

    }
}
