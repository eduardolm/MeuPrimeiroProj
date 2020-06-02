using System;

namespace ClasseObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cao torsten = new Cao();
            torsten.Id = 1;
            torsten.Nome = "Torsten";
            torsten.CorPelo = "Marrom";
            torsten.Porte = "Médio";
            torsten.NomeDono = "Eduardo";
            
            torsten.Comer();
            Console.WriteLine(torsten.Latir());
            torsten.Passear(false);

        }
    }
}