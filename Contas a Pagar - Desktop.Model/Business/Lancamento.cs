using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Lancamento
    {
        public async static Task<string> InserirAsync(Lancamento oLancamento)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Lancamento.Add(oLancamento);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Lancamento oLancamento)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Lancamento.Attach(oLancamento);
                    oDB.Entry(oLancamento).State = EntityState.Modified;
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
                    var oLancamento = await oDB.Lancamento.FindAsync(ID);
                    oDB.Lancamento.Attach(oLancamento);
                    oDB.Lancamento.Remove(oLancamento);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<Lancamento>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Lancamento.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<Lancamento>();
                }
            }
        }

        public static bool LancamentoExiste(int ID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.Lancamento
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

        public async static Task<List<Lancamento>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Descrição":
                            {
                                var a = from b in oDB.Lancamento
                                        where b.Descricao.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Número":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Lancamento
                                        where b.Numero.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Conta Crédito":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Lancamento
                                        where b.Numero.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Lancamento>();
                    }
                }
                catch (Exception)
                {
                    return new List<Lancamento>();
                }
            }
        }
    }
}