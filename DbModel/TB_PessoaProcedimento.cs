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
    
    public partial class TB_PessoaProcedimento
    {
        public int CodPessoaProcedimento { get; set; }
        public int CodVeiculo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string ContraSenha { get; set; }
        public string Informacoes { get; set; }
        public string TipoPessoa { get; set; }
        public Nullable<int> PosicaoPonto { get; set; }
        public string Status { get; set; }
    
        public virtual TB_Veiculo TB_Veiculo { get; set; }
    }
}