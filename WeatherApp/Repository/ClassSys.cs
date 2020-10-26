using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassSys : ClassNotify
    {
        private int _type;
        private int _id;
        private double _message;
        private string _country;
        private string _sunsetText;
        private string _sunriseText;
        private long _sunrise;
        private long _sunset;


        public ClassSys()
        {
            type = 0;
            id = 0;
            message = 0;
            country = "";
            sunrise = 0;
            sunset = 0;
        }

        public int type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                }
                Notify("type");
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

        public double message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                }
                Notify("message");
            }
        }

        public string country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                }
                Notify("country");
            }
        }

        public string sunsetText
        {
            get { return _sunsetText; }
            set
            {
                if (_sunsetText != value)
                {   
                    _sunsetText = value;
                }
                Notify("sunsetText");
            }
        }

        public string sunriseText
        {
            get { return _sunriseText; }
            set
            {
                if (_sunriseText != value)
                {
                    _sunriseText = value;
                }
                Notify("sunriseText");
            }
        }


        public long sunrise
        {
            get { return _sunrise; }
            set
            {
                if (_sunrise != value)
                {
                    _sunrise = value;
                    sunriseText = UnixTimeStampToDateTime(_sunrise.ToString());

                }
                Notify("sunrise");
            }
        }

        public long sunset
        {
            get { return _sunset; }
            set
            {
                if (_sunset != value)
                {
                    _sunset = value;
                    sunsetText = UnixTimeStampToDateTime(_sunset.ToString());               
                }
                Notify("sunset");
            }
        }

        /// <summary>
        /// The DateTime recieved from the Api is in unix format.
        /// The unix format has its start date as 1/1/1970 and the c# sartingpoint is 1/1/0001.
        /// Both systems are based on miliseconds from the starting point, a direct convertion from unix format,
        /// will give a shift in time of 1969 years.
        /// Based on that we initialize a new instance of DateTime dtDateTime to the date 1/1/1970 00:00:00 000
        /// Then we take the value we recived from the api and send to this method as a string
        /// The value is converted to a double and we get an amount of milisenconds which we can add to the value
        /// that springs from 1/1/1970 and we get a DateTime value which equals the value 
        /// which the unix format reprents.
        /// The value in DateTime is converted to a string in the format "HH:mm:ss"("hours:minutes:seconds")
        /// this is then returned.
        /// </summary>
        /// <param name="unixTimeStamp">string</param>
        /// <returns>string</returns>
        private string UnixTimeStampToDateTime(string unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(Convert.ToDouble(unixTimeStamp)).ToLocalTime();
            return dtDateTime.ToString("HH:mm:ss");
        }
    }
}
