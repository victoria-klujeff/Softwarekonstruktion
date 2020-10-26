using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassClouds : ClassNotify
    {

        private int _all;

        public ClassClouds()
        {
            all = 0;

        }

        public int all
        {
            get { return _all; }
            set
            {
                if (_all != value)
                {
                    _all = value;
                }
                Notify("all");
            }
        }

    }
}
