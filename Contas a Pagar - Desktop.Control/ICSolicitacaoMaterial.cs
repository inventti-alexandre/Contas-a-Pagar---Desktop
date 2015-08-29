using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICSolicitacaoMaterial" in both code and config file together.
    [ServiceContract]
    public interface ICSolicitacaoMaterial
    {
        [OperationContract]
        string Inserir(SolicitacaoMaterial oSolicitacaoMaterial);

        [OperationContract(AsyncPattern = true)]
        Task<List<SolicitacoesMateriais>> SelecionarTodosViewAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<SolicitacaoMaterial>> SelecionarTodosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<Material>> SelecionarTodosMateriaisAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<RelacaoSolicitacao>> SelecionarTodosSolicitacaos();

        [OperationContract]
        List<DetalhesSolicitacao_Result1> SelecionarTodosDetalhesSolicitacaos(int Solicitacao);

        [OperationContract(AsyncPattern = true)]
        Task<List<RelacaoSolicitacao>> SelecionarTodosSolicitacaosCriterio(string Criterio, string Escolha);

        [OperationContract]
        bool SolicitacaoExiste(int SolicitacaoID);

        [OperationContract(AsyncPattern = true)]
        Task<List<SolicitacaoMaterial>> SelecionarTodosNaoAprovadosAsync();

        [OperationContract(AsyncPattern = true)]
        Task<List<SolicitacaoMaterial>> SelecionarTodosAprovadosAsync();

        [OperationContract]
        string AprovarSolicitacao(int Solicitacao, bool Aprovacao);

        [OperationContract(AsyncPattern = true)]
        Task<List<NumSolicitacoesPorSetor>> SelecionarTodasSolicitacoesPorSetor();

        [OperationContract]
        List<TodasSolicitacoes_Result> SelecionarTodasSolicitacoesBasico(int Setor);

        [OperationContract(AsyncPattern = true)]
        Task<List<NumSolicitacoesNaoAprovadosPorSetor>> SelecionarTodasSolicitacoesNaoAprovadosPorSetor();

        [OperationContract(AsyncPattern = true)]
        Task<List<NumSolicitacoesAprovadosPorSetor>> SelecionarTodasSolicitacoesAprovadosPorSetor();

        [OperationContract]
        List<TodasSolicitacoesAprovadas_Result> SelecionarTodasSolicitacoesBasicoAprovadas(int Setor);

        [OperationContract]
        List<TodasSolicitacoesNaoAprovadas_Result> SelecionarTodasSolicitacoesBasicoNaoAprovadas(int Setor);

        [OperationContract(AsyncPattern = true)]
        Task<List<NumSolicitacoesPorSetor>> SelecionarTodasSolicitacoesPorSetorPesquisa(string Criterio, string Escolha);

        [OperationContract(AsyncPattern = true)]
        Task<List<NumSolicitacoesNaoAprovadosPorSetor>> SelecionarTodasSolicitacoesNaoAprovadosPorSetorPesquisa(string Criterio, string Escolha);

        [OperationContract(AsyncPattern = true)]
        Task<List<NumSolicitacoesAprovadosPorSetor>> SelecionarTodasSolicitacoesAprovadosPorSetorPesquisa(string Criterio, string Escolha);
    }
}