using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class ContaCorrente
    {
        public async static Task<string> InserirAsync(ContaCorrente oContaCorrente)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.ContaCorrente.Add(oContaCorrente);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(ContaCorrente oContaCorrente)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.ContaCorrente.Attach(oContaCorrente);
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
                    var oContaCorrente = await oDB.ContaCorrente.FindAsync(Conta);
                    oDB.ContaCorrente.Attach(oContaCorrente);
                    oDB.ContaCorrente.Remove(oContaCorrente);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<ContaCorrente>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.ContaCorrente.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<ContaCorrente>();
                }
            }
        }

        public async static Task<List<PesquisarCC>> SelecionarTodosViewAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.PesquisarCC.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<PesquisarCC>();
                }
            }
        }

        public async static Task<List<PesquisarCC>> SelecionarTodosViewCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Cidade":
                            {
                                var a = from b in oDB.PesquisarCC
                                        where b.Cidade.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Gerente":
                            {
                                var a = from b in oDB.PesquisarCC
                                        where b.Gerente.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Nome Banco":
                            {
                                var a = from b in oDB.PesquisarCC
                                        where b.Nome.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID Agência":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.PesquisarCC
                                        where b.AgenciaID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Conta":
                            {
                                var a = from b in oDB.PesquisarCC
                                        where b.Conta.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<PesquisarCC>();
                    }
                }
                catch (Exception)
                {
                    return new List<PesquisarCC>();
                }
            }
        }

        public static bool ContaCorrenteExiste(string Conta)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.ContaCorrente
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

        public async static Task<List<ContaCorrente>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Cidade":
                            {
                                var a = from b in oDB.ContaCorrente
                                        where b.Conta.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Agência":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.ContaCorrente
                                        where b.Agencia.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<ContaCorrente>();
                    }
                }
                catch (Exception)
                {
                    return new List<ContaCorrente>();
                }
            }
        }
    }
}