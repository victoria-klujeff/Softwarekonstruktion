using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Repository
{

    public class ClassSnow : ClassNotify
    {
        private int _oneHour;
        private int _threeHour;

        public ClassSnow()
        {
            oneHour = 0;
            threeHour = 0;
        }

        [JsonProperty(PropertyName = "1h")]
        public int oneHour
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
        public int threeHour
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
