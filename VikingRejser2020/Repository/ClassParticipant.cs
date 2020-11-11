using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassParticipant : ClassNotify
    {
        private int _Id;
        private string _name;
        private DateTime _age;

        public ClassParticipant()
        {
            Id = 0;
            name = "";
            age = DateTime.Now;
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


        public DateTime age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                }
                Notify("age");
            }
        }

    }
}
