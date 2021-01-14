using System;
using System.Collections.Generic;

namespace CompraSupermercado
{
    class MinhaClasse {
        public static void Main (string[] args) {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            string[] lists = new string[totalDeCasosDeTeste];
            List<string> finalList;

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                lists[i] = Console.ReadLine();
                string[] splitList = lists[i].Split(" ");
                HashSet<string> set = new HashSet<string>();

                foreach (var item in splitList)
                {
                    set.Add(item);
                }
                finalList = new List<string>(set);
                finalList.Sort();

                foreach (var item in finalList)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }
    }
}