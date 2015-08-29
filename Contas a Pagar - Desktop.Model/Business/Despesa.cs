using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Despesa
    {
        public async static Task<string> InserirAsync(Despesa oDespesa)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Despesa.Add(oDespesa);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Despesa oDespesa)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Despesa.Attach(oDespesa);
                    oDB.Entry(oDespesa).State = EntityState.Modified;
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> ExcluirAsync(int ID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var oDespesa = await oDB.Despesa.FindAsync(ID);
                    oDB.Despesa.Attach(oDespesa);
                    oDB.Despesa.Remove(oDespesa);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<Despesa>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Despesa.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<Despesa>();
                }
            }
        }

        public static bool DespesaExiste(int ID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.Despesa
                            where b.Numero.Equals(ID)
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

        public async static Task<List<Despesa>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Lançamento":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Despesa
                                        where b.Lancamento.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Descrição":
                            {
                                var a = from b in oDB.Despesa
                                        where b.Descricao.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Número":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Despesa
                                        where b.Numero.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Despesa>();
                    }
                }
                catch (Exception)
                {
                    return new List<Despesa>();
                }
            }
        }
    }
}