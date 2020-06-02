using System;

namespace ClasseObjeto
{
    public class Cao
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Porte { get; set; }

        public string NomeDono { get; set; }

        public string CorPelo { get; set; }

        public void Comer()
        {
            Console.WriteLine($"{Nome} começou a comer");
        }

        public string Latir()
        {
            return "Au, au au";
        }

        public void Passear(bool estaChovendo)
        {
            if (estaChovendo)
            {
                Console.WriteLine($"Sinto muito, mas o {Nome} não poderá passear, pois está chovendo");
            }
            else
            {
                Console.WriteLine($"{Nome} foi passear");
            }
        }
        
    }
}