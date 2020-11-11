using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassRain : ClassNotify
    {
        private double _oneHour;
        private double _threeHour;

        public ClassRain()
        {
            oneHour = 0;
            threeHour = 0;
        }

        [JsonProperty(PropertyName = "1h")]
        public double oneHour
        {
            get { return _oneHour; }
            set
            {
                if (_oneHour != value)
                {
                    _oneHour = value;
                }
                Notify("oneHour");
            }
        }

        [JsonProperty(PropertyName = "3h")]
        public double threeHour
        {
            get { return _threeHour; }
            set
            {
                if (_threeHour != value)
                {
                    _threeHour = value;
                }
                Notify("threeHour");
            }
        }

    }
}
