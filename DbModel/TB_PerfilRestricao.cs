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
    
    public partial class TB_PerfilRestricao
    {
        public int CodPerfilRestricao { get; set; }
        public int codPerfil { get; set; }
        public string Permissao { get; set; }
    
        public virtual TB_Perfil TB_Perfil { get; set; }
    }
}
