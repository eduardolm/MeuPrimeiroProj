using ClasseObjeto;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace MeuPrimeiroTeste_xUnit.ClasseObjeto
{
    public class ClasseObjetoTest
    {
        [Fact]
        public void Verificar_latido_cachorro()
        {
            // Arrange
            Cao caoGenerico = new Cao();
            
            // Act
            var latido = caoGenerico.Latir();
            
            // Assert
            Assert.Equal("Au, au au", latido);
        }

        [Fact]
        public void Verificar_se_o_cao_foi_passear()
        {
            // Arrange
            Cao caoGenerico = new Cao();
            
            // Act
            var foiPassear = false;

            // Assert
            Assert.Equal($"Sinto muito, mas o {caoGenerico.Nome} não poderá passear, pois está chovendo", caoGenerico.Passear(true));
            Assert.Equal($"{caoGenerico.Nome} foi passear", caoGenerico.Passear(false));
        }

        [Fact]
        public void Verificar_getters_e_setters()
        {
            // Arrange
            Cao caoGenerico = new Cao();
            
            // Act
            caoGenerico.Nome = "Rufus";
            caoGenerico.Id = 1;
            caoGenerico.Porte = "médio";
            caoGenerico.CorPelo = "preto";
            caoGenerico.NomeDono = "Robson";
            
            // Assert
            Assert.Equal("Robson", caoGenerico.NomeDono);
            Assert.Equal("Rufus", caoGenerico.Nome);
            Assert.Equal(1, caoGenerico.Id);
            Assert.Equal("médio", caoGenerico.Porte);
            Assert.Equal("preto", caoGenerico.CorPelo);
            Assert.NotEqual(3, caoGenerico.Id);
            Assert.NotEqual("Pedro", caoGenerico.NomeDono);
        }

        [Fact]
        public void Verificar_se_o_cao_esta_comendo()
        {
            // Arrange
            Cao caoGenerico = new Cao();
            
            // Act
            caoGenerico.Nome = "Totó";
            
            // Assert
            Assert.Equal("Totó começou a comer", caoGenerico.Comer());
        }
    }
}