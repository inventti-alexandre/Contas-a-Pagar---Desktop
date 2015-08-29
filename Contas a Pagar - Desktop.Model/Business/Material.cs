using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class Material
    {
        public async static Task<string> InserirAsync(Material oMaterial)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Material.Add(oMaterial);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<string> AlterarAsync(Material oMaterial)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.Material.Attach(oMaterial);
                    oDB.Entry(oMaterial).State = EntityState.Modified;
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
                    var oMaterial = await oDB.Material.FindAsync(ID);
                    oDB.Material.Attach(oMaterial);
                    oDB.Material.Remove(oMaterial);
                    await oDB.SaveChangesAsync();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<Material>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.Material.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<Material>();
                }
            }
        }

        public async static Task<List<Material>> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "Descrição":
                            {
                                var a = from b in oDB.Material
                                        where b.Descricao.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "ID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.Material
                                        where b.ID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<Material>();
                    }
                }
                catch (Exception)
                {
                    return new List<Material>();
                }
            }
        }
    }
}