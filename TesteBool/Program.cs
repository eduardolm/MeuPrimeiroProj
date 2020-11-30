using System;
using System.IO;
using System.Reflection;

namespace TesteBool
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = true;
            if(!teste)
                Console.WriteLine("falso");
            else
                Console.WriteLine("true");
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Unit\Application\FakeData\Names.txt");

            var path = AppDomain.CurrentDomain.BaseDirectory.Split("bin");
            
            foreach (var VARIABLE in path)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}