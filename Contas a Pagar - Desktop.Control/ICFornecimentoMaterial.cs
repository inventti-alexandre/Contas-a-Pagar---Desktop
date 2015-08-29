using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICFornecimentoMaterial" in both code and config file together.
    [ServiceContract]
    public interface ICFornecimentoMaterial
    {
        [OperationContract]
        string Inserir(FornecimentoMaterial oFornecimentoMaterial);

        [OperationContract(AsyncPattern = true)]
        Task<List<FornecimentosMateriais>> SelecionarTodosViewAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<FornecimentoMaterial>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Material>> SelecionarTodosMateriaisAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<RelacaoFornecimento>> SelecionarTodosFornecimentos();

        [OperationContract]
        List<DetalhesFornecimento_Result> SelecionarTodosDetalhesFornecimentos(int Fornecimento);

        [OperationContract(AsyncPattern = true)]
        Task<List<RelacaoFornecimento>> SelecionarTodosFornecimentosCriterio(string Criterio, string Escolha);

        [OperationContract]
        bool FornecimentoExiste(int FornecimentoID);

        [OperationContract(AsyncPattern = true)]
        Task<List<NumFornecimentosPorEmpresa>> SelecionarTodosFornecimentosPorEmpresa();

        [OperationContract]
        List<TodosFornecimentos_Result> SelecionarTodosFornecimentosBasico(int fornecedor);

        [OperationContract]
        string CancelarFornecimento(int Fornecimento, bool Cancelado);

        [OperationContract]
        List<FornecimentoMaterial> SelecionarTodosNaoCancelados();

        [OperationContract(AsyncPattern = true)]
        Task<List<NumFornecimentosPorEmpresa>> SelecionarTodosFornecimentosPorEmpresaPesquisa(string Criterio, string Escolha);
    }
}