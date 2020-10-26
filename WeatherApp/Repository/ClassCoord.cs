using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassCoord : ClassNotify
    {
        private double _lon;
        private double _lat;

        public ClassCoord()
        {
            lon = 0;
            lat = 0;
        }

        public double lon
        {
            get { return _lon; }
            set
            {
                if (_lon != value)
                {
                    _lon = value;
                }
                Notify("lon");
            }
        }

        public double lat
        {
            get { return _lat; }
            set
            {
                if (_lat != value)
                {
                    _lat = value;
                }
                Notify("lat");
            }
        }

    }
}
