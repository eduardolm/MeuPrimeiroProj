namespace Generics
{
    /*
     * Generics - <T> define um tipo genérico, sem tipagem. A tipagem é fixada em tempo de execução.
     * 'where T : ICalculoValor' - Define que tipo de objeto o genérico T pode aceitar.
     * No caso deste exemplo, o genérico pode aceitar a interface, mas também todas as classes que implementarem
     * essa interface, ou seja, o genérico pode receber CarroUsado, DesenvolvimentoDeSoftware, KiloBuffet
     */
    public class CalculoGenerico<T> where T : ICalculoValor // Toda classe que implementa essa interface tem ValorBruto e Valor Final
    {
        private decimal _imposto = 0.05m;

        private decimal _lucro = 0.10m; // _lucro -> representa prática comum de mercado de nome de var. privada

        public void CalcularValorUnitario(T obj)
        {
            obj.ValorFinal += obj.ValorBruto;
            obj.ValorFinal += obj.ValorBruto * _imposto;
            obj.ValorFinal += obj.ValorBruto * _lucro;
        }

    }
}