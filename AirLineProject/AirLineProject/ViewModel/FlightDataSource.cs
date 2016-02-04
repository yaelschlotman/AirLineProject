using AirLineProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AirLineProject.ViewModel
{
    public class FlightDataSource : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public FlightDataSource()
        {
            ReadURI URIReader = new ReadURI();
            try
            {
                
                System.Windows.Application.LoadComponent(this, URIReader.ReadFromURI("/AirLineProject;component/Model/FlightData.xaml", UriKind.RelativeOrAbsolute));
            }
            catch
            {
            }
        }

        private Flight_Data _Flight_Data = new Flight_Data();

        public Flight_Data Flight_Data
        {
            get
            {
                return this._Flight_Data;
            }
        }
    }

    public class Flight_DataItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private double _Flight_Number = 0;

        public double Flight_Number
        {
            get
            {
                return this._Flight_Number;
            }

            set
            {
                if (this._Flight_Number != value)
                {
                    this._Flight_Number = value;
                    this.OnPropertyChanged("Flight_Number");
                }
            }
        }

        private string _Destination = string.Empty;

        public string Destination
        {
            get
            {
                return this._Destination;
            }

            set
            {
                if (this._Destination != value)
                {
                    this._Destination = value;
                    this.OnPropertyChanged("Destination");
                }
            }
        }

        private string _Origin = string.Empty;

        public string Origin
        {
            get
            {
                return this._Origin;
            }

            set
            {
                if (this._Origin != value)
                {
                    this._Origin = value;
                    this.OnPropertyChanged("Origin");
                }
            }
        }
    }

    public class Flight_Data : System.Collections.ObjectModel.ObservableCollection<Flight_DataItem>
    {
    }

}

