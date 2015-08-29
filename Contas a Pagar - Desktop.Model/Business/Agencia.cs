using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Agencia
    {
        public async static Task<string> InserirAsync(Agencia oAgencia)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Agencia.Add(oAgencia);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Agencia oAgencia)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Agencia.Attach(oAgencia);
                    oDB.Entry(oAgencia).State = EntityState.Modified;
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
                    var oAgencia = await oDB.Agencia.FindAsync(ID);
                    oDB.Agencia.Attach(oAgencia);
                    oDB.Agencia.Remove(oAgencia);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public static bool AgenciaExiste(int ID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.PesquisaAgencia
                            where b.AgenciaID.Equals(ID)
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

        public async static Task<List<Agencia>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Agencia.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<Agencia>();
                }
            }
        }

        public async static Task<List<PesquisaAgencia>> SelecionarTodosViewAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.PesquisaAgencia.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<PesquisaAgencia>();
                }
            }
        }

        public async static Task<List<PesquisaAgencia>> SelecionarTodosViewCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Cidade":
                            {
                                var a = from b in oDB.PesquisaAgencia
                                        where b.Cidade.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Gerente":
                            {
                                var a = from b in oDB.PesquisaAgencia
                                        where b.Gerente.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Nome Banco":
                            {
                                var a = from b in oDB.PesquisaAgencia
                                        where b.Nome.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID Agência":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.PesquisaAgencia
                                        where b.AgenciaID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID Banco":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.PesquisaAgencia
                                        where b.BancoID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<PesquisaAgencia>();
                    }
                }
                catch (Exception)
                {
                    return new List<PesquisaAgencia>();
                }
            }
        }

        public async static Task<List<Agencia>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Cidade":
                            {
                                var a = from b in oDB.Agencia
                                        where b.Cidade.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Gerente":
                            {
                                var a = from b in oDB.Agencia
                                        where b.Gerente.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Agencia
                                        where b.ID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID Banco":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Agencia
                                        where b.ID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Agencia>();
                    }
                }
                catch (Exception)
                {
                    return new List<Agencia>();
                }
            }
        }
    }
}