using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassText : ClassNotify
    {
        // Field
        private string _text;

        // Default constructor
        public ClassText()
        {
            text = "";
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="inText"></param>
        public ClassText(string inText)
        {
            text = inText; //
        }

        /// <summary>
        /// Property to hold a text(string)
        /// </summary>
        public string text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                }
                Notify("text");
            }
        }

    }
}
