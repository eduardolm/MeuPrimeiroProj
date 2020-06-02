using System;

namespace MeuPrimeiroProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello World!");
            
            // Operadores Aritméticos:

            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 5;
            var divisao = 10 / 5;
            var mod = 10 % 7;
            
            Console.WriteLine($"Resultado da soma: {soma}");
            Console.WriteLine($"Resultado da subtração: {subtracao}");
            Console.WriteLine($"Resultado da multiplicação: {multiplicacao}");
            Console.WriteLine($"Resultado da divisão: {divisao}");
            Console.WriteLine($"Resto da divisão de 10 / 7: {mod}");
            
            // Operadores Lógicos:

            // Operador E (&&)
            var Everdadeiro = true && true; // Retorna true se ambas as condições são satisfeitas
            var Efalso1 = true && false; // Retorna false se qualquer uma das condições for falsa
            var Efalso2 = false && true; // Retorna false se qualquer uma das condições for falsa
            var Efalso3 = false && false; // Retorna false se pelo menos uma das condições for falsa

            
            // Operador OU (||)
            var OuVerdadeiro = true || true; // Retorna true
            var OuVerdadeiro1 = false || true; // Retorna true
            var OuVerdadeiro2 = true || false; // Retorna true
            var OuFalso = false || false; // Retorna false
            
            Console.WriteLine(Everdadeiro);
            Console.WriteLine(Efalso1);
            Console.WriteLine(Efalso2);
            Console.WriteLine(Efalso3);
            
            Console.WriteLine(OuVerdadeiro);
            Console.WriteLine(OuVerdadeiro1);
            Console.WriteLine(OuVerdadeiro2);
            Console.WriteLine(OuFalso);

            
            // Negação da afirmação
            var falsoNegado = !false; // Retorna true
            var veradeiroNegado = !true; // Retorna false
            
            Console.WriteLine(falsoNegado);
            Console.WriteLine(veradeiroNegado);

            var textoCompleto = "Testando atribuição de diversos tipos de dados";
            
            Console.WriteLine(textoCompleto);
            

        }
    }
}