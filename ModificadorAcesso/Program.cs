using System;

namespace ModificadorAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassePublica publica = new ClassePublica();
            publica.MinhaPropInternal = 25;
        }
    }
}