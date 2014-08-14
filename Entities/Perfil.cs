using EcxTrackWCF.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcxTrackWCF.Entities
{
    [DataContract]
    public class Perfil
    {
        [DataMember]
        public int CodPerfil { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public Nullable<int> Personalizado { get; set; }

        [DataMember]
        public Nullable<int> TipoPerfil { get; set; }

        public Perfil(TB_Perfil TB_Perfil)
        {
            CodPerfil = TB_Perfil.CodPerfil;
            Nome = TB_Perfil.Nome;
            Personalizado = TB_Perfil.Personalizado;
            TipoPerfil = TB_Perfil.CodTipoPerfil;
        }
    }
}