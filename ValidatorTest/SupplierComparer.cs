using System.Collections.Generic;

namespace ValidatorTest
{
    public class SupplierComparer : IEqualityComparer<Supplier>
    {
        public bool Equals(Supplier x, Supplier y)
        {
            return (x.Id == y.Id || x.Email.Equals(y.Email) || x.Address.Equals(y.Address) || x.Phone.Equals(y.Phone) || x.Cnpj.Equals(y.Cnpj) || x.CompanyName.Equals(y.CompanyName) || x.TradingName.Equals(y.TradingName));
        }

        public int GetHashCode(Supplier obj)
        {
            return obj.CompanyName.GetHashCode();
        }
    }
}