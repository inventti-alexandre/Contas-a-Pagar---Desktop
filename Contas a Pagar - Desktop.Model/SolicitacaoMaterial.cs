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
    public partial class SolicitacaoMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitacaoMaterial()
        {
            this.Material = new HashSet<Material>();
        }
    
    	[DataMember]
        public int Setor { get; set; }
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public System.DateTime Data { get; set; }
    	[DataMember]
        public bool Aprovado { get; set; }
    
    	[DataMember]
        public virtual Setor Setor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    	[DataMember]
        public virtual ICollection<Material> Material { get; set; }
    }
}
