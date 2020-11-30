using System;
using System.ComponentModel.Design;

namespace TestNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Quote quote = new Quote();
            if (quote.Equals(null))
                Console.WriteLine("é nulo");
            else
            {
                Console.WriteLine("\nNão é nulo");
                Console.WriteLine("Ator: "+quote.Actor);
                Console.WriteLine("Personagem: "+quote?.Character);
                if (!string.IsNullOrEmpty(quote.Actor))
                    Console.WriteLine("É nulo ou vazio ->");
                else
                {
                    try
                    {
                        Quote testQuote = new Quote();
                        testQuote.Actor = quote.Actor;
                        testQuote.Character = quote.Character;
                        //Console.WriteLine("Type: " + quote.Actor.GetType());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ERRO: "+e);
                    }
                    finally
                    {
                        Console.WriteLine("Continuando aqui como se nada tivesse ocorrido.");
                    }

                }
            }
        }
    }
}