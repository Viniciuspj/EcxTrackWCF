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
    
    public partial class TB_EntradasEquipamento
    {
        public int CodEntradasEquipamento { get; set; }
        public int CodVeiculoEquipamento { get; set; }
        public string Entrada { get; set; }
        public string Ativo { get; set; }
    
        public virtual TB_VeiculosEquipamentos TB_VeiculosEquipamentos { get; set; }
    }
}
