using System;
using System.Linq;

namespace CorridaDeTartarugas
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            string readLine = String.Empty;
            do
            {
                readLine = Console.ReadLine();
                if (! String.IsNullOrEmpty(readLine))
                {
                    quantity = int.Parse(readLine);
                }
                else
                {
                    break;
                }

                string[] line = Console.ReadLine()?.Split(" ");

                int[] newLIne = new int[quantity];

                for (var i = 0; i < line.Length; i++)
                {
                    newLIne[i] = Convert.ToInt32(line[i]);
                }

                if (newLIne.Max() < 10) Console.WriteLine(1);
                if (newLIne.Max() >= 10 && newLIne.Max() < 20) Console.WriteLine(2);
                if (newLIne.Max() >= 20) Console.WriteLine(3);
            } while (!String.IsNullOrEmpty(readLine));
        }
    }
}