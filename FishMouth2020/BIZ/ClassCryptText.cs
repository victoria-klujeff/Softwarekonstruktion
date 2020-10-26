using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassCryptText
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
        public ClassCryptText( string[] inKey, string[] inDummy)
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
        /// <returns></returns>
        public string CryptString(string inString)
        {
            string res = "";
            Encoding enc1252 = CodePagesEncodingProvider.Instance.GetEncoding(1252); // Tells which encoding to use to read the text from the left textbox
            byte[] asciiByte = enc1252.GetBytes(inString);

            res = CTD.MakeDummyString(); // Ensure the encrypted text always starts out with dummy text

            // This is where the actual encryption takes place
            foreach (char asciiChar in asciiByte)
            {
                res += MakeCodeOfChar(asciiChar);
                res += CTD.MakeDummyString();
            }

            return res;
        }

        /// <summary>
        /// This method returns a string and recieves a parameter of char inChar.
        /// So it handles taking each character from the clean text and convert it to a string of characters based on our encryption key.
        /// We take our char and extract the value as int 
        /// Then we convert it to a string so we can acces the numbers one by one
        /// Iteration runs through strChar and each time puts the letter in element. 
        /// We need to convert our elemt to string so we can convert it to int.
        /// We use the int(charInt) to find the coresponding elemt in our myKey array.
        /// So charInt is the index we need to find in our myKey array.
        /// We return a string of characters 
        /// </summary>
        /// <param name="inChar"></param>
        /// <returns></returns>
        private string MakeCodeOfChar(char inChar)
        {
            string res = "";
            int intChar = inChar;
            string strChar = intChar.ToString();

            
            foreach (char element in strChar)
            {
                string charString = element.ToString();
                int charInt = Convert.ToInt32(charString);
                res += myKey[charInt];
            }

            return res;
        }
    }
}
