using System;

namespace ContagemCedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cedulas = new int[] {100, 50, 20, 10, 5, 2, 1};
            var inputValue = Int32.Parse(Console.ReadLine());
            var numCedulas = new int[7];

            Console.WriteLine(inputValue);
            
            if (inputValue >= 100) {
                numCedulas[0] = inputValue / 100;
                inputValue = inputValue % 100;
            }

            if (inputValue >= 50) {
                numCedulas[1] = inputValue / 50;
                inputValue -= (inputValue / 50) * 50;
            }

            if (inputValue >= 20) {
                numCedulas[2] = inputValue / 20;
                inputValue -= (inputValue / 20) * 20;
            }

            if (inputValue >= 10) {
                numCedulas[3] = inputValue / 10;
                inputValue -= (inputValue / 10) * 10;
            }

            if (inputValue >= 5) {
                numCedulas[4] = inputValue / 5;
                inputValue -= (inputValue / 5) * 5;
            }

            if (inputValue >= 2) {
                numCedulas[5] = inputValue / 2;
                inputValue -= (inputValue / 2) * 2;
            }

            if (inputValue >= 1) {
                numCedulas[6] = inputValue;
            }

            for (var i = 0; i < cedulas.Length; i++)
            {
                Console.WriteLine(numCedulas[i] + " nota(s) de R$ " + cedulas.GetValue(i) + ",00");
            }
            // Console.WriteLine(numCedulas[0] + " nota(s) de R$" + cedulas.GetValue(0) + ",00");
            // Console.WriteLine(numCedulas[1] + " nota(s) de R$" + cedulas.GetValue(1) + ",00");
            // Console.WriteLine(numCedulas[2] + " nota(s) de R$" + cedulas.GetValue(2) + ",00");
            // Console.WriteLine(numCedulas[3] + " nota(s) de R$" + cedulas.GetValue(3) + ",00");
            // Console.WriteLine(numCedulas[4] + " nota(s) de R$" + cedulas.GetValue(4) + ",00");
            // Console.WriteLine(numCedulas[5] + " nota(s) de R$" + cedulas.GetValue(5) + ",00");
            // Console.WriteLine(numCedulas[6] + " nota(s) de R$" + cedulas.GetValue(6) + ",00");
        }
    }
}