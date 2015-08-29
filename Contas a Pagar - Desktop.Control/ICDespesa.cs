using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICDespesa" in both code and config file together.
    [ServiceContract]
    public interface ICDespesa
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Despesa oDespesa);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Despesa oDespesa);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Despesa>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Despesa>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool DespesaExiste(int ID);
    }
}