using EcxTrackWCF.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcxTrackWCF.Entities
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int CodCliente { get; set; }
        [DataMember]
        public string NomeCliente { get; set; }
        [DataMember]
        public string RazaoSocial { get; set; }
        [DataMember]
        public string CNPJ { get; set; }
        [DataMember]
        public string Status { get; set; }

        internal static Cliente ObterCliente(int CodCliente)
        {
            try
            {
                TB_Cliente tbCliente = new TB_Cliente();

                using (DbEcxTrackEntities Entidades = new DbEcxTrackEntities())
                {
                    TB_Cliente ClienteEncontrado = Entidades.TB_Cliente.Where(u => u.CodCliente == CodCliente).FirstOrDefault();

                    Cliente Cli = new Cliente();

                    if (ClienteEncontrado != null)
                    {
                        Cli.CodCliente = ClienteEncontrado.CodCliente;
                        Cli.NomeCliente = ClienteEncontrado.NomeCliente;
                        Cli.RazaoSocial = ClienteEncontrado.RazaoSocial;
                        Cli.CNPJ = ClienteEncontrado.CNPJ_CPF;
                        Cli.Status = ClienteEncontrado.Ativo;
                    }

                    return Cli;
                }
            }
            catch(Exception)
            {
                throw;
            }

        }
    }
}