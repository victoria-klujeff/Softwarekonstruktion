using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Repository
{
    /// <summary>
    /// This class is the root of the collection of classes which represent the data received from openweathermap api
    /// </summary>
    public class ClassCityWeather : ClassNotify
    {
        private string _base;
        private int _visibility;
        private long _dt;
        private int _timezone;
        private int _id;
        private string _name;
        private int _cod;


        public ClassCityWeather()
        {
            Base = "";
            visibility = 0;
            dt = 0;
            timezone = 0;
            id = 0;
            name = "";
            cod = 0;

            clouds = new ClassClouds();
            coord = new ClassCoord();
            main = new ClassMain();
            rain = new ClassRain();
            snow = new ClassSnow();
            sys = new ClassSys();
            weather = new List<ClassWeather>();
            wind = new ClassWind();

        }

        /// <summary>
        /// This properties name has to be "base".
        /// But base is a reserved name, so we have to call it something else.
        /// Since all properties names have to be the same so the Json converter can find, 
        /// we have to use an attribute that which is connected to the property.
        /// In this attribute we refer to JsonProperty with a specification of what the property should be read as.
        /// To enable use of this attribute we have to implement Newtonsoft.Json in the class
        /// </summary>
        [JsonProperty(PropertyName = "base")]
        public string Base
        {
            get { return _base; }
            set
            {
                if (_base != value)
                {
                    _base = value;
                }
                Notify("base");
            }
        }

        public int visibility
        {
            get { return _visibility; }
            set
            {
                if (_visibility != value)
                {
                    _visibility = value;
                }
                Notify("visibility");
            }
        }

        public long dt
        {
            get { return _dt; }
            set
            {
                if (_dt != value)
                {
                    _dt = value;
                }
                Notify("dt");
            }
        }

        public int timezone
        {
            get { return _timezone; }
            set
            {
                if (_timezone != value)
                {
                    _timezone = value;
                }
                Notify("timezone");
            }
        }
        
        public int id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                }
                Notify("id");
            }
        }        

        public string name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
                Notify("name");
            }
        }
      
        public int cod
        {
            get { return _cod; }
            set
            {
                if (_cod != value)
                {
                    _cod = value;
                }
                Notify("cod");
            }
        }

        public ClassClouds clouds { get; set; }

        public ClassCoord coord { get; set; }

        public ClassMain main { get; set; }

        public ClassRain rain { get; set; }

        public ClassSnow snow { get; set; }

        public ClassSys sys { get; set; }

        /// <summary>
        /// This property has to be of type list as the return from the api "weather" contains elements as a list
        /// When receieved the data is held by a property list of datatype ClassWeather
        /// </summary>
        public List<ClassWeather> weather { get; set; }

        public ClassWind wind { get; set; }
    }
}
