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
    
    public partial class TBS_RequisicaoApn
    {
        public int CodRequisicaoApn { get; set; }
        public int CodRequisicao { get; set; }
        public string Apn { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    
        public virtual TBS_Requisicao TBS_Requisicao { get; set; }
    }
}
