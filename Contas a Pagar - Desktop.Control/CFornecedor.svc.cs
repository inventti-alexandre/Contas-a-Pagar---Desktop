using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFornecedor" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CFornecedor.svc or CFornecedor.svc.cs at the Solution Explorer and start debugging.
    public class CFornecedor : ICFornecedor
    {
        public async Task<string> AlterarAsync(Fornecedor oFornecedor)
        {
            return await Fornecedor.AlterarAsync(oFornecedor);
        }

        public async Task<string> ExcluirAsync(int ID)
        {
            return await Fornecedor.ExcluirAsync(ID);
        }

        public async Task<string> InserirAsync(Fornecedor oFornecedor)
        {
            return await Fornecedor.InserirAsync(oFornecedor);
        }

        public async Task<List<Fornecedor>> SelecionarTodosAsync()
        {
            return await Fornecedor.SelecionarTodosAsync();
        }

        public async Task<List<Fornecedor>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return await Fornecedor.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public bool FornecedorExiste(int IDFornecedor)
        {
            return Fornecedor.FornecedorExiste(IDFornecedor);
        }
    }
}