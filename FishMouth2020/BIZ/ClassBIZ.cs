using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace BIZ
{
    public class ClassBIZ
    {
        private string[] myKey;
        private string[] myDummy;

        ClassCryptText CCT;
        ClassDecryptText CDT;

        private ClassText _clearText;
        private ClassText _cryptText;


        public ClassBIZ()
        {
            CCT = new ClassCryptText(myKey, myDummy);
            CDT = new ClassDecryptText(myKey);
        }


        public ClassText clearText
        {
            get { return _clearText; }
            set
            {
                if (_clearText != value)
                {
                    _clearText = value;
                }
            }
        }


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


        public void StartCrypt()
        {

        }

        public void StartDecrypt()
        {

        }

        public void OpenFile(string inPath)
        {

        }

        public void SaveTextToFile(string inPath)
        {

        }




    }
}
