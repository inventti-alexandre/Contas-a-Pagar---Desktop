using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Banco
    {
        public async static Task<string> InserirAsync(Banco oBanco)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Banco.Add(oBanco);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Banco oBanco)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Banco.Attach(oBanco);
                    oDB.Entry(oBanco).State = EntityState.Modified;
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
                    var oBanco = await oDB.Banco.FindAsync(ID);
                    oDB.Banco.Attach(oBanco);
                    oDB.Banco.Remove(oBanco);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<Banco>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Banco.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<Banco>();
                }
            }
        }

        public static bool BancoExiste(int ID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.Banco
                            where b.ID.Equals(ID)
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

        public async static Task<List<Banco>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Nome":
                            {
                                var a = from b in oDB.Banco
                                        where b.Nome.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Número":
                            {
                                var a = from b in oDB.Banco
                                        where b.Numero.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Banco
                                        where b.ID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Banco>();
                    }
                }
                catch (Exception)
                {
                    return new List<Banco>();
                }
            }
        }
    }
}