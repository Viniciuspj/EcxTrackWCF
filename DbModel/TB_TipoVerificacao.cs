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
    
    public partial class TB_TipoVerificacao
    {
        public TB_TipoVerificacao()
        {
            this.TB_Verificacao = new HashSet<TB_Verificacao>();
        }
    
        public int CodTipoVerificacao { get; set; }
        public string NomeVerificacao { get; set; }
    
        public virtual ICollection<TB_Verificacao> TB_Verificacao { get; set; }
    }
}
