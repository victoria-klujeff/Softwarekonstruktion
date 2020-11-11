using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassCustomers : ClassNotify
    {

        private int _Id;
        private string _name;
        private string _email;
        private string _address;
        private string _postalcode;
        private string _cityName;
        private string _telephone;

        public ClassCustomers()
        {
            Id = 0;
            name = "";
            email = "";
            address = "";
            postalcode = "";
            cityName = "";
            telephone = "";
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

        

        public string email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                }
                Notify("email");
            }
        }

       

        public string address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                }
                Notify("address");
            }
        }

        

        public string postalcode
        {
            get { return _postalcode; }
            set
            {
                if (_postalcode != value)
                {
                    _postalcode = value;
                }
                Notify("postalcode");
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

      

        public string telephone
        {
            get { return _telephone; }
            set
            {
                if (_telephone != value)
                {
                    _telephone = value;
                }
                Notify("telephone");
            }
        }

    }
}
