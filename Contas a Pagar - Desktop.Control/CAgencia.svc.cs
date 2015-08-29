using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CAgencia" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CAgencia.svc or CAgencia.svc.cs at the Solution Explorer and start debugging.
    public class CAgencia : ICAgencia
    {
        public async Task<string> AlterarAsync(Agencia oAgencia)
        {
            return await Agencia.AlterarAsync(oAgencia);
        }

        public async Task<string> ExcluirAsync(int ID)
        {
            return await Agencia.ExcluirAsync(ID);
        }

        public async Task<string> InserirAsync(Agencia oAgencia)
        {
            return await Agencia.InserirAsync(oAgencia);
        }

        public async Task<List<Agencia>> SelecionarTodosAsync()
        {
            return await Agencia.SelecionarTodosAsync();
        }

        public async Task<List<Agencia>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return await Agencia.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public async Task<List<PesquisaAgencia>> SelecionarTodosViewAsync()
        {
            return await Agencia.SelecionarTodosViewAsync();
        }

        public async Task<List<PesquisaAgencia>> SelecionarTodosViewCriterioAsync(string Criterio, string Escolha)
        {
            return await Agencia.SelecionarTodosViewCriterioAsync(Criterio, Escolha);
        }

        public bool AgenciaExiste(int ID)
        {
            return Agencia.AgenciaExiste(ID);
        }
    }
}