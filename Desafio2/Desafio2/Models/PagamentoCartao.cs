namespace Desafio2.Models
{
    public class PagamentoCartao : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento via cartão...");
        }
    }
}
