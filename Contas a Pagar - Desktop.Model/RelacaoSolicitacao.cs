//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public partial class RelacaoSolicitacao
    {
    	[DataMember]
        public int SolicitacaoID { get; set; }
    	[DataMember]
        public System.DateTime Data { get; set; }
    	[DataMember]
        public int SetorID { get; set; }
    	[DataMember]
        public string SetorSolicitante { get; set; }
    	[DataMember]
        public Nullable<decimal> ValorTotal { get; set; }
    	[DataMember]
        public bool Aprovado { get; set; }
    }
}
