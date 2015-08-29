using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICBanco" in both code and config file together.
    [ServiceContract]
    public interface ICBanco
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Banco oBanco);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Banco oBanco);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Banco>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Banco>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool BancoExiste(int ID);
    }
}