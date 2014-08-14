using EcxTrackWCF.DbModel;
using EcxTrackWCF.Entities;
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

        [OperationContract]
        Ponto UltimaLocalizacaoVeiculo(int CodVeiculo);

        [OperationContract]
        List<Veiculo> VeiculosPorCliente(int CodCliente, bool buscaClienteAdicional);
    }


}
