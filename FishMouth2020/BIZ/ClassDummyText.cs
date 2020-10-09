using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassDummyText
    {
        // New instance of an array(dummyChars) which we use to hold the chars that ar enot a part of our encoding key
        private string[] dummyChars;

        // Initialoze a new instance of a Random called ran
        Random ran = new Random();

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="inDummy"></param>
        public ClassDummyText(string[] inDummy)
        {
            dummyChars = inDummy; // initialize array with the random chars
        }

        /// <summary>
        /// Method generates and returns a string of random chars
        /// The chars are picked based on our dummyChars array
        /// The length of the string is a minimum of 10 and max of 20 chars
        /// We use our ran to make a int of a random size between 10 and 20
        /// This controls the number of times our for loop runs
        /// A string to hold our return value
        /// For loop which runs x amount of times based on ranLength
        /// Every tie we run through the loop we initalize a ranIndex, this determines the value f te index in the array we choose
        /// We 
        /// </summary>
        /// <returns></returns>
        public string MakeDummyString()
        {
            int ranLength = ran.Next(10, 20);
            string res = "";

            for (int i = 0; i < ranLength; i++)
            {
                int ranIndex = ran.Next(0, dummyChars.Length);

                res += dummyChars[ranIndex];
            }

            return res;
        }

    }
}
