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
    
    public partial class TB_ModeloEquipamento
    {
        public TB_ModeloEquipamento()
        {
            this.TB_Equipamento = new HashSet<TB_Equipamento>();
        }
    
        public int CodModeloEquip { get; set; }
        public string Nome { get; set; }
        public Nullable<int> CodModeloBin { get; set; }
    
        public virtual ICollection<TB_Equipamento> TB_Equipamento { get; set; }
    }
}
