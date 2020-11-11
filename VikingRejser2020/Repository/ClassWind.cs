using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassWind : ClassNotify
    {
        private double _speed;
        private int _deg;
        private double _gust;
        private string _degText;

        public ClassWind()
        {
            speed = 0;
            deg = 0;
            gust = 0;
            degText = "";
        }

        public double speed
        {
            get { return _speed; }
            set
            {
                if (_speed != value)
                {
                    _speed = value;
                }
                Notify("speed");
            }
        }

        public int deg
        {
            get { return _deg; }
            set
            {
                if (_deg != value)
                {
                    _deg = value;
                    ConvertWindDegToText();
                }
                Notify("deg");
            }
        }

        public double gust
        {
            get { return _gust; }
            set
            {
                if (_gust != value)
                {
                    _gust = value;
                }
                Notify("gust");
            }
        }

        public string degText
        {
            get { return _degText; }
            set
            {
                if (_degText != value)
                {
                    _degText = value;
                }
                Notify("degText");
            }
        }

        /// <summary>
        /// This method converts the value from the property deg to a text description of the wind direction.
        /// Instead of a value showed in degrees, we want to show a text describing the winds direction as where it is coming from
        /// In this instance we use 8 wind directions which are identified by a range within the 360deg that are possible. 
        /// The direction north has to be handled differently as its range covers both side of start point.
        /// </summary>
        /// <returns></returns>
        private string ConvertWindDegToText()
        {
            string res = "";

            if ((deg >= 338 && deg <= 360) || (deg >= 0 && deg <= 22)) degText = "Nord";
            else if (deg >= 23 && deg <= 67) degText = "Nord øst";
            else if (deg >= 68 && deg <= 112) degText = "Øst";
            else if (deg >= 113 && deg <= 157) degText = "Syd øst";
            else if (deg >= 158 && deg <= 202) degText = "Syd";
            else if (deg >= 203 && deg <= 247) degText = "Syd vest";
            else if (deg >= 248 && deg <= 292) degText = "Vest";
            else if (deg >= 293 && deg <= 337) degText = "Nord";
            return res;
        }

    }
}
