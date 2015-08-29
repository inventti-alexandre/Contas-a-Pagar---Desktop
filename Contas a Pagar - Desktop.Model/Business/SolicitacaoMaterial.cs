using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Contas_a_Pagar___Desktop.Model
{
    public partial class SolicitacaoMaterial
    {
        public static string InserirAsync(SolicitacaoMaterial oSolicitacaoMaterial)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    oDB.RealizarSolicitacao(oSolicitacaoMaterial.Setor, oSolicitacaoMaterial.Data, oSolicitacaoMaterial.Aprovado);
                    foreach (var item in oSolicitacaoMaterial.Material)
                    {
                        oDB.ItensSolicitacaoRealizada(item.ID);
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public static string AprovarSolicitacao(int Solicitacao, bool Aprovacao)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = oDB.SolicitacaoMaterial.Find(Solicitacao);
                    a.Aprovado = Aprovacao;
                    oDB.SolicitacaoMaterial.Attach(a);
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

        public async static Task<List<SolicitacoesMateriais>> SelecionarTodosViewAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.SolicitacoesMateriais.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<SolicitacaoMaterial>> SelecionarTodosNaoAprovadosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.SolicitacaoMaterial
                            where b.Aprovado.Equals(false)
                            select b;
                    return await a.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<SolicitacaoMaterial>();
                }
            }
        }

        public async static Task<List<SolicitacaoMaterial>> SelecionarTodosAprovadosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.SolicitacaoMaterial
                            where b.Aprovado.Equals(true)
                            select b;
                    return await a.ToListAsync();
                }
                catch (Exception)
                {
                    return new List<SolicitacaoMaterial>();
                }
            }
        }

        public async static Task<List<SolicitacaoMaterial>> SelecionarTodosAsync()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.SolicitacaoMaterial.ToListAsync();
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

        public async static Task<List<RelacaoSolicitacao>> SelecionarTodosSolicitacoes()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.RelacaoSolicitacao.ToListAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool SolicitacaoExiste(int SolicitacaoID)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    var a = from b in oDB.RelacaoSolicitacao
                            where b.SolicitacaoID.Equals(SolicitacaoID)
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

        public async static Task<List<RelacaoSolicitacao>> SelecionarTodosSolicitacoesCriterio(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "SolicitacaoID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.RelacaoSolicitacao
                                        where b.SolicitacaoID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "SetorID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.RelacaoSolicitacao
                                        where b.SetorID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Setor":
                            {
                                var a = from b in oDB.RelacaoSolicitacao
                                        where b.SetorSolicitante.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<RelacaoSolicitacao>();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static List<DetalhesSolicitacao_Result1> SelecionarTodosDetalhesSolicitacoes(int Solicitacao)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    List<DetalhesSolicitacao_Result1> test = new List<DetalhesSolicitacao_Result1>();
                    foreach (var item in oDB.DetalhesSolicitacao(Solicitacao))
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

        public static List<TodasSolicitacoes_Result> SelecionarTodasSolicitacoesBasico(int Setor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    List<TodasSolicitacoes_Result> test = new List<TodasSolicitacoes_Result>();
                    foreach (var item in oDB.TodasSolicitacoes(Setor))
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

        public static List<TodasSolicitacoesAprovadas_Result> SelecionarTodasSolicitacoesBasicoAprovadas(int Setor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    List<TodasSolicitacoesAprovadas_Result> test = new List<TodasSolicitacoesAprovadas_Result>();
                    foreach (var item in oDB.TodasSolicitacoesAprovadas(Setor))
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

        public static List<TodasSolicitacoesNaoAprovadas_Result> SelecionarTodasSolicitacoesBasicoNaoAprovadas(int Setor)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    List<TodasSolicitacoesNaoAprovadas_Result> test = new List<TodasSolicitacoesNaoAprovadas_Result>();
                    foreach (var item in oDB.TodasSolicitacoesNaoAprovadas(Setor))
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

        public async static Task<List<NumSolicitacoesPorSetor>> SelecionarTodasSolicitacoesPorSetor()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.NumSolicitacoesPorSetor.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<NumSolicitacoesPorSetor>> SelecionarTodasSolicitacoesPorSetorPesquisa(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "SetorID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.NumSolicitacoesPorSetor
                                        where b.SetorID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Setor":
                            {
                                var a = from b in oDB.NumSolicitacoesPorSetor
                                        where b.Setor.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<NumSolicitacoesPorSetor>();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<NumSolicitacoesNaoAprovadosPorSetor>> SelecionarTodasSolicitacoesNaoAprovadosPorSetor()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.NumSolicitacoesNaoAprovadosPorSetor.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<NumSolicitacoesNaoAprovadosPorSetor>> SelecionarTodasSolicitacoesNaoAprovadosPorSetorPesquisa(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "SetorID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.NumSolicitacoesNaoAprovadosPorSetor
                                        where b.SetorID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Setor":
                            {
                                var a = from b in oDB.NumSolicitacoesNaoAprovadosPorSetor
                                        where b.Setor.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<NumSolicitacoesNaoAprovadosPorSetor>();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<NumSolicitacoesAprovadosPorSetor>> SelecionarTodasSolicitacoesAprovadosPorSetor()
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    return await oDB.NumSolicitacoesAprovadosPorSetor.ToListAsync();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async static Task<List<NumSolicitacoesAprovadosPorSetor>> SelecionarTodasSolicitacoesAprovadosPorSetorPesquisa(string Criterio, string Escolha)
        {
            using (var oDB = new CAPEntities())
            {
                try
                {
                    switch (Escolha)
                    {
                        case "SetorID":
                            {
                                var t = Convert.ToInt32(Criterio);
                                var a = from b in oDB.NumSolicitacoesAprovadosPorSetor
                                        where b.SetorID.Equals(t)
                                        select b;
                                return await a.ToListAsync();
                            }
                        case "Setor":
                            {
                                var a = from b in oDB.NumSolicitacoesAprovadosPorSetor
                                        where b.Setor.Contains(Criterio)
                                        select b;
                                return await a.ToListAsync();
                            }
                        default: return new List<NumSolicitacoesAprovadosPorSetor>();
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