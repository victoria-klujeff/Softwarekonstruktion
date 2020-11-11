using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using IO;
using System.Runtime.InteropServices;

namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {

        private string _cityName;

        private ClassTrip _selectedTrip;
        private List<ClassTrip> _tripList;

        private ClassBooking _selectedBooking;
        private List<ClassBooking> _bookingList;

        private ClassTransport _selectedTransport;
        private List<ClassTransport> _transportList;

        private ClassCustomers _selectedCustomer;
        private List<ClassCustomers> _customerList;

        private ClassParticipant _selectedParticipant;
        private List<ClassParticipant> _participantList;

        ClassWebApi classWebApi = new ClassWebApi();

        public ClassBIZ()
        {
            cityName = "";

            selectedTrip = new ClassTrip();
            tripList = new List<ClassTrip>();

            selectedBooking = new ClassBooking();
            bookingList = new List<ClassBooking>();

            selectedTransport = new ClassTransport();
            transportList = new List<ClassTransport>();

            selectedCustomer = new ClassCustomers();
            customerList = new List<ClassCustomers>();

            selectedParticipant = new ClassParticipant();
            participantList = new List<ClassParticipant>();

            TestMetode();
        }

        private void TestMetode()
        {
            ClassTrip CT = new ClassTrip();
            CT.destination = "London";
            selectedTrip = CT;
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



        public ClassTrip selectedTrip
        {
            get { return _selectedTrip; }
            set
            {
                if (_selectedTrip != value)
                {
                    _selectedTrip = value;
                    GetWeatherData();
                }
                Notify("selectedTrip");
            }
        }

        public List<ClassTrip> tripList
        {
            get { return _tripList; }
            set
            {
                if (_tripList != value)
                {
                    _tripList = value;
                }
                Notify("trip");
            }
        }

        public ClassBooking selectedBooking
        {
            get { return _selectedBooking; }
            set
            {
                if (_selectedBooking != value)
                {
                    _selectedBooking = value;
                }
                Notify("booking");
            }
        }

        public List<ClassBooking> bookingList
        {
            get { return _bookingList; }
            set
            {
                if (_bookingList != value)
                {
                    _bookingList = value;
                }
                Notify("bookingList");
            }
        }

        public ClassTransport selectedTransport
        {
            get { return _selectedTransport; }
            set
            {
                if (_selectedTransport != value)
                {
                    _selectedTransport = value;
                }
                Notify("selectedTransport");
            }
        }

        public List<ClassTransport> transportList
        {
            get { return _transportList; }
            set
            {
                if (_transportList != value)
                {
                    _transportList = value;
                }
                Notify("transportList");
            }
        }

        public ClassCustomers selectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                if (_selectedCustomer != value)
                {
                    _selectedCustomer = value;
                }
                Notify("selectedCustomer");
            }
        }

        public List<ClassCustomers> customerList
        {
            get { return _customerList; }
            set
            {
                if (_customerList != value)
                {
                    _customerList = value;
                }
                Notify("customerList");
            }
        }

        public ClassParticipant selectedParticipant
        {
            get { return _selectedParticipant; }
            set
            {
                if (_selectedParticipant != value)
                {
                    _selectedParticipant = value;
                }
                Notify("selectedParticipant");
            }
        }

        public List<ClassParticipant> participantList
        {
            get { return _participantList; }
            set
            {
                if (_participantList != value)
                {
                    _participantList = value;
                }
                Notify("participantList");
            }
        }

        

        public async void GetWeatherData()
        {
            if (selectedTrip.destination.Trim().Length > 0)
            {
                selectedTrip.weather = await classWebApi.GetDataFromWeatherOrg(selectedTrip.destination);
            }
        }

        //public async void GetData()
        //{
        //    try
        //    {
        //        if (cityName.Trim() != "")
        //        {
        //            selectedTrip.weather = await classWebApi.GetDataFromWeatherOrg(cityName);
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}
    }

}
