using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassRollingDecrypt
    {
        // Instance of list type string which holds our key for decryption
        private List<string> listKey = new List<string>();

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="inKey"></param>
        public ClassRollingDecrypt(string[] inKey)
        {
            MakeListOfChars(inKey); //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inString"></param>
        /// <returns></returns>
        public string DecryptString(string inString)
        {
            string res = "";
            int intJump = 0;
            string tempRes = "";

            Encoding enc1252 = CodePagesEncodingProvider.Instance.GetEncoding(1252);
            byte[] asciiByte = enc1252.GetBytes(inString);

            foreach (char asciiChar in asciiByte)
            {
                if (listKey.Contains(asciiChar.ToString()))
                {
                    tempRes += asciiChar.ToString();
                }
                else
                {
                    if (tempRes != "")
                    {
                        res += MakeCharOfCode(tempRes, intJump);
                        tempRes = "";
                        intJump = 1;
                    }
                    else
                    {
                        intJump++;
                    }
                }
            }
            
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inChar"></param>
        /// <param name="inJump"></param>
        /// <returns></returns>
        private string MakeCharOfCode(string inChar, int inJump)
        {
            string newIndex = "";
            int localJump = 1;
            foreach (char singleChar in inChar)
            {
                int intChar = listKey.IndexOf(singleChar.ToString());
                intChar = GetRealKey(intChar, (inJump + localJump));
                localJump += 3;
                newIndex += intChar.ToString();
            }

            string res = $"{(char)Convert.ToInt32(newIndex)}";
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
                res--;

                if (res < 0)
                {
                    res = 9;
                }
            }

            return res;
        }

        /// <summary>
        /// Insets the values from an array that contains the key into a list????????????????
        /// 
        /// </summary>
        /// <param name="inKey"></param>
        private void MakeListOfChars(string[] inKey)
        {
            foreach (var item in inKey)
            {
                listKey.Add(item);
            }
        }

        
    }
}
