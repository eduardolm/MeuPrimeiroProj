using Xunit;

namespace TesteException
{
    public class Program_Test
    {
        [Fact]
        public void Should_Be_Unique_Ids_For_Teams()
        {
            MyClass teste = new MyClass();
            Assert.Throws<UniqueIdentifierException>(() => teste.Teste());
        }
    }
}