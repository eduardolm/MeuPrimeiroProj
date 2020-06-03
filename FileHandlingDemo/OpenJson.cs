using System.Collections.Generic;
using System.IO;

namespace FileHandlingDemo
{
    public class OpenJson
    {
        public OpenJson(){}

        public string ReadFile(string path)
        {
            string workingFile = string.Empty;
            using (StreamReader sw = new StreamReader(path))
            {
                while (sw.EndOfStream != true)
                {
                    workingFile = sw.ReadLine();
                }
                sw.Close();
            }

            return workingFile;
        }
    }
}