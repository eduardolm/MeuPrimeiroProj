using System;

namespace DesafioDIO_01
{
    class Divisao
    {
        static void Main(string[] args)
        {
            var limit = int.Parse(Console.ReadLine() ?? string.Empty);
            if (limit.Equals(null))
            {
                Console.WriteLine("divisao impossivel");
                return;
            }
            for (var i = 0; i < limit; i++) 
            {
                var line = Console.ReadLine().Split(" ");
                var x = double.Parse(line[0]);
                var y = double.Parse(line[1]);
                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    var divisao = x / y; // Digite aqui o calculo da divisao
                    Console.WriteLine(divisao.ToString("N1"));
                }
            }
        }
    }
}