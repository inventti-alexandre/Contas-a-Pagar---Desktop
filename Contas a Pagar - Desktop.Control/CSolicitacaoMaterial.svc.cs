using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CSolicitacaoMaterial" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CSolicitacaoMaterial.svc or CSolicitacaoMaterial.svc.cs at the Solution Explorer and start debugging.
    public class CSolicitacaoMaterial : ICSolicitacaoMaterial
    {
        public string Inserir(SolicitacaoMaterial oSolicitacaoMaterial)
        {
            return SolicitacaoMaterial.InserirAsync(oSolicitacaoMaterial);
        }

        public async Task<List<SolicitacaoMaterial>> SelecionarTodosAsync()
        {
            return await SolicitacaoMaterial.SelecionarTodosAsync();
        }

        public async Task<List<SolicitacoesMateriais>> SelecionarTodosViewAsync()
        {
            return await SolicitacaoMaterial.SelecionarTodosViewAsync();
        }

        public async Task<List<Material>> SelecionarTodosMateriaisAsync()
        {
            return await SolicitacaoMaterial.SelecionarTodosMateriaisAsync();
        }

        public async Task<List<RelacaoSolicitacao>> SelecionarTodosSolicitacaos()
        {
            return await SolicitacaoMaterial.SelecionarTodosSolicitacoes();
        }

        public List<DetalhesSolicitacao_Result1> SelecionarTodosDetalhesSolicitacaos(int Solicitacao)
        {
            return SolicitacaoMaterial.SelecionarTodosDetalhesSolicitacoes(Solicitacao);
        }

        public Task<List<RelacaoSolicitacao>> SelecionarTodosSolicitacaosCriterio(string Criterio, string Escolha)
        {
            return SolicitacaoMaterial.SelecionarTodosSolicitacoesCriterio(Criterio, Escolha);
        }

        public bool SolicitacaoExiste(int SolicitacaoID)
        {
            return SolicitacaoMaterial.SolicitacaoExiste(SolicitacaoID);
        }

        public async Task<List<SolicitacaoMaterial>> SelecionarTodosNaoAprovadosAsync()
        {
            return await SolicitacaoMaterial.SelecionarTodosNaoAprovadosAsync();
        }

        public async Task<List<SolicitacaoMaterial>> SelecionarTodosAprovadosAsync()
        {
            return await SolicitacaoMaterial.SelecionarTodosAprovadosAsync();
        }

        public string AprovarSolicitacao(int Solicitacao, bool Aprovacao)
        {
            return SolicitacaoMaterial.AprovarSolicitacao(Solicitacao, Aprovacao);
        }

        public async Task<List<NumSolicitacoesPorSetor>> SelecionarTodasSolicitacoesPorSetor()
        {
            return await SolicitacaoMaterial.SelecionarTodasSolicitacoesPorSetor();
        }

        public List<TodasSolicitacoes_Result> SelecionarTodasSolicitacoesBasico(int Setor)
        {
            return SolicitacaoMaterial.SelecionarTodasSolicitacoesBasico(Setor);
        }

        public async Task<List<NumSolicitacoesNaoAprovadosPorSetor>> SelecionarTodasSolicitacoesNaoAprovadosPorSetor()
        {
            return await SolicitacaoMaterial.SelecionarTodasSolicitacoesNaoAprovadosPorSetor();
        }

        public async Task<List<NumSolicitacoesAprovadosPorSetor>> SelecionarTodasSolicitacoesAprovadosPorSetor()
        {
            return await SolicitacaoMaterial.SelecionarTodasSolicitacoesAprovadosPorSetor();
        }

        public List<TodasSolicitacoesAprovadas_Result> SelecionarTodasSolicitacoesBasicoAprovadas(int Setor)
        {
            return SolicitacaoMaterial.SelecionarTodasSolicitacoesBasicoAprovadas(Setor);
        }

        public List<TodasSolicitacoesNaoAprovadas_Result> SelecionarTodasSolicitacoesBasicoNaoAprovadas(int Setor)
        {
            return SolicitacaoMaterial.SelecionarTodasSolicitacoesBasicoNaoAprovadas(Setor);
        }

        public async Task<List<NumSolicitacoesPorSetor>> SelecionarTodasSolicitacoesPorSetorPesquisa(string Criterio, string Escolha)
        {
            return await SolicitacaoMaterial.SelecionarTodasSolicitacoesPorSetorPesquisa(Criterio, Escolha);
        }

        public async Task<List<NumSolicitacoesNaoAprovadosPorSetor>> SelecionarTodasSolicitacoesNaoAprovadosPorSetorPesquisa(string Criterio, string Escolha)
        {
            return await SolicitacaoMaterial.SelecionarTodasSolicitacoesNaoAprovadosPorSetorPesquisa(Criterio, Escolha);
        }

        public async Task<List<NumSolicitacoesAprovadosPorSetor>> SelecionarTodasSolicitacoesAprovadosPorSetorPesquisa(string Criterio, string Escolha)
        {
            return await SolicitacaoMaterial.SelecionarTodasSolicitacoesAprovadosPorSetorPesquisa(Criterio, Escolha);
        }
    }
}