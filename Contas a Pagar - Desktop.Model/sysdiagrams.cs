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
    public partial class sysdiagrams
    {
    	[DataMember]
        public string name { get; set; }
    	[DataMember]
        public int principal_id { get; set; }
    	[DataMember]
        public int diagram_id { get; set; }
    	[DataMember]
        public Nullable<int> version { get; set; }
    	[DataMember]
        public byte[] definition { get; set; }
    }
}
