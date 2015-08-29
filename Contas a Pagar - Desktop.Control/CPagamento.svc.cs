using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CPagamento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CPagamento.svc or CPagamento.svc.cs at the Solution Explorer and start debugging.
    public class CPagamento : ICPagamento
    {
        public async Task<string> AlterarAsync(Pagamento oPagamento)
        {
            try
            {
                return await Pagamento.AlterarAsync(oPagamento);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> ExcluirAsync(int ID)
        {
            try
            {
                return await Pagamento.ExcluirAsync(ID);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> InserirAsync(Pagamento oPagamento)
        {
            try
            {
                return await Pagamento.InserirAsync(oPagamento);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<Pagamento>> SelecionarTodosAsync()
        {
            try
            {
                return await Pagamento.SelecionarTodosAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Pagamento>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            try
            {
                return await Pagamento.SelecionarTodosCriterioAsync(Criterio, Escolha);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool PagamentoExiste(int ID)
        {
            return Pagamento.PagamentoExiste(ID);
        }
    }
}