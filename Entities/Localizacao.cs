using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcxTrackWCF.Entities
{
    [DataContract]
    public class Localizacao
    {
        public long CodEvento { get; set; }
        public int CodVeiculo { get; set; }
        public int CodCliente { get; set; }
        public short Velocidade { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int Hodometro { get; set; }
        public string NumeroEquipamento { get; set; }
        public string Local { get; set; }
        public string Placa { get; set; }
        public string Cliente { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public DateTime DataEvento { get; set; }
        public string Contato { get; set; }
        public string TelefoneContato { get; set; }
        public string Ano { get; set; }
        public string Tooltip { get; set; }
        public string Status { get; set; }

        public string NomeMotorista { get; set; }
        public string CelMotorista { get; set; }
        //Variveis de status do equipamento

        public bool? SleepMode { get; set; }
        public bool? Panico { get; set; }
        public bool? SinalGPS { get; set; }
        public bool? StatusBloqueio { get; set; }
        public bool? StatusSirene { get; set; }
        public bool? StatusSaidaAuxiliar { get; set; }
        public bool? StatusSaidaAuxiliar2 { get; set; }

        //Eventos de bateria
        public bool? Bateria { get; set; }
        public bool? BateriaBackupBaixa { get; set; }
        public bool? FimVidaUtilBateria { get; set; }
        public bool? StatusVoltagemBateria { get; set; }

    }
}