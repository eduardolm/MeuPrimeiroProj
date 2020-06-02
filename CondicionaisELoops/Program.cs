using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CondicionaisELoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condicionais
            
            Console.WriteLine("Informe a sua idade:");
            int.TryParse(Console.ReadLine(), out int idade); // int.TryParse tenta converter string para int. Se não for possível, escreve 0 na variável

            
            // If, else if, else
            if(idade < 12)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if(idade >= 12 && idade < 18)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else
            {
                Console.WriteLine("Você é um adulto");
            }

            
            // Condicional ternária
            string mensagem = idade >= 18 ? "Você é maior de idade" : "Você é menor de idade";
            Console.WriteLine(mensagem);
            
            Console.WriteLine("Informe seu mês de nascimento");
            var mes = Console.ReadLine();

            
            // Switch
            switch (mes.ToLower())
            {
                case "dezembro":
                case "janeiro":
                case "fevereiro":
                    Console.WriteLine("Você nasceu no verão");
                    break;
                case "março":
                case "abril":
                case "maio":
                    Console.WriteLine("Você nasceu no outono");
                    break;
                case "junho":
                case "julho":
                case "agosto":
                    Console.WriteLine("Você nasceu no inverno");
                    break;
                case "setembro":
                case "outubro":
                case "novembro":
                    Console.WriteLine("Você nasceu na primavera");
                    break;
                default:
                    Console.WriteLine("Mês não reconhecido");
                    break;
            }
            
            // List e Array
            string[] nomes = new string[5]; // Array: Obrigatório definir o tamanho na declaração
            nomes[0] = "Eduardo";
            nomes[1] = "Anne";
            nomes[2] = "Fernanda";
            nomes[3] = "Raquel";
            nomes[4] = "Fabiana";

            Console.WriteLine($"\nNome 1: {nomes[0]}");
            Console.WriteLine($"Nome 2: {nomes[1]}");
            Console.WriteLine($"Nome 3: {nomes[2]}");
            
            // List
            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("Marzano");
            sobrenomes.Add("Lodi");
            sobrenomes.Add("Zimmermann");
            sobrenomes.Add("Matos");
            sobrenomes.Add("Silva");
            sobrenomes.Add("Correa");
            
            Console.WriteLine();
            sobrenomes.ForEach(Console.WriteLine); // Forma de imprimir itens de uma lista
            Console.WriteLine();
            
            // Loops

            // For
            for (int i = 0; i < sobrenomes.Count; i++)
            {
                Console.WriteLine($"Sobrenome {i + 1}: {sobrenomes[i]}");
            }
            Console.WriteLine();
            
            // foreach
            foreach (string sobrenome in sobrenomes)
            {
                Console.WriteLine($"Sobrenome por foreach: {sobrenome}");
            }
            Console.WriteLine();
            
            // Outra forma de foreach (em geral usado paa List
            sobrenomes.ForEach(sobrenome => Console.WriteLine($"Sobrenome por foreach1: {sobrenome}"));
            Console.WriteLine();

            // While invertido
            int x = sobrenomes.Count - 1;
            while (x >= 0)
            {
                Console.WriteLine($"Sobrenome por while invertido: {sobrenomes[x]}");
                x--;
            }
            Console.WriteLine();

            
            // Do - While
            int y = 0;
            do
            {
                Console.WriteLine($"Nome por do-while: {nomes[y]}");
                y++;
            } while (y < nomes.Length);
            
            // string[] topStatesByArea = new string[10];
            Acronym[] states = (Acronym[])Enum.GetValues(typeof(Acronym)); // Creates an Array from Enum
            Console.WriteLine(String.Join(Environment.NewLine, states));
            Console.WriteLine();
            Array.Reverse(states);
            foreach (var state in states)
            {
                Console.WriteLine(state);
            }
            
            Console.WriteLine("\nSaída: \n");
            string[] topStatesByAera = new string[10];
            for (var i = 0; i < 10; i++)
            {
                topStatesByAera[i] = states[i].ToString();
                Console.WriteLine(topStatesByAera[i]);
            }

            Weight pessoa = new Weight();
            pessoa.Name = "Fernanda";
            pessoa.Age = 38;
            pessoa.Peso = 95;
            Console.WriteLine();
            Console.WriteLine(pessoa.Name);
            Console.WriteLine(pessoa.Age);
            Console.WriteLine(pessoa.Peso);

        }
        public enum Acronym
        {
            AC = 164123,
            AL = 27778,
            AP = 142828,
            AM = 1559159,
            BA = 564733,
            CE = 148920,
            DF = 5779,
            ES = 46095,
            GO = 340111,
            MA = 331937,
            MT = 903366,
            MS = 357145,
            MG = 586522,
            PA = 1247954,
            PB = 56585,
            PR = 199307,
            PE = 98311,
            PI = 251577,
            RJ = 43780,
            RN = 52811,
            RS = 281730,
            RO = 237590,
            RR = 224300,
            SC = 95736,
            SP = 248222,
            SE = 21915,
            TO = 277720
        }
        
    }

    public class Pessoa
    {
        public Pessoa(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Pessoa()
        {
        }

        public string Name { get; set; }
        
        public int Age { get; set; }
    }

    public class Weight : Pessoa
    {
        public Weight(string name, int age, int peso)
        {
            this.Name = name;
            this.Age = age;
            this.Peso = peso;
        }

        public Weight()
        {
            
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Peso { get; set; }
    

    }
}