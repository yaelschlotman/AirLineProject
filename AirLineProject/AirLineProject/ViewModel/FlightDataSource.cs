using AirLineProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.ViewModel
{
    class FlightDataSource : ObservableCollection<Flight>
    {
        Database database = new Database();

        public FlightDataSource()
        {
            loadData();
        }

        private void loadData()
        {
            foreach (Flight flight in database.FlightList)
            {
                this.Add(flight);
            }
            
        }
    }
}
