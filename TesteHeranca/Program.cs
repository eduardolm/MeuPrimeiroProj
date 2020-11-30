using System;
using Microsoft.VisualBasic.CompilerServices;

namespace TesteHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericEntity entity = new GenericEntity();
            entity.Name = "Eduardo";

            Console.WriteLine("Nome: "+entity.Name + " , Id: " + entity.Id);
            var edu = true;

            Console.WriteLine(edu.ToString());
        }
    }
}