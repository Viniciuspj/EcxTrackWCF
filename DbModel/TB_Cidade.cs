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
    
    public partial class TB_Cidade
    {
        public TB_Cidade()
        {
            this.TB_Cliente = new HashSet<TB_Cliente>();
            this.TB_Cliente1 = new HashSet<TB_Cliente>();
            this.TB_Cliente2 = new HashSet<TB_Cliente>();
            this.TB_EnderecoPrefCampanha = new HashSet<TB_EnderecoPrefCampanha>();
            this.TB_Motorista = new HashSet<TB_Motorista>();
            this.TB_Ocorrencia = new HashSet<TB_Ocorrencia>();
            this.TB_Ocorrencia1 = new HashSet<TB_Ocorrencia>();
            this.TB_Ocorrencia2 = new HashSet<TB_Ocorrencia>();
            this.TB_Representante = new HashSet<TB_Representante>();
            this.TB_Usuario = new HashSet<TB_Usuario>();
        }
    
        public int CodCidade { get; set; }
        public string Nome { get; set; }
        public Nullable<int> CodEstado { get; set; }
    
        public virtual TB_Estado TB_Estado { get; set; }
        public virtual ICollection<TB_Cliente> TB_Cliente { get; set; }
        public virtual ICollection<TB_Cliente> TB_Cliente1 { get; set; }
        public virtual ICollection<TB_Cliente> TB_Cliente2 { get; set; }
        public virtual ICollection<TB_EnderecoPrefCampanha> TB_EnderecoPrefCampanha { get; set; }
        public virtual ICollection<TB_Motorista> TB_Motorista { get; set; }
        public virtual ICollection<TB_Ocorrencia> TB_Ocorrencia { get; set; }
        public virtual ICollection<TB_Ocorrencia> TB_Ocorrencia1 { get; set; }
        public virtual ICollection<TB_Ocorrencia> TB_Ocorrencia2 { get; set; }
        public virtual ICollection<TB_Representante> TB_Representante { get; set; }
        public virtual ICollection<TB_Usuario> TB_Usuario { get; set; }
    }
}
