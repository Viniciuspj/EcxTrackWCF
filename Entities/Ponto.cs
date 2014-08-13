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
        public long CodEvento { get; set; }
        public int CodVeiculo { get; set; }
        public int CodCliente { get; set; }
        public int CodEquipamento { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int Hodometro { get; set; }
    }
}