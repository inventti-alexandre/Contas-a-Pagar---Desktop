using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICLancamento" in both code and config file together.
    [ServiceContract]
    public interface ICLancamento
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Lancamento oLancamento);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Lancamento oLancamento);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Lancamento>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Lancamento>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool LancamentoExiste(int ID);
    }
}