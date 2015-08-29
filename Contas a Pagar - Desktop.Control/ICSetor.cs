using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICSetor" in both code and config file together.
    [ServiceContract]
    public interface ICSetor
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Setor oSetor);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Setor oSetor);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Setor>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Setor>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);
    }
}