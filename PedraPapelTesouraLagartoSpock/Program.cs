using System;

namespace PedraPapelTesouraLagartoSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Int32.Parse(Console.ReadLine()!);
            var count = 1;
            string[] line = new string[2];
            
            while (count <= number)
            {
                line = Console.ReadLine()?.Split(" ");

                switch (line[0])
                {
                    case "pedra":
                    {
                        switch (line[1])
                        {
                            case "lagarto":
                            case "tesoura":
                                Console.WriteLine($"Caso #{count}: Bazinga!");
                                break;
                            case "pedra":
                                Console.WriteLine($"Caso #{count}: De novo!");
                                break;
                            default:
                                Console.WriteLine($"Caso #{count}: Raj trapaceou!");
                                break;
                        }

                        break;
                    }
                    case "papel":
                    {
                        switch (line[1])
                        {
                            case "pedra":
                            case "Spock":
                                Console.WriteLine($"Caso #{count}: Bazinga!");
                                break;
                            case "papel":
                                Console.WriteLine($"Caso #{count}: De novo!");
                                break;
                            default:
                                Console.WriteLine($"Caso #{count}: Raj trapaceou!");
                                break;
                        }
                        break;
                    }
                    case "tesoura":
                    {
                        switch (line[1])
                        {
                            case "lagarto":
                            case "papel":
                                Console.WriteLine($"Caso #{count}: Bazinga!");
                                break;
                            case "tesoura":
                                Console.WriteLine($"Caso #{count}: De novo!");
                                break;
                            default:
                                Console.WriteLine($"Caso #{count}: Raj trapaceou!");
                                break;
                        }
                        break;
                    }
                    case "lagarto":
                    {
                        switch (line[1])
                        {
                            case "papel":
                            case "Spock":
                                Console.WriteLine($"Caso #{count}: Bazinga!");
                                break;
                            case "lagarto":
                                Console.WriteLine($"Caso #{count}: De novo!");
                                break;
                            default:
                                Console.WriteLine($"Caso #{count}: Raj trapaceou!");
                                break;
                        }
                        break;
                    }
                    case "Spock":
                    {
                        switch (line[1])
                        {
                            case "pedra":
                            case "tesoura":
                                Console.WriteLine($"Caso #{count}: Bazinga!");
                                break;
                            case "Spock":
                                Console.WriteLine($"Caso #{count}: De novo!");
                                break;
                            default:
                                Console.WriteLine($"Caso #{count}: Raj trapaceou!");
                                break;
                        }
                        break;
                    }
                }
                count++;
            }
        }
    }
}