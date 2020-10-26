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
        /// This method reads a file from a given path.
        /// fileStream finds and creates a connection to the file
        /// reader sets a pointer at the very beginning of the file.
        /// reader.ReadToEnd indicates what part of the file needs to be read(it reads the entire file).
        /// </summary>
        /// <param name="path"> string </param>
        /// <returns> ClassText </returns>
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
        /// This method recieves a path to where the file needs to be saved.
        /// And a text which needs to be saved where the path points at.
        /// writer writes the text to the file.
        /// Create creates the path and the empty file.
        /// </summary>
        /// <param name="path"> string </param>
        /// <param name="text">string </param>
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
