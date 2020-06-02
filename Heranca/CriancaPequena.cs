using System;

namespace Heranca
{
    public class CriancaPequena : Pessoa
    {
        public CriancaPequena(int id, string nome) : base(id, nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public override void Comer()
        {
            var sexo = SexoFminino ? "a" : "o"; 
            Console.WriteLine($"Algum adulto dá comida para {sexo} {Nome}");
        }

        public override void TomarBanho()
        {
            var sexo = SexoFminino ? "a" : "o"; 
            Console.WriteLine($"Algum adulto deu banho n{sexo} {Nome}");
        }

        public override void Andar()
        {
            Console.WriteLine($"{Nome} está andando e brincando");
        }
    }
}