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
    
    public partial class TBS_TipoEvento
    {
        public TBS_TipoEvento()
        {
            this.TBS_Evento = new HashSet<TBS_Evento>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public short Cod { get; set; }
    
        public virtual ICollection<TBS_Evento> TBS_Evento { get; set; }
    }
}