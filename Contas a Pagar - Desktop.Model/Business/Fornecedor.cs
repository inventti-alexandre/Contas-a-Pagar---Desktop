using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Fornecedor
    {
        public async static Task<string> InserirAsync(Fornecedor oFornecedor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Fornecedor.Add(oFornecedor);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Fornecedor oFornecedor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Fornecedor.Attach(oFornecedor);
                    oDB.Entry(oFornecedor).State = EntityState.Modified;
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
                    var oFornecedor = await oDB.Fornecedor.FindAsync(ID);
                    oDB.Fornecedor.Attach(oFornecedor);
                    oDB.Fornecedor.Remove(oFornecedor);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<Fornecedor>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Fornecedor.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static bool FornecedorExiste(int IDFornecedor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var t = Convert.ToInt32(IDFornecedor);
                    var a = from b in oDB.Fornecedor
                            where b.ID.Equals(t)
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

        public async static Task<List<Fornecedor>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Razão Social":
                            {
                                var a = from b in oDB.Fornecedor
                                        where b.RazaoSocial.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Cidade":
                            {
                                var a = from b in oDB.Fornecedor
                                        where b.Cidade.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Fornecedor
                                        where b.ID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Fornecedor>();
                    }
                }
                catch (Exception)
                {
                    return new List<Fornecedor>();
                }
            }
        }
    }
}