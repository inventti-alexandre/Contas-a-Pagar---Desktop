﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contas_a_Pagar___Desktop.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CAPEntities : DbContext
    {
        public CAPEntities()
            : base("name=CAPEntities")
        {
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Auditoria> Auditoria { get; set; }
        public virtual DbSet<Despesa> Despesa { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<FornecimentoMaterial> FornecimentoMaterial { get; set; }
        public virtual DbSet<Lancamento> Lancamento { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }
        public virtual DbSet<Permissao> Permissao { get; set; }
        public virtual DbSet<PlanoContas> PlanoContas { get; set; }
        public virtual DbSet<Setor> Setor { get; set; }
        public virtual DbSet<SolicitacaoMaterial> SolicitacaoMaterial { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Agencia> Agencia { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<ContaCorrente> ContaCorrente { get; set; }
        public virtual DbSet<PesquisaAgencia> PesquisaAgencia { get; set; }
        public virtual DbSet<PesquisarCC> PesquisarCC { get; set; }
        public virtual DbSet<FornecimentosMateriais> FornecimentosMateriais { get; set; }
        public virtual DbSet<RelacaoFornecimento> RelacaoFornecimento { get; set; }
        public virtual DbSet<SolicitacoesMateriais> SolicitacoesMateriais { get; set; }
        public virtual DbSet<RelacaoSolicitacao> RelacaoSolicitacao { get; set; }
        public virtual DbSet<NumFornecimentosPorEmpresa> NumFornecimentosPorEmpresa { get; set; }
        public virtual DbSet<NumSolicitacoesPorSetor> NumSolicitacoesPorSetor { get; set; }
        public virtual DbSet<NumSolicitacoesAprovadosPorSetor> NumSolicitacoesAprovadosPorSetor { get; set; }
        public virtual DbSet<NumSolicitacoesNaoAprovadosPorSetor> NumSolicitacoesNaoAprovadosPorSetor { get; set; }
    
        public virtual int FornecerMaterial(Nullable<int> fornecedor, Nullable<int> servico, Nullable<System.DateTime> data, Nullable<int> material)
        {
            var fornecedorParameter = fornecedor.HasValue ?
                new ObjectParameter("Fornecedor", fornecedor) :
                new ObjectParameter("Fornecedor", typeof(int));
    
            var servicoParameter = servico.HasValue ?
                new ObjectParameter("Servico", servico) :
                new ObjectParameter("Servico", typeof(int));
    
            var dataParameter = data.HasValue ?
                new ObjectParameter("Data", data) :
                new ObjectParameter("Data", typeof(System.DateTime));
    
            var materialParameter = material.HasValue ?
                new ObjectParameter("Material", material) :
                new ObjectParameter("Material", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FornecerMaterial", fornecedorParameter, servicoParameter, dataParameter, materialParameter);
        }
    
        public virtual int ItensFornecimentoRealizado(Nullable<int> material)
        {
            var materialParameter = material.HasValue ?
                new ObjectParameter("Material", material) :
                new ObjectParameter("Material", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ItensFornecimentoRealizado", materialParameter);
        }
    
        public virtual int RealizarFornecimento(Nullable<int> fornecedor, Nullable<int> servico, Nullable<System.DateTime> data)
        {
            var fornecedorParameter = fornecedor.HasValue ?
                new ObjectParameter("Fornecedor", fornecedor) :
                new ObjectParameter("Fornecedor", typeof(int));
    
            var servicoParameter = servico.HasValue ?
                new ObjectParameter("Servico", servico) :
                new ObjectParameter("Servico", typeof(int));
    
            var dataParameter = data.HasValue ?
                new ObjectParameter("Data", data) :
                new ObjectParameter("Data", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RealizarFornecimento", fornecedorParameter, servicoParameter, dataParameter);
        }
    
        public virtual ObjectResult<DetalhesFornecimento_Result> DetalhesFornecimento(Nullable<int> fornecimento)
        {
            var fornecimentoParameter = fornecimento.HasValue ?
                new ObjectParameter("Fornecimento", fornecimento) :
                new ObjectParameter("Fornecimento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DetalhesFornecimento_Result>("DetalhesFornecimento", fornecimentoParameter);
        }
    
        public virtual ObjectResult<DetalhesSolicitacao_Result1> DetalhesSolicitacao(Nullable<int> solicitacao)
        {
            var solicitacaoParameter = solicitacao.HasValue ?
                new ObjectParameter("Solicitacao", solicitacao) :
                new ObjectParameter("Solicitacao", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DetalhesSolicitacao_Result1>("DetalhesSolicitacao", solicitacaoParameter);
        }
    
        public virtual int RealizarSolicitacao(Nullable<int> setor, Nullable<System.DateTime> data, Nullable<bool> aprovado)
        {
            var setorParameter = setor.HasValue ?
                new ObjectParameter("Setor", setor) :
                new ObjectParameter("Setor", typeof(int));
    
            var dataParameter = data.HasValue ?
                new ObjectParameter("Data", data) :
                new ObjectParameter("Data", typeof(System.DateTime));
    
            var aprovadoParameter = aprovado.HasValue ?
                new ObjectParameter("Aprovado", aprovado) :
                new ObjectParameter("Aprovado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RealizarSolicitacao", setorParameter, dataParameter, aprovadoParameter);
        }
    
        public virtual int ItensSolicitacaoRealizada(Nullable<int> material)
        {
            var materialParameter = material.HasValue ?
                new ObjectParameter("Material", material) :
                new ObjectParameter("Material", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ItensSolicitacaoRealizada", materialParameter);
        }
    
        public virtual int DetalheSolicitacao(Nullable<int> solicitacao)
        {
            var solicitacaoParameter = solicitacao.HasValue ?
                new ObjectParameter("Solicitacao", solicitacao) :
                new ObjectParameter("Solicitacao", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DetalheSolicitacao", solicitacaoParameter);
        }
    
        public virtual ObjectResult<TodasSolicitacoes_Result> TodasSolicitacoes(Nullable<int> setor)
        {
            var setorParameter = setor.HasValue ?
                new ObjectParameter("Setor", setor) :
                new ObjectParameter("Setor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TodasSolicitacoes_Result>("TodasSolicitacoes", setorParameter);
        }
    
        public virtual ObjectResult<TodosFornecimentos_Result> TodosFornecimentos(Nullable<int> fornecedor)
        {
            var fornecedorParameter = fornecedor.HasValue ?
                new ObjectParameter("Fornecedor", fornecedor) :
                new ObjectParameter("Fornecedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TodosFornecimentos_Result>("TodosFornecimentos", fornecedorParameter);
        }
    
        public virtual ObjectResult<TodasSolicitacoesAprovadas_Result> TodasSolicitacoesAprovadas(Nullable<int> setor)
        {
            var setorParameter = setor.HasValue ?
                new ObjectParameter("Setor", setor) :
                new ObjectParameter("Setor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TodasSolicitacoesAprovadas_Result>("TodasSolicitacoesAprovadas", setorParameter);
        }
    
        public virtual ObjectResult<TodasSolicitacoesNaoAprovadas_Result> TodasSolicitacoesNaoAprovadas(Nullable<int> setor)
        {
            var setorParameter = setor.HasValue ?
                new ObjectParameter("Setor", setor) :
                new ObjectParameter("Setor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TodasSolicitacoesNaoAprovadas_Result>("TodasSolicitacoesNaoAprovadas", setorParameter);
        }
    }
}
