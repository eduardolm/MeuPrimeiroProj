using System;
using System.Collections.Generic;
using System.Linq;

namespace PedroBentoEOMundoDeOz
{
    class Program
    {
        static void Main(string[] args)
        {
            var jewels = new List<string>();

            while (true)
            {
                var jewel = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(jewel))
                {
                    jewels.Add(jewel);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(jewels.Distinct().Count());
        }
    }
}