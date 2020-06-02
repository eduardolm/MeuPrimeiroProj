using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Threading;

namespace TiposDeDados
{
    class Program
    {
        public class Mathematics
        {
            public double Root(double number)
            {
                return System.Math.Sqrt(number);
            }

            public double Power(double number, double exp)
            {
                return System.Math.Pow(number, exp);
            }

            public double Round(double number)
            {
                return System.Math.Round(number);
            }
            public List<int> Fibonacci()
            {
                List<int> outputList = new List<int>();
            
                for (var i = 0; i <= 350; i++)
                {
                    var item = Round((1 / Root(5)) * ((Power(((1 + Root(5)) / 2), i)) -
                                                      (Power(((1 - Root(5)) / 2), i))));
                    if (item <= 350)
                    {
                        outputList.Add((int) item);
                    }
                }

                return outputList;
            }

            public bool IsFibonacci(int numberToTest)
            {
                List<int> comparisonList = Fibonacci();
                bool flag = false;
            
                for (int i = 0; i <= comparisonList.Count - 1; i++) 
                {
                    if (numberToTest == comparisonList[i])
                    {
                        return true;
                    }
                }

                return false;
            }
        }
        public class Funcionario
        {
            private int _id;
            public int Id
            {
                get { return this._id;}
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Valor deve ser positivo");
                        this._id = 999;
                    }
                    else
                    {
                        this._id = value;
                    }
                }

            }
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public DateTime DataAdmissao { get; set; }
            
            
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types");
            
            // String: armazena letras e números
            // Classe String
            // var teste = String.Empty -> objeto da classe String com conteúdo nulo (aceita métodos de String)
            // var teste2 = null -> retorna ERRO se chamados métodos de String
            
            // char: armazena 1 caractere (letra ou número)
            
            // DateTime: armazena datas com ou sem horário
            
            // int: armazena números inteiros
            
            // decimal: números reais
            
            // bool: Boolean
            
            // List, Array: tipo de dados posicional, onde pode-se armazenar dados diferentes em cada uma das posições

            List<String> lista = new List<string>() {"Eduardo", "Fernanda", "Anne"};
            
            Console.WriteLine(string.Join(", ", lista));
            
            lista.ForEach(Console.WriteLine);

            double teste = 10.5;
            Console.WriteLine(teste);
            decimal teste2 = 10;
            
            // Conversões Implícitas: int -> float

            int varInt = 20;
            long varLong = varInt;

            float varFloat = 10.5f;
            double varDouble = varFloat;

            char varChar = 'T';
            int varInt1 = varChar;

            string meuTexto = $"Neste texto vamos testar a conversão implícita " +
                              $"de variável inteira {varInt} e variável float {varFloat}";
            
            

            // Conversoes Explícitas: (cast) 
            
            Funcionario funcionario = new Funcionario();
            funcionario.Id = -1;
            funcionario.Nome = "Eduardo";
            funcionario.DataNascimento = new DateTime(1978, 2, 12);
            funcionario.DataAdmissao = new DateTime(2018, 9, 2);
            
            Console.WriteLine(funcionario.Id);
            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.DataNascimento);
            Console.WriteLine(funcionario.DataAdmissao);
            
            Mathematics mathematics = new Mathematics();
            List<int> lista1 = new List<int>(mathematics.Fibonacci());
            lista1.ForEach(Console.WriteLine);
            bool validacao = mathematics.IsFibonacci(-144);
            Console.WriteLine(validacao);

            string texto = "Eduardo é uma pessoa de São Paulo. Está morando em Blumenau.";
            Console.WriteLine(texto.ToLower());

        }
    }
}