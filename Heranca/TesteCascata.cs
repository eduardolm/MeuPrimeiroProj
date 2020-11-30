namespace Heranca
{
    public class TesteCascata : Adulto
    {
        public TesteCascata(int id, string nome) : base(id, nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}