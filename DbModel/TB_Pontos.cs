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
    
    public partial class TB_Pontos
    {
        public TB_Pontos()
        {
            this.TB_PontosRota = new HashSet<TB_PontosRota>();
        }
    
        public int CodPonto { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string NomePonto { get; set; }
        public int CodIcone { get; set; }
        public Nullable<int> CodCliente { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    
        public virtual TB_Cliente TB_Cliente { get; set; }
        public virtual TB_ImagemPontos TB_ImagemPontos { get; set; }
        public virtual ICollection<TB_PontosRota> TB_PontosRota { get; set; }
    }
}
