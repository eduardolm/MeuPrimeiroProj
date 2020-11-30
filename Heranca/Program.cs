using System;
using ModificadorAcesso;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
             * Antes era instanciado dessqa forma:
             * 
             * Adulto pessoa = new Adulto()
             * {
             * Nome = "Joana Silva",
             * Id = 1,
             * DataDeNascimento = new DateTime(1988, 09, 30),
             * SexoFeminino = true
             * };
             */
            Adulto pessoa = new Adulto(1, "Joana Silva"); // Mudança na forma de criação do objeto

            pessoa.DataDeNascimento = new DateTime(1988, 09, 30);
            pessoa.SexoFminino = true;

            CriancaPequena pessoa1 = new CriancaPequena(2, "David Santos");
        
            pessoa1.DataDeNascimento = new DateTime(2018, 03, 06);
            pessoa1.SexoFminino = false;
            
            
            pessoa.Comer();
            pessoa.TomarBanho();
            pessoa.Andar();
            Adulto.DizerBomDia(); // Chamada de um método estático (não pode ser instanciado)
            Console.WriteLine();
            
            pessoa1.Comer();
            pessoa1.TomarBanho();
            pessoa1.Andar();
            
            // Aula de modificadores de acesso:
            ClassePublica publica = new ClassePublica();
            publica.MinhaPropPublica = 10;
            
            Console.WriteLine($"A soma é: {Calculo.Somar(10, 15)}");

            TesteCascata testeCascata = new TesteCascata(1, "Eduardo");
            testeCascata.SexoFminino = false;
            testeCascata.DataDeNascimento = DateTime.Today;
            testeCascata.Comer();
        }
    }
    
    // Sempre colocar apenas 1 classe por arquivo.
    class MyClass : ClassePublica
    {
        public void MeuMetodo()
        {
            base.MinhaPropProtectedInternal = 15;
        }
        
    }
}