using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contas_a_Pagar___Desktop.Model;

namespace Contas_a_Pagar___Desktop.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CMaterial" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CMaterial.svc or CMaterial.svc.cs at the Solution Explorer and start debugging.
    public class CMaterial : ICMaterial
    {
        public async Task<string> AlterarAsync(Material oMaterial)
        {
            try
            {
                return await Material.AlterarAsync(oMaterial);
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
                return await Material.ExcluirAsync(ID);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> InserirAsync(Material oMaterial)
        {
            try
            {
                return await Material.InserirAsync(oMaterial);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<Material>> SelecionarTodosAsync()
        {
            try
            {
                return await Material.SelecionarTodosAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Material>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            try
            {
                return await Material.SelecionarTodosCriterioAsync(Criterio, Escolha);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}