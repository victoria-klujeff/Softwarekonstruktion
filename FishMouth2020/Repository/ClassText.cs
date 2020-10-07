using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassText : ClassNotify
    {
        private string _text;


        public ClassText()
        {

        }

        public string text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                }
                //Notify("text");
            }
        }

    }
}
