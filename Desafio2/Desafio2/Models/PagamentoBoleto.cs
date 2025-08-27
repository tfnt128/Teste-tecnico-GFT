namespace Desafio2.Models
{
    public class PagamentoBoleto: Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Gerando boleto bancário...");
        }
    }
}
