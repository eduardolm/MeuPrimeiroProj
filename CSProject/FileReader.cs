using System;
using System.Collections.Generic;
using System.IO;

namespace CSProject
{
    public class FileReader
    {

        public List<Staff> ReadFile()
        {
            string filePath = "E:\\Eduardo\\Documents\\RiderProjects\\MeuPrimeiroProj\\CSProject\\static\\input.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while(sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                };
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}