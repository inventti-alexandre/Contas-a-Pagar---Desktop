using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFornecimentoMaterial" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CFornecimentoMaterial.svc or CFornecimentoMaterial.svc.cs at the Solution Explorer and start debugging.
    public class CFornecimentoMaterial : ICFornecimentoMaterial
    {
        public string Inserir(FornecimentoMaterial oFornecimentoMaterial)
        {
            return FornecimentoMaterial.InserirAsync(oFornecimentoMaterial);
        }

        public async Task<List<FornecimentoMaterial>> SelecionarTodosAsync()
        {
            return await FornecimentoMaterial.SelecionarTodosAsync();
        }

        public async Task<List<FornecimentosMateriais>> SelecionarTodosViewAsync()
        {
            return await FornecimentoMaterial.SelecionarTodosViewAsync();
        }

        public async Task<List<Material>> SelecionarTodosMateriaisAsync()
        {
            return await FornecimentoMaterial.SelecionarTodosMateriaisAsync();
        }

        public async Task<List<RelacaoFornecimento>> SelecionarTodosFornecimentos()
        {
            return await FornecimentoMaterial.SelecionarTodosFornecimentos();
        }

        public List<DetalhesFornecimento_Result> SelecionarTodosDetalhesFornecimentos(int Fornecimento)
        {
            return FornecimentoMaterial.SelecionarTodosDetalhesFornecimentos(Fornecimento);
        }

        public Task<List<RelacaoFornecimento>> SelecionarTodosFornecimentosCriterio(string Criterio, string Escolha)
        {
            return FornecimentoMaterial.SelecionarTodosFornecimentosCriterio(Criterio, Escolha);
        }

        public bool FornecimentoExiste(int FornecimentoID)
        {
            return FornecimentoMaterial.FornecimentoExiste(FornecimentoID);
        }

        public async Task<List<NumFornecimentosPorEmpresa>> SelecionarTodosFornecimentosPorEmpresa()
        {
            return await FornecimentoMaterial.SelecionarTodosFornecimentosPorEmpresa();
        }

        public List<TodosFornecimentos_Result> SelecionarTodosFornecimentosBasico(int fornecedor)
        {
            return FornecimentoMaterial.SelecionarTodosFornecimentosBasico(fornecedor);
        }

        public string CancelarFornecimento(int Fornecimento, bool Cancelado)
        {
            return FornecimentoMaterial.CancelarFornecimento(Fornecimento, Cancelado);
        }

        public List<FornecimentoMaterial> SelecionarTodosNaoCancelados()
        {
            return FornecimentoMaterial.SelecionarTodosNaoCancelados();
        }

        public Task<List<NumFornecimentosPorEmpresa>> SelecionarTodosFornecimentosPorEmpresaPesquisa(string Criterio, string Escolha)
        {
            return FornecimentoMaterial.SelecionarTodosFornecimentosPorEmpresaPesquisa(Criterio, Escolha);
        }
    }
}