using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassRollingCrypt
    {
        // Array of type string to hold our encryption key
        private string[] myKey;

        // Instance of ClassDummyText
        ClassDummyText CTD;

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="inKey"></param>
        /// <param name="inDummy"></param>
        public ClassRollingCrypt(string[] inKey, string[] inDummy)
        {
            myKey = inKey;
            // Initialize CTD as new type ClassDummyText wiht the parameter inDummy
            CTD = new ClassDummyText(inDummy);
        }


        /// <summary>
        /// This method ensures that we encrypt with the rigth encoding
        /// We put the recieved string in a array of bytes and convert them. These can easily be coverted back to char
        /// Ensure the encrypted text always starts out with dummy text
        /// Iteration runs through our byte array
        /// Each time it runs through we call our method makecodeofchar and send our asciichar with it
        /// Ensure the encrypted text always ends out with dummy text
        /// </summary>
        /// <param name="inString"></param>
        /// <returns>string</returns>
        public string CryptString(string inString)
        {
            string res = "";
            string tempDummy = "";
            int intJump = 0;

            Encoding enc1252 = CodePagesEncodingProvider.Instance.GetEncoding(1252);
            byte[] asciiByte = enc1252.GetBytes(inString);

            res = CTD.MakeDummyString(); // Ensure the encrypted text always starts out with dummy text
            intJump = res.Length;

            foreach (char asciiChar in asciiByte)
            {
                res += MakeCodeOfChar(asciiChar, intJump);
                tempDummy = CTD.MakeDummyString();
                intJump = tempDummy.Length;
                res += tempDummy;
            }

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inChar"></param>
        /// <param name="inJump"></param>
        /// <returns></returns>
       private string MakeCodeOfChar(char inChar, int inJump)
        {
            string res = "";
            int localJump = 1;
            int intChar = inChar;
            string strChar = intChar.ToString();

            foreach (char element in strChar)
            {
                string charString = element.ToString();
                int charInt = Convert.ToInt32(charString);
                charInt = GetRealKey(charInt, (inJump + localJump));

                res += myKey[charInt];
                localJump += 3;
            }

            return res;
       }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inValue"></param>
        /// <param name="inJump"></param>
        /// <returns></returns>
        private int GetRealKey(int inValue, int inJump)
        {
            int res = inValue;

            for (int i = 0; i < inJump; i++)
            {
                res++;
                if (res >= 10)
                {
                    res -= 10;
                }
            }

            return res;
        }
    }
}
