using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class FornecimentoMaterial
    {
        public static string InserirAsync(FornecimentoMaterial oFornecimentoMaterial)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.RealizarFornecimento(oFornecimentoMaterial.Fornecedor, oFornecimentoMaterial.Servico, oFornecimentoMaterial.Data);
                    foreach (var item in oFornecimentoMaterial.Material)
                    {
                        oDB.ItensFornecimentoRealizado(item.ID);
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public static string CancelarFornecimento(int Fornecimento, bool Cancelado)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = oDB.FornecimentoMaterial.Find(Fornecimento);
                    a.Cancelado = Cancelado;
                    oDB.FornecimentoMaterial.Attach(a);
                    oDB.Entry(a).State = EntityState.Modified;
                    oDB.SaveChanges();
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public async static Task<List<FornecimentosMateriais>> SelecionarTodosViewAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.FornecimentosMateriais.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<FornecimentoMaterial>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.FornecimentoMaterial.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<Material>> SelecionarTodosMateriaisAsync()
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

        public async static Task<List<RelacaoFornecimento>> SelecionarTodosFornecimentos()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.RelacaoFornecimento.ToListAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool FornecimentoExiste(int FornecimentoID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.RelacaoFornecimento
                            where b.FornecimentoID.Equals(FornecimentoID)
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

        public static List<FornecimentoMaterial> SelecionarTodosNaoCancelados()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.FornecimentoMaterial
                            where b.Cancelado == false
                            select b;
                    if (a.Count() > 0)
                    {
                        return a.ToList();
                    }
                    else
                    {
                        return new List<FornecimentoMaterial>();
                    }
                }
                catch (Exception)
                {
                    return new List<FornecimentoMaterial>();
                }
            }
        }

        public async static Task<List<RelacaoFornecimento>> SelecionarTodosFornecimentosCriterio(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "FornecimentoID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.RelacaoFornecimento
                                        where b.FornecimentoID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "FornecedorID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.RelacaoFornecimento
                                        where b.FornecedorID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Razão Social":
                            {
                                var a = from b in oDB.RelacaoFornecimento
                                        where b.RazaoSocial.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<RelacaoFornecimento>();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static List<DetalhesFornecimento_Result> SelecionarTodosDetalhesFornecimentos(int Fornecimento)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    List<DetalhesFornecimento_Result> test = new List<DetalhesFornecimento_Result>();
                    foreach (var item in oDB.DetalhesFornecimento(Fornecimento))
                    {
                        test.Add(item);
                    }
                    return test;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static List<TodosFornecimentos_Result> SelecionarTodosFornecimentosBasico(int fornecedor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    List<TodosFornecimentos_Result> test = new List<TodosFornecimentos_Result>();
                    foreach (var item in oDB.TodosFornecimentos(fornecedor))
                    {
                        test.Add(item);
                    }
                    return test;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<NumFornecimentosPorEmpresa>> SelecionarTodosFornecimentosPorEmpresa()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.NumFornecimentosPorEmpresa.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<NumFornecimentosPorEmpresa>> SelecionarTodosFornecimentosPorEmpresaPesquisa(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "FornecedorID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.NumFornecimentosPorEmpresa
                                        where b.FornecedorID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Razão Social":
                            {
                                var a = from b in oDB.NumFornecimentosPorEmpresa
                                        where b.RazaoSocial.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<NumFornecimentosPorEmpresa>();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}