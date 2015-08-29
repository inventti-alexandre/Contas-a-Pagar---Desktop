using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CBanco" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CBanco.svc or CBanco.svc.cs at the Solution Explorer and start debugging.
    public class CBanco : ICBanco
    {
        public async Task<string> AlterarAsync(Banco oBanco)
        {
            return await Banco.AlterarAsync(oBanco);
        }

        public async Task<string> ExcluirAsync(int ID)
        {
            return await Banco.ExcluirAsync(ID);
        }

        public async Task<string> InserirAsync(Banco oBanco)
        {
            return await Banco.InserirAsync(oBanco);
        }

        public async Task<List<Banco>> SelecionarTodosAsync()
        {
            return await Banco.SelecionarTodosAsync();
        }

        public async Task<List<Banco>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return await Banco.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public bool BancoExiste(int ID)
        {
            return Banco.BancoExiste(ID);
        }
    }
}