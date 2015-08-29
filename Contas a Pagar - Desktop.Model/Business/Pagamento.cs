using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Pagamento
    {
        public async static Task<string> InserirAsync(Pagamento oPagamento)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Pagamento.Add(oPagamento);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Pagamento oPagamento)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Pagamento.Attach(oPagamento);
                    oDB.Entry(oPagamento).State = EntityState.Modified;
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
                    var oPagamento = await oDB.Pagamento.FindAsync(ID);
                    oDB.Pagamento.Attach(oPagamento);
                    oDB.Pagamento.Remove(oPagamento);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public static bool PagamentoExiste(int ID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.Pagamento
                            where b.Fornecimento.Equals(ID)
                            select b;
                    if (a.Count() == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async static Task<List<Pagamento>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Pagamento.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<Pagamento>();
                }
            }
        }

        public async static Task<List<Pagamento>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Fornecimento":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Pagamento
                                        where b.Fornecimento.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Data":
                            {
                                var t = Convert.ToDateTime(Criterio);
                                var a = from b in oDB.Pagamento
                                        where b.DataEmissao.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Pagamento>();
                    }
                }
                catch (Exception)
                {
                    return new List<Pagamento>();
                }
            }
        }
    }
}