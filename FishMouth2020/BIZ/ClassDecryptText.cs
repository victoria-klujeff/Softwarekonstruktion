using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassDecryptText
    {
        // Instance of list type string which holds our key for decryption
        private List<string> listKey = new List<string>();

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="inKey"></param>
        public ClassDecryptText(string[] inKey)
        {
            MakeListOfChars(inKey); //
        }

        /// <summary>
        /// This method decrypts our encrypted text
        /// Create to empty strings
        /// Encoding so we use the same as when we encrypted
        /// array of bytes to hold the values of the char
        /// foreach to run through our array
        /// If the char is in the listkey we add it to tempRes and continue to do that util we run across a char that is a dummy and not a listkey char
        /// When we run into a char that is not in our listkey we check if tempRes is empty
        /// If not we send our tempRes with our method MakeCharOfcode
        /// tempRes is then set to an empty string again
        /// </summary>
        /// <returns> string res </returns>
        public string DecryptString(string inString)
        {
            string res = "";
            string tempRes = "";

            Encoding enc1252 = CodePagesEncodingProvider.Instance.GetEncoding(1252);
            byte[] asciiByte = enc1252.GetBytes(inString);

            foreach (char asciiChar in asciiByte)
            {
                //
                if (listKey.Contains(asciiChar.ToString()))
                {
                    tempRes += asciiChar.ToString(); 
                }
                else
                {
                    if (tempRes != "")
                    {
                        res += MakeCharOfCode(tempRes);
                        tempRes = "";
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// This method converts our key array to a list that holds the key
        /// Uses a foreach to run through the array and places each element in a list
        /// </summary>
        /// <param name="inKey"></param>
        private void MakeListOfChars(string[] inKey)
        {
            foreach (var item in inKey)
            {
                listKey.Add(item);
            }
        }

        /// <summary>
        /// This method takes in a string of chars
        /// These are 
        /// </summary>
        /// <param name="inChar"></param>
        /// <returns></returns>
        private string MakeCharOfCode(string inChar)
        {
            string newIndex = "";

            foreach (char singleChar in inChar)
            {
                int intChar = listKey.IndexOf(singleChar.ToString());
                newIndex += intChar.ToString();
            }

            string res = $"{(char)Convert.ToInt32(newIndex)}";
            return res;
        }

    }
}
