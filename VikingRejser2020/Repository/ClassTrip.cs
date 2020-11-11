using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassTrip : ClassNotify
    {
        private int _Id;
        private string _title;
        private string _destination;
        private DateTime _startDate;
        private DateTime _endDate;
        private double _price;
        private int _maxAmount;
        private string _description;
        private ClassCityWeather _weather;

        public ClassTrip()
        {
            Id = 0;
            title = "";
            destination = "";
            startDate = DateTime.Now;
            endDate = DateTime.Now;
            price = 0;
            maxAmount = 0;
            description = "";
            weather = new ClassCityWeather();
        }


        public int Id
        {
            get { return _Id; }
            set
            {
                if (_Id != value)
                {
                    _Id = value;
                }
                Notify("Id");
            }
        }


        public string title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                }
                Notify("title");
            }
        }


        public string destination
        {
            get { return _destination; }
            set
            {
                if (_destination != value)
                {
                    _destination = value;
                }
                Notify("destination");
            }
        }


        public DateTime startDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                }
                Notify("startDate");
            }
        }


        public DateTime endDate
        {
            get { return _endDate; }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                }
                Notify("endDate");
            }
        }


        public double price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                }
                Notify("price");
            }
        }


        public int maxAmount
        {
            get { return _maxAmount; }
            set
            {
                if (_maxAmount != value)
                {
                    _maxAmount = value;
                }
                Notify("maxAmount");
            }
        }


        public string description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                }
                Notify("description");
            }
        }


        public ClassCityWeather weather
        {
            get { return _weather; }
            set
            {
                if (_weather != value)
                {
                    _weather = value;
                }
                Notify("weather");
            }
        }


    }
}
