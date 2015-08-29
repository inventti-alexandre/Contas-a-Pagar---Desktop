using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CLancamento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CLancamento.svc or CLancamento.svc.cs at the Solution Explorer and start debugging.
    public class CLancamento : ICLancamento
    {
        public async Task<string> AlterarAsync(Lancamento oLancamento)
        {
            try
            {
                return await Lancamento.AlterarAsync(oLancamento);
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
                return await Lancamento.ExcluirAsync(ID);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> InserirAsync(Lancamento oLancamento)
        {
            try
            {
                return await Lancamento.InserirAsync(oLancamento);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<Lancamento>> SelecionarTodosAsync()
        {
            try
            {
                return await Lancamento.SelecionarTodosAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Lancamento>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            try
            {
                return await Lancamento.SelecionarTodosCriterioAsync(Criterio, Escolha);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool LancamentoExiste(int ID)
        {
            return Lancamento.LancamentoExiste(ID);
        }
    }
}