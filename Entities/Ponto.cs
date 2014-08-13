using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcxTrackWCF.Entities
{
    [DataContract]
    public class Ponto
    {
        [DataMember]
        public long CodEvento { get; set; }
        [DataMember]
        public int CodVeiculo { get; set; }
        [DataMember]
        public int CodCliente { get; set; }
        [DataMember]
        public int CodEquipamento { get; set; }

        [DataMember]
        public decimal Latitude { get; set; }
        [DataMember]
        public decimal Longitude { get; set; }
        [DataMember]
        public int Hodometro { get; set; }
    }
}