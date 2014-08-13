using EcxTrackWCF.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EcxTrackWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEcxTrackAppServices" in both code and config file together.
    [ServiceContract]
    public interface IEcxTrackAppServices
    {
        [OperationContract]
        Usuario Login(string NomeUsuario, string Senha);
    }

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
        int _CodPerfil;
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
        public int CodPerfil
        {
            get { return _CodPerfil; }
            set { _CodPerfil = value; }
        }
    }
}
