using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICPlanoContas" in both code and config file together.
    [ServiceContract]
    public interface ICPlanoContas
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(PlanoContas oPlanoContas);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(PlanoContas oPlanoContas);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(string Conta);

        [OperationContract(AsyncPattern = true)]
        Task<List<PlanoContas>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<PlanoContas>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool PlanoContasExiste(string Conta);
    }
}