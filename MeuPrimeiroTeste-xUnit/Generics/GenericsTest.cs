using System;
using Generics;
using Xunit;

namespace MeuPrimeiroTeste_xUnit.Generics
{
    public class GenericsTest
    {
        [Fact]
        public void Calcular_valor_unitario_dev()
        {
            // Arrange
            DesenvolvimentoDeSoftware dev = new DesenvolvimentoDeSoftware();
            CalculoGenerico<DesenvolvimentoDeSoftware> calcDev = new CalculoGenerico<DesenvolvimentoDeSoftware>();
            
            // Act
            calcDev.CalcularValorUnitario(dev);
            
            // Assert
            Assert.Equal(57.50M, dev.ValorFinal);
            Assert.Equal(50m, dev.ValorBruto);
        }

        [Fact]
        public void Calcular_valor_unitario_carro()
        {
            // Arrange
            CarroUsado carro = new CarroUsado();
            CalculoGenerico<CarroUsado> calcCarro = new CalculoGenerico<CarroUsado>();
            
            // Act
            calcCarro.CalcularValorUnitario(carro);
            
            //Assert
            Assert.Equal(34500m, carro.ValorFinal);
            Assert.Equal(30000m, carro.ValorBruto);
        }

        [Fact]
        public void Calclar_valor_do_quilo()
        {
            // Arrange
            KiloBuffet quilo = new KiloBuffet();
            CalculoGenerico<KiloBuffet> calcQuilo = new CalculoGenerico<KiloBuffet>();
            
            // Act
            calcQuilo.CalcularValorUnitario(quilo);
            
            // Assert
            Assert.Equal(48.30m, quilo.ValorFinal);
            Assert.Equal(42m, quilo.ValorBruto);
        }

        [Theory]
        [InlineData("Olá, meu   nome é Eduardo??? Sim... o sobrenome é Marzano!", 10)]
        [InlineData("Gosto de futebol!", 3)]
        public void Verificar_quantidade_de_palavras(string texto, int valorEsperado)
        {
            // Act
            var count = texto.ContadorDePalavras();

            // Assert
            Assert.Equal(valorEsperado, count);
        }
    }
}