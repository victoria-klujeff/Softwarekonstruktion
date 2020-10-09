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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ClassText ReadTextFromFile(string path)
        {
            ClassText ct = new ClassText();

            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    ct.text = reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
            return ct;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public void WriteTextToFile(string path, string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(File.Create(path)))
                {
                    writer.WriteLine(text);
                }
            }
            catch (IOException ex)
            {

                throw ex;
            }
        }
    }
}
