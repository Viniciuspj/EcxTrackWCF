//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcxTrackWCF.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ReferenciaBancaria
    {
        public int CodReferencia { get; set; }
        public int CodCliente { get; set; }
        public Nullable<int> CodBanco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
    
        public virtual TB_Banco TB_Banco { get; set; }
        public virtual TB_Cliente TB_Cliente { get; set; }
    }
}
