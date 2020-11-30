using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath =
                "E:\\Eduardo\\Documents\\RiderProjects\\MeuPrimeiroProj\\FileHandlingDemo\\static\\Unicesumar.txt";

            // Try-catch -> If file not found, an exception should be raised and treated accordingly.
            try
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            
            // File.Exists()
            if (File.Exists(readPath))
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
            else
            {
                // Do something else, create file, the works
                Console.WriteLine("File not found");
            }
            
            // Writing to a Text File
            string writePath = "E:\\Eduardo\\Documents\\RiderProjects\\MeuPrimeiroProj\\FileHandlingDemo\\static\\tesfile.txt";

            // Creating file and writing lines to it
            using (StreamWriter sw = new StreamWriter(writePath, true))
            {
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }
            // Reading from created file
            if (File.Exists(writePath))
            {
                using (StreamReader sr = new StreamReader(writePath))
                {
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("File not found!");
            }
            
            Console.WriteLine("============================================");
            
            OpenJson jsonFile = new OpenJson();
            
            string json = jsonFile.ReadFile("answer.json");
            
            Dictionary<string, string> values = 
                JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            
            
            Console.WriteLine(values["cifrado"]);
            
        }
    }
}