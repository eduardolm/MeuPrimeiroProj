using System;

namespace QuadradoEAoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = Int32.Parse(Console.ReadLine() ?? string.Empty);

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}