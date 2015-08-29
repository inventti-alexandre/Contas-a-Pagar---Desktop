using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICAgencia" in both code and config file together.
    [ServiceContract]
    public interface ICAgencia
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Agencia oAgencia);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Agencia oAgencia);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Agencia>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Agencia>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract(AsyncPattern = true)]
        Task<List<PesquisaAgencia>> SelecionarTodosViewAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<PesquisaAgencia>> SelecionarTodosViewCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool AgenciaExiste(int ID);
    }
}