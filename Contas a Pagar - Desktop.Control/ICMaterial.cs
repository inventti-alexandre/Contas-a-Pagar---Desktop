using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICMaterial" in both code and config file together.
    [ServiceContract]
    public interface ICMaterial
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Material oMaterial);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Material oMaterial);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Material>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Material>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);
    }
}