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
        /// This method returns a string and recieves a parameter of char inChar.
        /// So it handles taking each character from the clean text and convert it to a string of characters based on our encryption key.
        /// We take our char and extract the value as int 
        /// Then we convert it to a string so we can acces the numbers one by one
        /// Iteration runs through strChar and each time puts the letter in element. 
        /// We need to convert our element to string so we can convert it to int.
        /// We use the int(charInt) to find the corresponding element in our myKey array.
        /// So charInt is the index we need to find in our myKey array.
        /// We return a string of characters 
        /// intJump is based on the length of our dummyString.
        /// 
        /// </summary>
        /// <param name="inChar"> char </param>
        /// <param name="inJump"> int </param>
        /// <returns>string</returns>
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
