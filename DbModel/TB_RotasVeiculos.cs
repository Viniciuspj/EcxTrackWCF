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
    
    public partial class TB_RotasVeiculos
    {
        public int CodRotaVeiculo { get; set; }
        public int CodRota { get; set; }
        public int CodVeiculo { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataVinculacao { get; set; }
        public Nullable<System.DateTime> DataFinalizacao { get; set; }
    
        public virtual TB_Rota TB_Rota { get; set; }
        public virtual TB_Veiculo TB_Veiculo { get; set; }
    }
}
