using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository
{

  

    public class ClassMain : ClassNotify
    {   
        private double _temp;
        private string _feels_like;
        private int _pressure;
        private int _humidity;
        private double _temp_min;
        private double _temp_max;
        private int _sea_level;
        private int _grnd_level;

        public ClassMain()
        {
            temp = 0;
            feels_like = "";
            pressure = 0;
            humidity = 0;
            temp_min = 0;
            temp_max = 0;
            sea_level = 0;
            grnd_level = 0;
        }

        public double temp
        {
            get { return _temp; }
            set
            {
                if (_temp != value)
                {
                    _temp = value;
                }
                Notify("temp");
            }
        }

        public string feels_like
        {
            get { return _feels_like; }
            set
            {
                if (_feels_like != value)
                {
                    _feels_like = value;
                }
                Notify("feels_like");
            }
        }

        public int pressure
        {
            get { return _pressure; }
            set
            {
                if (_pressure != value)
                {
                    _pressure = value;
                }
                Notify("pressure");
            }
        }

        public int humidity
        {
            get { return _humidity; }
            set
            {
                if (_humidity != value)
                {
                    _humidity = value;
                }
                Notify("humidity");
            }
        }

        public double temp_min
        {
            get { return _temp_min; }
            set
            {
                if (_temp_min != value)
                {
                    _temp_min = value;
                }
                Notify("temp_min");
            }
        }

        public double temp_max
        {
            get { return _temp_max; }
            set
            {
                if (_temp_max != value)
                {
                    _temp_max = value;
                }
                Notify("temp_max");
            }
        }

        public int sea_level
        {
            get { return _sea_level; }
            set
            {
                if (_sea_level != value)
                {
                    _sea_level = value;
                }
                Notify("sea_level");
            }
        }

        public int grnd_level
        {
            get { return _grnd_level; }
            set
            {
                if (_grnd_level != value)
                {
                    _grnd_level = value;
                }
                Notify("grnd_level");
            }
        }


    }
}
