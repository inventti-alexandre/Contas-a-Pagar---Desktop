using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Setor
    {
        public async static Task<string> InserirAsync(Setor oSetor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Setor.Add(oSetor);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Setor oSetor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Setor.Attach(oSetor);
                    oDB.Entry(oSetor).State = EntityState.Modified;
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
                    var oSetor = await oDB.Setor.FindAsync(ID);
                    oDB.Setor.Attach(oSetor);
                    oDB.Setor.Remove(oSetor);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<Setor>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Setor.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<Setor>();
                }
            }
        }

        public async static Task<List<Setor>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Descrição":
                            {
                                var a = from b in oDB.Setor
                                        where b.Descricao.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Setor
                                        where b.ID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Setor>();
                    }
                }
                catch (Exception)
                {
                    return new List<Setor>();
                }
            }
        }
    }
}