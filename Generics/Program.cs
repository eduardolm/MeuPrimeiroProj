using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Generics
                DesenvolvimentoDeSoftware dev = new DesenvolvimentoDeSoftware();
                CalculoGenerico<DesenvolvimentoDeSoftware> calcDev = new CalculoGenerico<DesenvolvimentoDeSoftware>();
                calcDev.CalcularValorUnitario(dev);

                Console.WriteLine($"O valor final do desenvolvimento é {dev.ValorFinal:C}");

                CarroUsado carro = new CarroUsado();
                CalculoGenerico<CarroUsado> calcCarro = new CalculoGenerico<CarroUsado>();
                calcCarro.CalcularValorUnitario(carro);

                Console.WriteLine($"O valor final do carro é: {carro.ValorFinal:C}");

                KiloBuffet comida = new KiloBuffet();
                CalculoGenerico<KiloBuffet> quiloComida = new CalculoGenerico<KiloBuffet>();
                quiloComida.CalcularValorUnitario(comida);

                Console.WriteLine($"O quilo do buffet é {comida.ValorFinal}");

                // Extension Methods
                var texto = "Olá, meu   nome é Eduardo??? Sim... o sobrenome é Marzano!";
                Console.WriteLine($"A frase possui {texto.ContadorDePalavras()} palavras");

                string erro = null;
                erro.ContadorDePalavras();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Deu erro! => {e.Message}");
            }
            finally
            {
                // Ações como fechar arquivos, encerrar conexão com DB, etc
                Console.WriteLine("Ação a ser executada independentemente de erro ou sucesso no programa");
            }
        }
    }
}