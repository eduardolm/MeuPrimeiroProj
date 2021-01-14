using System;

namespace CoxinhaBueno
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            Console.WriteLine($"{Decimal.Parse(input[0]) / Decimal.Parse(input[1]):N2}");
        }
    }
}