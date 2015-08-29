using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CContaCorrente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CContaCorrente.svc or CContaCorrente.svc.cs at the Solution Explorer and start debugging.
    public class CContaCorrente : ICContaCorrente
    {
        public async Task<string> AlterarAsync(ContaCorrente oContaCorrente)
        {
            return await ContaCorrente.AlterarAsync(oContaCorrente);
        }

        public async Task<string> ExcluirAsync(string Conta)
        {
            return await ContaCorrente.ExcluirAsync(Conta);
        }

        public async Task<string> InserirAsync(ContaCorrente oContaCorrente)
        {
            return await ContaCorrente.InserirAsync(oContaCorrente);
        }

        public async Task<List<ContaCorrente>> SelecionarTodosAsync()
        {
            return await ContaCorrente.SelecionarTodosAsync();
        }

        public async Task<List<ContaCorrente>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return await ContaCorrente.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public async Task<List<PesquisarCC>> SelecionarTodosViewAsync()
        {
            return await ContaCorrente.SelecionarTodosViewAsync();
        }

        public async Task<List<PesquisarCC>> SelecionarTodosViewCriterioAsync(string Criterio, string Escolha)
        {
            return await ContaCorrente.SelecionarTodosViewCriterioAsync(Criterio, Escolha);
        }

        public bool ContaCorrenteExiste(string Conta)
        {
            return ContaCorrente.ContaCorrenteExiste(Conta);
        }
    }
}