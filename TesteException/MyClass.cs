using System;

namespace TesteException
{
    public class MyClass
    {
        public void Teste()
        {
            string texto = String.Empty;
            if (texto != null)
            {
                throw new UniqueIdentifierException(String.Empty);
            }
        }
    }
}