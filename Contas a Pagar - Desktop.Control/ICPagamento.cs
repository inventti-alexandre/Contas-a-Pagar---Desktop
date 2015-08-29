﻿using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICPagamento" in both code and config file together.
    [ServiceContract]
    public interface ICPagamento
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Pagamento oPagamento);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Pagamento oPagamento);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Pagamento>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Pagamento>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool PagamentoExiste(int ID);
    }
}