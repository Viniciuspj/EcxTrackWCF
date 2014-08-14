using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EcxTrackWCF.DbModel;
using EcxTrackWCF.Entities;

namespace EcxTrackWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EcxTrackAppServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EcxTrackAppServices.svc or EcxTrackAppServices.svc.cs at the Solution Explorer and start debugging.
    public class EcxTrackAppServices : IEcxTrackAppServices
    {
        /// <summary>
        /// Login App
        /// </summary>
        /// <param name="NomeUsuario">strNomeUsuario</param>
        /// <param name="Senha">strSenha</param>
        /// <returns>objUsuario</returns>
        public Usuario Login(string NomeUsuario, string Senha)
        {
            try
            {
                using (DbEcxTrackEntities entidades = new DbEcxTrackEntities())
                {
                    TB_Usuario Usuario_Encontrado = entidades.TB_Usuario.Include("TB_Perfil.TB_TipoPerfil")
                                                    .Where(u => u.Senha == Senha &&
                                                    (u.NomeUsuario == NomeUsuario || u.Email == NomeUsuario)).FirstOrDefault();

                    if (Usuario_Encontrado != null)
                    {
                        Usuario Usuario = new Usuario
                        {
                            CodUsuario = Usuario_Encontrado.CodUsuario,
                            Nome = Usuario_Encontrado.Nome,
                            CPF = Usuario_Encontrado.CPF,
                            Email = Usuario_Encontrado.Email,
                            Senha = Usuario_Encontrado.Senha,
                            DataValidade = Usuario_Encontrado.DataValidade,
                            Perfil = new Perfil(Usuario_Encontrado.TB_Perfil)
                        };

                        if (Usuario_Encontrado.CodCliente.HasValue)
                            Usuario.Cliente = Cliente.ObterCliente(Usuario_Encontrado.CodCliente.Value);
                        else
                            Usuario.Cliente = new Cliente { CodCliente = 0 };

                        if (VerificarValidadeUsuario(Usuario_Encontrado))
                        {
                            if (Usuario_Encontrado.SenhaTemporaria == "N")
                            {
                                /*SalvarAcessoUsuario(tbUsuario.CodUsuario, entidades);
                                ChecaPermissoesBotoes(tbUsuario);*/

                                Usuario.Status = "OK";
                            }
                            else if (Usuario_Encontrado.SenhaTemporaria == "S")
                            {
                                Usuario.Status = "TS";
                            }

                            return Usuario;
                        }
                        else
                        {
                            Usuario.Status = "Invalido";
                            return Usuario;
                        }
                    }
                    else
                    {
                        return new Usuario { Status = "Zica" };
                    }
                }
            }
            catch (Exception ex)
            {
                return new Usuario { Status = "Zica" };
            }
        }

        private bool VerificarValidadeUsuario(TB_Usuario tbUser)
        {
            if (tbUser.DataValidade != null)
                return tbUser.DataValidade >= DateTime.Now ? true : false;
            else
                return true;
        }

        public Ponto UltimaLocalizacaoVeiculo(int CodVeiculo)
        {
            //select top 1 Latitude, Longitude, Hodometro from TBS_Evento where Equipamento = (select CodEquipamento from TB_VeiculosEquipamentos where CodVeiculo = 12) order by DataEvento desc

            try
            {
                using (DbEcxTrackEntities entidades = new DbEcxTrackEntities())
                {
                    var ultimaLocalizacao = (from cv in entidades.TB_VeiculosEquipamentos
                                             join ev in entidades.TBS_Evento on cv.CodEquipamento equals ev.Equipamento
                                             where cv.CodVeiculo == CodVeiculo && cv.Ativo == "A" && ev.Latitude != 0 && ev.Longitude != 0
                                             select new
                                             {
                                                 DataEvento = ev.DataEvento,
                                                 CodVeiculo = cv.CodVeiculo,
                                                 CodEvento = ev.Id,
                                                 CodEquipamento = cv.CodEquipamento,
                                                 Latitude = ev.Latitude,
                                                 Longitude = ev.Longitude,
                                                 Hodometro = ev.Hodometro,
                                                 CodCliente = entidades.TB_VeiculosClientes.Where(v => v.CodVeiculo == cv.CodVeiculo && v.TipoCliente == "T" && v.Status == "A").FirstOrDefault().TB_Cliente.CodCliente

                                             }).OrderByDescending(ev => ev.DataEvento).FirstOrDefault();

                    if (ultimaLocalizacao != null)
                    {
                        Ponto PontoEncontrado = new Ponto();
                        PontoEncontrado.CodCliente = ultimaLocalizacao.CodCliente;
                        PontoEncontrado.CodEquipamento = ultimaLocalizacao.CodEquipamento;
                        PontoEncontrado.CodEvento = ultimaLocalizacao.CodEvento;
                        PontoEncontrado.CodVeiculo = ultimaLocalizacao.CodVeiculo;
                        PontoEncontrado.Latitude = ultimaLocalizacao.Latitude;
                        PontoEncontrado.Longitude = ultimaLocalizacao.Longitude;
                        PontoEncontrado.Hodometro = ultimaLocalizacao.Hodometro;

                        return PontoEncontrado;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Veiculo> VeiculosPorCliente(int CodCliente, bool buscaClienteAdicional)
        {
            List<Veiculo> lstVeiculo = new List<Veiculo>();

            try
            {
                using (DbEcxTrackEntities db = new DbEcxTrackEntities())
                {
                    List<Veiculo> lstVeiculo2 = (from vc in db.TB_VeiculosClientes 
                                                 join v in db.TB_Veiculo on vc.CodVeiculo equals v.CodVeiculo into _v from v in _v.DefaultIfEmpty()
                                                 join t in db.TB_TipoVeiculo on v.CodTipoVeiculo equals t.CodTipoVeiculo into _t from t in _t.DefaultIfEmpty()
                                                 where vc.CodCliente == CodCliente && vc.Status == "A" && (vc.TipoCliente == "T" || (buscaClienteAdicional && vc.TipoCliente == "A")) && v.Status == "A"
                                                   select new Veiculo
                                                   {
                                                      CodCliente = vc.CodCliente,
                                                      CodVeiculo = vc.CodVeiculo,
                                                      CodTipoVeiculo = t.CodTipoVeiculo,
                                                      Placa = v.Placa,
                                                      ContatoNome = v.Contato,
                                                      ContatoTelefone = v.TelefoneContato,
                                                      NomeTipoVeiculo = t.NomeTipo
                                                   }).ToList();

                    return lstVeiculo2;
                                       
                }
            }
            catch
            {
                return lstVeiculo;
            }
        }
    }
}
