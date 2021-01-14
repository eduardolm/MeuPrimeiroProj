using System;

namespace ValidacoNotaNovo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = new double[2];
            double grade = 0.0;
            int response = 1;
            int count = 0;

            while (response != 2)
            {
                while (count != 2)
                {
                    grade = double.Parse(Console.ReadLine());

                    if (grade >= 0 && grade <= 10)
                    {
                        grades[count] = grade;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }
                Console.WriteLine($"media = {((grades[0] + grades[1]) / 2).ToString("N2")}");
                count = 0;
                response = 0;

                while (response < 1 || response > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    response = Int32.Parse(Console.ReadLine());
                }
            }

        }
    }
}