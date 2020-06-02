using System;

namespace Heranca
{
    public abstract class Pessoa
    {
        public Pessoa(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public int Id { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Nome { get; set; }

        public bool SexoFminino { get; set; }

        public virtual void Comer()
        {
            Console.WriteLine($"Eu, {Nome}, peguei os talheres e comecei a comer");
        }

        public virtual void TomarBanho()
        {
            Console.WriteLine($"Eu, {Nome}, estou entrando no banho");
        }

        public abstract void Andar();

    }
}