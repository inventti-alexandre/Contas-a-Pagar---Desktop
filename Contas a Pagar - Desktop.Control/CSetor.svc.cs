using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CSetor" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CSetor.svc or CSetor.svc.cs at the Solution Explorer and start debugging.
    public class CSetor : ICSetor
    {
        public async Task<string> AlterarAsync(Setor oSetor)
        {
            try
            {
                return await Setor.AlterarAsync(oSetor);
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
                return await Setor.ExcluirAsync(ID);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> InserirAsync(Setor oSetor)
        {
            try
            {
                return await Setor.InserirAsync(oSetor);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<Setor>> SelecionarTodosAsync()
        {
            try
            {
                return await Setor.SelecionarTodosAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Setor>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            try
            {
                return await Setor.SelecionarTodosCriterioAsync(Criterio, Escolha);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}