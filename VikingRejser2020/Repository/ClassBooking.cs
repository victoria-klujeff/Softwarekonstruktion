using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassBooking : ClassNotify
    {
        private int _Id;
        private int _rejseId;
        private int _kundeId;
        private List<ClassParticipant> _participant;

        public ClassBooking()
        {
            Id = 0;
            rejseId = 0;
            kundeId = 0;
            participant = new List<ClassParticipant>();

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


        public int rejseId
        {
            get { return _rejseId; }
            set
            {
                if (_rejseId != value)
                {
                    _rejseId = value;
                }
                Notify("rejseId");
            }
        }


        public int kundeId
        {
            get { return _kundeId; }
            set
            {
                if (_kundeId != value)
                {
                    _kundeId = value;
                }
                Notify("kundeId");
            }
        }


        public List<ClassParticipant> participant
        {
            get { return _participant; }
            set
            {
                if (_participant != value)
                {
                    _participant = value;
                }
                Notify("participant");
            }
        }
    }
}
