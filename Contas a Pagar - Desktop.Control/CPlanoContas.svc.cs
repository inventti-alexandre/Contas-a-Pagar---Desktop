using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CPlanoContas" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CPlanoContas.svc or CPlanoContas.svc.cs at the Solution Explorer and start debugging.
    public class CPlanoContas : ICPlanoContas
    {
        public async Task<string> AlterarAsync(PlanoContas oPlanoContas)
        {
            return await PlanoContas.AlterarAsync(oPlanoContas);
        }

        public async Task<string> ExcluirAsync(string Conta)
        {
            return await PlanoContas.ExcluirAsync(Conta);
        }

        public async Task<string> InserirAsync(PlanoContas oPlanoContas)
        {
            return await PlanoContas.InserirAsync(oPlanoContas);
        }

        public async Task<List<PlanoContas>> SelecionarTodosAsync()
        {
            return await PlanoContas.SelecionarTodosAsync();
        }

        public async Task<List<PlanoContas>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return await PlanoContas.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public bool PlanoContasExiste(string Conta)
        {
            return PlanoContas.PlanoContasExiste(Conta);
        }
    }
}