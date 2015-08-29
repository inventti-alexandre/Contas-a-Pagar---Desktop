using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICContaCorrente" in both code and config file together.
    [ServiceContract]
    public interface ICContaCorrente
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(ContaCorrente oContaCorrente);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(ContaCorrente oContaCorrente);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(string Conta);

        [OperationContract(AsyncPattern = true)]
        Task<List<ContaCorrente>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<ContaCorrente>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract(AsyncPattern = true)]
        Task<List<PesquisarCC>> SelecionarTodosViewAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<PesquisarCC>> SelecionarTodosViewCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool ContaCorrenteExiste(string Conta);
    }
}