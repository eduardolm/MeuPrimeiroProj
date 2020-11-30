using System;

namespace UltrapassandoV
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            int v = 0;
            int count = 0;
            int sum = 0;
            var firstLIne = Console.ReadLine();
            if (!String.IsNullOrEmpty(firstLIne))
            {
                r = int.Parse(firstLIne);
            }

            while (v <= r)
            {
                var secondLine = Console.ReadLine();

                if (!String.IsNullOrEmpty(secondLine)) v = int.Parse(secondLine);

            }
            
            while (sum <= v)
            {
                sum += r;
                r++;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}

