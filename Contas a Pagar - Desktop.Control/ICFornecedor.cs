using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICFornecedor" in both code and config file together.
    [ServiceContract]
    public interface ICFornecedor
    {
        [OperationContract(AsyncPattern = true)]
        Task<string> InserirAsync(Fornecedor oFornecedor);

        [OperationContract(AsyncPattern = true)]
        Task<string> AlterarAsync(Fornecedor oFornecedor);

        [OperationContract(AsyncPattern = true)]
        Task<string> ExcluirAsync(int ID);

        [OperationContract(AsyncPattern = true)]
        Task<List<Fornecedor>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Fornecedor>> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [OperationContract]
        bool FornecedorExiste(int IDFornecedor);
    }
}