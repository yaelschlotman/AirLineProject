using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model
{
    public class Database
    {
        public List<Flight> FlightList;
        public List<Aircraft> Fleet;


        public Database()
        {
            this.FlightList = new List<Flight>();
            this.Fleet = new List<Aircraft>();

        }

    }
}
