using System;
using System.Collections.Generic;

namespace ValidacaoDeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            double grade = 0.0;
            int count = 0;

            while (count != 2)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 0 && grade <= 10)
                {
                    grades.Add(grade);
                    count++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            Console.WriteLine($"media = {((grades[0] + grades[1]) / 2).ToString("N2")}");
        }
    }
}