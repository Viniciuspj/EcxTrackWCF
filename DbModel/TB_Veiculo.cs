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
    
    public partial class TB_Veiculo
    {
        public TB_Veiculo()
        {
            this.TB_AlertaEventos = new HashSet<TB_AlertaEventos>();
            this.TB_CercasVeiculos = new HashSet<TB_CercasVeiculos>();
            this.TB_Jornada = new HashSet<TB_Jornada>();
            this.TB_Manutencao = new HashSet<TB_Manutencao>();
            this.TB_Mensagens = new HashSet<TB_Mensagens>();
            this.TB_NotificaoVeiculo = new HashSet<TB_NotificaoVeiculo>();
            this.TB_Ocorrencia = new HashSet<TB_Ocorrencia>();
            this.TB_OrdemServico = new HashSet<TB_OrdemServico>();
            this.TB_PessoaProcedimento = new HashSet<TB_PessoaProcedimento>();
            this.TB_RotasVeiculos = new HashSet<TB_RotasVeiculos>();
            this.TB_VeiculosClientes = new HashSet<TB_VeiculosClientes>();
            this.TB_VeiculosEquipamentos = new HashSet<TB_VeiculosEquipamentos>();
            this.TB_EventoVerificacao = new HashSet<TB_EventoVerificacao>();
        }
    
        public int CodVeiculo { get; set; }
        public int CodTipoVeiculo { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Cor { get; set; }
        public string Chassi { get; set; }
        public string Observacoes { get; set; }
        public string ProcedimentoPanico { get; set; }
        public string Status { get; set; }
        public string Renavam { get; set; }
        public Nullable<System.DateTime> DataVencimentoContrato { get; set; }
        public Nullable<System.DateTime> DataInativacao { get; set; }
        public string CodigoFipe { get; set; }
        public Nullable<System.DateTime> DataCompra { get; set; }
        public string Contato { get; set; }
        public string TelefoneContato { get; set; }
        public Nullable<int> LimiteVelocidade { get; set; }
        public string Panico { get; set; }
        public string MedidasPanico { get; set; }
        public string CalculoHodomentro { get; set; }
        public string CalculoHorimetro { get; set; }
        public string TipoConsumo { get; set; }
        public Nullable<int> ConsumoCombustivel { get; set; }
        public int CodFusoHorario { get; set; }
        public Nullable<decimal> ValorCompra { get; set; }
        public string Modelo { get; set; }
    
        public virtual ICollection<TB_AlertaEventos> TB_AlertaEventos { get; set; }
        public virtual ICollection<TB_CercasVeiculos> TB_CercasVeiculos { get; set; }
        public virtual TB_FusoHorario TB_FusoHorario { get; set; }
        public virtual ICollection<TB_Jornada> TB_Jornada { get; set; }
        public virtual ICollection<TB_Manutencao> TB_Manutencao { get; set; }
        public virtual ICollection<TB_Mensagens> TB_Mensagens { get; set; }
        public virtual ICollection<TB_NotificaoVeiculo> TB_NotificaoVeiculo { get; set; }
        public virtual ICollection<TB_Ocorrencia> TB_Ocorrencia { get; set; }
        public virtual ICollection<TB_OrdemServico> TB_OrdemServico { get; set; }
        public virtual ICollection<TB_PessoaProcedimento> TB_PessoaProcedimento { get; set; }
        public virtual ICollection<TB_RotasVeiculos> TB_RotasVeiculos { get; set; }
        public virtual TB_TipoVeiculo TB_TipoVeiculo { get; set; }
        public virtual ICollection<TB_VeiculosClientes> TB_VeiculosClientes { get; set; }
        public virtual ICollection<TB_VeiculosEquipamentos> TB_VeiculosEquipamentos { get; set; }
        public virtual ICollection<TB_EventoVerificacao> TB_EventoVerificacao { get; set; }
    }
}
