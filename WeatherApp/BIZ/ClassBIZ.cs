using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;
using Repository;

namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {

        private ClassCityWeather _cityWeather;
        private string _cityName;

        ClassWebApi classWebApi = new ClassWebApi();

        public ClassBIZ()
        {
            cityWeather = new ClassCityWeather();
            cityName = "";
        }


        public ClassCityWeather cityWeather
        {
            get { return _cityWeather; }
            set
            {
                if (_cityWeather != value)
                {
                    _cityWeather = value;
                }
                Notify("cityWeather");
            }
        }

        public string cityName
        {
            get { return _cityName; }
            set
            {
                if (_cityName != value)
                {
                    _cityName = value;
                }
                Notify("cityName");
            }
        }

        public async void GetData()
        {
            try
            {
                if (cityName.Trim() != "")
                {
                    cityWeather = await classWebApi.GetDataFromWeatherOrg(cityName);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}
