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

        public string Comer()
        {
            return $"{Nome} começou a comer";
        }

        public string Latir()
        {
            return "Au, au au";
        }

        public string Passear(bool estaChovendo)
        {
            if (estaChovendo)
            {
                return $"Sinto muito, mas o {Nome} não poderá passear, pois está chovendo";
            }
            else
            {
                return $"{Nome} foi passear";
            }
        }
        
    }
}