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
    
    public partial class TB_Complemento
    {
        public int CodComplemento { get; set; }
        public Nullable<int> LimiteMesesRelatorios { get; set; }
        public Nullable<int> AvisoVenctoBoleto { get; set; }
        public string PaginaInicial { get; set; }
        public int CodCliente { get; set; }
    
        public virtual TB_Cliente TB_Cliente { get; set; }
    }
}
