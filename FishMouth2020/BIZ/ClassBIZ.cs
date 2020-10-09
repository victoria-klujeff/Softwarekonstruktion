using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using IO;
using Repository;

namespace BIZ
{
    public class ClassBIZ
    {
        // array of type string which hold our encryption key and the dummy characters we use for encryption
        private string[] myKey = {"T", "O", "R", "S", "K", "E", "M", "U", "N", "D"};
        private string[] myDummy = { "A", "B", "C", "F", "G", "H", "I", "J", "L", "P", "Q", "X", "Y", "Z", "Æ", "Ø", "Å", "V", "W", 
                                     "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "@", "%", "&", "/", "+", "#", "*" , "<", "-", "!", "£"};
        // instantiation of our classes
        ClassCryptText CCT;
        ClassDecryptText CDT;
        ClassRollingCrypt CRC;
        ClassRollingDecrypt CRD;
        ClassFileHandler CFH;

        // Fields
        private ClassText _cleanText;
        private ClassText _cryptText;

        // Default constructor
        // Initializes all properties and instances of classes
        public ClassBIZ()
        {
            // Initialization of our class instances 
            CCT = new ClassCryptText(myKey, myDummy);
            CDT = new ClassDecryptText(myKey);
            CRC = new ClassRollingCrypt(myKey, myDummy);
            CRD = new ClassRollingDecrypt(myKey);
            CFH = new ClassFileHandler();

            // Initialization of our properties to avoid null exception
            cryptText = new ClassText();
            cleanText = new ClassText();
        }

        // Property cleanText is used for binding with or texBox CleanText
        public ClassText cleanText
        {
            get { return _cleanText; }
            set
            {
                if (_cleanText != value)
                {
                    _cleanText = value;
                }
            }
        }

        // Property cryptText is used for binding with or texBox EncryptText
        public ClassText cryptText
        {
            get { return _cryptText; }
            set
            {
                if (_cryptText != value)
                {
                    _cryptText = value;
                }
            }
        }

        /// <summary>
        /// Method with no parameters or return value
        /// This method is used to start encryption 
        /// We put the result from our method call and put it into our property cryptText.text
        /// </summary>
        public void StartCrypt()
        {
            cryptText.text = CCT.CryptString(cleanText.text);

        }

        /// <summary>
        /// Method with no parameters or return value
        /// This method is used to start encryption 
        /// We put the result from our method call and put it into our property cryptText.text
        /// </summary>
        public void StartRollingCrypt()
        {
            cryptText.text = CRC.CryptString(cleanText.text);

        }

        /// <summary>
        /// Method with no parameters or return value
        /// This method is used to start decryption 
        /// We put the result from our method call and put it into our property cleanText.text
        /// We send the parameter cryptText.text with our method call 
        /// </summary>
        public void StartDecrypt()
        {
            cleanText.text = CDT.DecryptString(cryptText.text);
        }
        /// <summary>
        /// Method with no parameters or return value
        /// This method is used to start decryption 
        /// We put the result from our method call and put it into our property cleanText.text
        /// We send the parameter cryptText.text with our method call 
        /// </summary>
        public void StartRollingDecrypt()
        {
            cleanText.text = CRD.DecryptString(cryptText.text);
        }

        /// <summary>
        /// This method takes one argument of type string 
        /// We put the result from our method call and put it into our property cleanText.text
        /// We send the parameter inPath with our method call  
        /// </summary>
        /// <param name="inPath"></param>
        public void OpenFile(string inPath)
        {
            cleanText.text = CFH.ReadTextFromFile(inPath).text;
        }

        /// <summary>
        /// This method takes one argument of type string 
        /// We send the parameters inpath and cryptText.text with our method call 
        /// </summary>
        /// <param name="inPath"></param>
        public void SaveTextToFile(string inPath)
        {
            CFH.WriteTextToFile(inPath, cryptText.text);
        }




    }
}
