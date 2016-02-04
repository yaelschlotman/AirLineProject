//using AirLineProject.Model;
//using AirLineProject.ViewModel;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AirLineProject
//{
//    public class AirLineViewModel : INotifyPropertyChanged
//    {

//        private Database database = new Database();
//        FlightDataSource Flights = new FlightDataSource();

//        public event PropertyChangedEventHandler PropertyChanged;

//        public List<Seat> _Seats
//        {
//            get
//            {
//                return database.SeatingList;
//            }
//        }
//        public ObservableCollection<Flight> _Flights
//        {
//            get
//            {
//                return Flights;
//            }
//        }
//        public int _Price
//        {
//            get
//            {
//                return database.Price;
//            }
//        }


//    }
//}