using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ClassFileHandler
    {
        public ClassFileHandler()
        {

        }

        public ClassText ReadTextFromFile(string path)
        {
            String line;
            string filePath = @"C:\Users\vict4454\Desktop\Softwareprogrammering\S2\CODE\Softwarekonstruktion\FishMouth2020"; 
            try
            {
                StreamReader sr = new StreamReader(filePath);

                line = sr.ReadLine();

                while (line != null)
                {
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public void WriteTextToFile(string path, string text)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(@"C:\Users\vict4454\Desktop\Softwareprogrammering\S2\CODE\Softwarekonstruktion\FishMouth2020");
                
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
