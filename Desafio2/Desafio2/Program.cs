using Desafio2.Models;
List<Pagamento> pagamentos = new List<Pagamento>();

pagamentos.Add(new PagamentoCartao());
pagamentos.Add(new PagamentoBoleto());
pagamentos.Add(new PagamentoCartao());

foreach (var pagamento in pagamentos)
{
    pagamento.ProcessarPagamento();
}
