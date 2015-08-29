using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class PlanoContas
    {
        public async static Task<string> InserirAsync(PlanoContas oPlanoContas)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.PlanoContas.Add(oPlanoContas);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public static bool PlanoContasExiste(string Conta)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.PlanoContas
                            where b.Conta.Equals(Conta)
                            select b;
                    if (a.Count() == 0)
                        return false;
                    else
                        return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async static Task<string> AlterarAsync(PlanoContas oPlanoContas)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.PlanoContas.Attach(oPlanoContas);
                    oDB.Entry(oPlanoContas).State = EntityState.Modified;
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> ExcluirAsync(string Conta)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var oPlanoContas = await oDB.PlanoContas.FindAsync(Conta);
                    oDB.PlanoContas.Attach(oPlanoContas);
                    oDB.PlanoContas.Remove(oPlanoContas);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<PlanoContas>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.PlanoContas.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<PlanoContas>();
                }
            }
        }

        public async static Task<List<PlanoContas>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Conta":
                            {
                                var a = from b in oDB.PlanoContas
                                        where b.Conta.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Descrição":
                            {
                                var a = from b in oDB.PlanoContas
                                        where b.Descricao.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<PlanoContas>();
                    }
                }
                catch (Exception)
                {
                    return new List<PlanoContas>();
                }
            }
        }
    }
}