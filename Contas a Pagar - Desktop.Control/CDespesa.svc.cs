using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CDespesa" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CDespesa.svc or CDespesa.svc.cs at the Solution Explorer and start debugging.
    public class CDespesa : ICDespesa
    {
        public async Task<string> AlterarAsync(Despesa oDespesa)
        {
            return await Despesa.AlterarAsync(oDespesa);
        }

        public async Task<string> ExcluirAsync(int ID)
        {
            return await Despesa.ExcluirAsync(ID);
        }

        public async Task<string> InserirAsync(Despesa oDespesa)
        {
            return await Despesa.InserirAsync(oDespesa);
        }

        public async Task<List<Despesa>> SelecionarTodosAsync()
        {
            return await Despesa.SelecionarTodosAsync();
        }

        public async Task<List<Despesa>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return await Despesa.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public bool DespesaExiste(int ID)
        {
            return Despesa.DespesaExiste(ID);
        }
    }
}