using System;

namespace ValidatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var edu = new Supplier();
            edu.Address = "dsvfhgh";
            edu.Cnpj = "66931590000184";
            edu.Email = "sdgfj@hkg";
            edu.Phone = "dsfgjskg";
            edu.CompanyName = "sdfhskg";
            edu.TradingName = "sdghjsdgk";
            
            var boo = new Supplier();
            boo.Address = "dsvfhgh";
            boo.Cnpj = "66931590000184";
            boo.Email = "sdgfj@hkg";
            boo.Phone = "dsfgjskg";
            boo.CompanyName = "sdfhskg";
            boo.TradingName = "oba";
            
            var compare = new SupplierComparer();

            Console.WriteLine($"São iguais: {compare.Equals(edu, boo)}");
            Console.WriteLine(compare.GetHashCode(edu));
            Console.WriteLine(compare.GetHashCode(boo));

            Console.WriteLine(edu.Id);
            
            var valid = new SupplierValidator();
            var result = valid.Validate(edu);

            if (result.IsValid)
            {
                Console.WriteLine("DEU CERTO");
            }
            else
            {
                Console.WriteLine("ERRO");

            }

        }
    }
}