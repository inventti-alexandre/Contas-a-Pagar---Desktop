﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contas_a_Pagar___Desktop.View.CDespesa
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Despesa", Namespace = "http://schemas.datacontract.org/2004/07/Contas_a_Pagar___Desktop.Model", IsReference = true)]
    [System.SerializableAttribute()]
    public partial class Despesa : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LancamentoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PagamentoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValorPrevistoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Lancamento
        {
            get
            {
                return this.LancamentoField;
            }
            set
            {
                if ((this.LancamentoField.Equals(value) != true))
                {
                    this.LancamentoField = value;
                    this.RaisePropertyChanged("Lancamento");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numero
        {
            get
            {
                return this.NumeroField;
            }
            set
            {
                if ((this.NumeroField.Equals(value) != true))
                {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pagamento
        {
            get
            {
                return this.PagamentoField;
            }
            set
            {
                if ((this.PagamentoField.Equals(value) != true))
                {
                    this.PagamentoField = value;
                    this.RaisePropertyChanged("Pagamento");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ValorPrevisto
        {
            get
            {
                return this.ValorPrevistoField;
            }
            set
            {
                if ((this.ValorPrevistoField.Equals(value) != true))
                {
                    this.ValorPrevistoField = value;
                    this.RaisePropertyChanged("ValorPrevisto");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "CDespesa.ICDespesa")]
    public interface ICDespesa
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/Inserir", ReplyAction = "http://tempuri.org/ICDespesa/InserirResponse")]
        string Inserir(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/Inserir", ReplyAction = "http://tempuri.org/ICDespesa/InserirResponse")]
        System.Threading.Tasks.Task<string> InserirAsync(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/Alterar", ReplyAction = "http://tempuri.org/ICDespesa/AlterarResponse")]
        string Alterar(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/Alterar", ReplyAction = "http://tempuri.org/ICDespesa/AlterarResponse")]
        System.Threading.Tasks.Task<string> AlterarAsync(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/Excluir", ReplyAction = "http://tempuri.org/ICDespesa/ExcluirResponse")]
        string Excluir(int ID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/Excluir", ReplyAction = "http://tempuri.org/ICDespesa/ExcluirResponse")]
        System.Threading.Tasks.Task<string> ExcluirAsync(int ID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/SelecionarTodos", ReplyAction = "http://tempuri.org/ICDespesa/SelecionarTodosResponse")]
        Contas_a_Pagar___Desktop.View.CDespesa.Despesa[] SelecionarTodos();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/SelecionarTodos", ReplyAction = "http://tempuri.org/ICDespesa/SelecionarTodosResponse")]
        System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CDespesa.Despesa[]> SelecionarTodosAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/SelecionarTodosCriterio", ReplyAction = "http://tempuri.org/ICDespesa/SelecionarTodosCriterioResponse")]
        Contas_a_Pagar___Desktop.View.CDespesa.Despesa[] SelecionarTodosCriterio(string Criterio, string Escolha);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/SelecionarTodosCriterio", ReplyAction = "http://tempuri.org/ICDespesa/SelecionarTodosCriterioResponse")]
        System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CDespesa.Despesa[]> SelecionarTodosCriterioAsync(string Criterio, string Escolha);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/DespesaExiste", ReplyAction = "http://tempuri.org/ICDespesa/DespesaExisteResponse")]
        bool DespesaExiste(int ID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICDespesa/DespesaExiste", ReplyAction = "http://tempuri.org/ICDespesa/DespesaExisteResponse")]
        System.Threading.Tasks.Task<bool> DespesaExisteAsync(int ID);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICDespesaChannel : Contas_a_Pagar___Desktop.View.CDespesa.ICDespesa, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CDespesaClient : System.ServiceModel.ClientBase<Contas_a_Pagar___Desktop.View.CDespesa.ICDespesa>, Contas_a_Pagar___Desktop.View.CDespesa.ICDespesa
    {
        public CDespesaClient()
        {
        }

        public CDespesaClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public CDespesaClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CDespesaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CDespesaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public string Inserir(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa)
        {
            return base.Channel.Inserir(oDespesa);
        }

        public System.Threading.Tasks.Task<string> InserirAsync(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa)
        {
            return base.Channel.InserirAsync(oDespesa);
        }

        public string Alterar(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa)
        {
            return base.Channel.Alterar(oDespesa);
        }

        public System.Threading.Tasks.Task<string> AlterarAsync(Contas_a_Pagar___Desktop.View.CDespesa.Despesa oDespesa)
        {
            return base.Channel.AlterarAsync(oDespesa);
        }

        public string Excluir(int ID)
        {
            return base.Channel.Excluir(ID);
        }

        public System.Threading.Tasks.Task<string> ExcluirAsync(int ID)
        {
            return base.Channel.ExcluirAsync(ID);
        }

        public Contas_a_Pagar___Desktop.View.CDespesa.Despesa[] SelecionarTodos()
        {
            return base.Channel.SelecionarTodos();
        }

        public System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CDespesa.Despesa[]> SelecionarTodosAsync()
        {
            return base.Channel.SelecionarTodosAsync();
        }

        public Contas_a_Pagar___Desktop.View.CDespesa.Despesa[] SelecionarTodosCriterio(string Criterio, string Escolha)
        {
            return base.Channel.SelecionarTodosCriterio(Criterio, Escolha);
        }

        public System.Threading.Tasks.Task<Contas_a_Pagar___Desktop.View.CDespesa.Despesa[]> SelecionarTodosCriterioAsync(string Criterio, string Escolha)
        {
            return base.Channel.SelecionarTodosCriterioAsync(Criterio, Escolha);
        }

        public bool DespesaExiste(int ID)
        {
            return base.Channel.DespesaExiste(ID);
        }

        public System.Threading.Tasks.Task<bool> DespesaExisteAsync(int ID)
        {
            return base.Channel.DespesaExisteAsync(ID);
        }
    }
}