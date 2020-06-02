using System;

namespace Heranca
{
    public class Adulto : Pessoa
    {
        public Adulto(int id, string nome) : base(id, nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
        public override void Andar()
        {
            Console.WriteLine($"{Nome} começou a caminhar");
        }

        public static void DizerBomDia()
        {
            Console.WriteLine("Bom dia!");
        }
    }
}