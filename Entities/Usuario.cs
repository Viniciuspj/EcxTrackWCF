using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcxTrackWCF.Entities
{
    [DataContract]
    public class Usuario
    {
        int _CodUsuario;
        string _Nome;
        string _CPF;
        string _Email;
        public string Senha;
        DateTime? _DataValidade;
        string _Status;
        Perfil _Perfil;
        Cliente _Cliente;
        //public Cliente Cliente

        [DataMember]
        public int CodUsuario
        {
            get { return _CodUsuario; }
            set { _CodUsuario = value; }
        }

        [DataMember]
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        [DataMember]
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        [DataMember]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public DateTime? DataValidade
        {
            get { return _DataValidade; }
            set { _DataValidade = value; }
        }

        [DataMember]
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        [DataMember]
        public Perfil Perfil
        {
            get { return _Perfil; }
            set { _Perfil = value; }
        }

        [DataMember]
        public Cliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
    }
}