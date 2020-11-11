using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassWeather : ClassNotify
    {

        private int _id;
        private string _main;
        private string _description;
        private string _icon;
        private string _iconPath;

        public ClassWeather()
        {
            id = 0;
            main = "";
            description = "";
            icon = "";
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

        public string main
        {
            get { return _main; }
            set
            {
                if (_main != value)
                {
                    _main = value;
                }
                Notify("main");
            }
        }

        public string description
        {
            get { return _description.First().ToString().ToUpper() + String.Join("", _description.Skip(1)); }
            set
            {
                if (_description != value)
                {
                    _description = value;
                }
                Notify("description");
            }
        }

        public string icon
        {
            get { return _icon; }
            set
            {
                if (_icon != value)
                {
                    _icon = value;
                    iconPath = value;
                }
                Notify("icon");
            }
        }

        public string iconPath
        {
            get { return $"http://openweathermap.org/img/w/{_iconPath}.png";}
                set
            {
                if (_iconPath != value)
                {
                    _iconPath = value;
                }
                Notify("iconPath");
            }
        }


    }
}
