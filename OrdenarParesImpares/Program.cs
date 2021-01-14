using System;
using System.Collections.Generic;

namespace OrdenarParesImpares
{
    class MinhaClasse {
        public static void Main (string[] args) {
            var totalDeEntradas = int.Parse(Console.ReadLine());
            int[] numbers = new int[totalDeEntradas];
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < totalDeEntradas; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
                else
                {
                    odd.Add(numbers[i]);
                }
            }
            
            even.Sort();
            odd.Sort();
            odd.Reverse();

            foreach (var item in even)
            {
                Console.WriteLine(item);
            }

            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
        }
    }
}