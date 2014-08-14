using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcxTrackWCF.Entities
{
    [DataContract]
    public class Veiculo
    {
        [DataMember]
        public int CodVeiculo { get; set; }
        [DataMember]
        public int CodCliente { get; set; }
        [DataMember]
        public int CodTipoVeiculo { get; set; }
        [DataMember]
        public string NomeTipoVeiculo { get; set; }
        [DataMember]
        public string Placa { get; set; }
        [DataMember]
        public string ContatoNome { get; set; }
        [DataMember]
        public string ContatoTelefone { get; set; }
    }
}