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
    
    public partial class TB_FusoHorario
    {
        public TB_FusoHorario()
        {
            this.TB_Usuario = new HashSet<TB_Usuario>();
            this.TB_Veiculo = new HashSet<TB_Veiculo>();
        }
    
        public int CodFusoHorario { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<TB_Usuario> TB_Usuario { get; set; }
        public virtual ICollection<TB_Veiculo> TB_Veiculo { get; set; }
    }
}
