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
    
    public partial class TB_Representante
    {
        public int CodRepresentante { get; set; }
        public int CodCliente { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Ramal { get; set; }
        public string Tipo { get; set; }
        public string ParticipacaoSocietaria { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string TipoDocumentoId { get; set; }
        public string NumeroDocumentoId { get; set; }
        public string OrgaoEmissor { get; set; }
        public string EstadoCivil { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Nullable<int> CodCidade { get; set; }
    
        public virtual TB_Cidade TB_Cidade { get; set; }
        public virtual TB_Cliente TB_Cliente { get; set; }
    }
}
