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
    public partial class Fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedor()
        {
            this.FornecimentoMaterial = new HashSet<FornecimentoMaterial>();
        }
    
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public string RazaoSocial { get; set; }
    	[DataMember]
        public string CNPJ { get; set; }
    	[DataMember]
        public string Endereco { get; set; }
    	[DataMember]
        public string Cidade { get; set; }
    	[DataMember]
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    	[DataMember]
        public virtual ICollection<FornecimentoMaterial> FornecimentoMaterial { get; set; }
    }
}