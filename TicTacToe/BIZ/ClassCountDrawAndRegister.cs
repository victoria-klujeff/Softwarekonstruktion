using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace BIZ
{
    public class ClassCountDrawAndRegister : ClassNotify
    {
        /*Fields*/
        private int _intX;
        private int _intO;
        private int _intScoreCountX;
        private int _intScoreCountO;

        /*Constructor with our initialized properties*/

        public ClassCountDrawAndRegister()
        {
            intX = 0;
            intO = 0;
            intScoreCountX = 0;
            intScoreCountO = 0;
            initializeArray();
        }

        // 2 dim array which holds an equivalent of the input from the form. It is used to search for a winner
        protected string[,] strSignPlacement = new string[3, 3];

        // Holds a counter for how many times X has been used in the game 

        protected int intX
        {
            get { return _intX; }
            set
            {
                if (_intX != value)
                {
                    _intX = value;
                }
                Notify("intX");
            }
        }

        // Holds a counter for how many times = has been used in the game 
       

        protected int intO
        {
            get { return _intO; }
            set
            {
                if (_intO != value)
                {
                    _intO = value;
                }
                Notify("intO");
            }
        }

        //Holds a counter for how many times X has won
     

        public int intScoreCountX
        {
            get { return _intScoreCountX; }
            set
            {
                if (_intScoreCountX != value)
                {
                    _intScoreCountX = value;
                }
                Notify("intScoreCountX");
            }
        }

        //Holds a counter for how many times O has won
        

        public int intScoreCountO
        {
            get { return _intScoreCountO; }
            set
            {
                if (_intScoreCountO != value)
                {
                    _intScoreCountO = value;
                }
                Notify("intScoreCountO");
            }
        }

        //Method which initializes all the elemts in strSignPlacement to an empty string
        protected void initializeArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    strSignPlacement[i, x] = "";
                   
                }
            }
        }

       

    }


}
