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
        public Usuario Login(string NomeUsuario, string Senha)
        {
            try
            {
                using (DbEcxTrackEntities entidades = new DbEcxTrackEntities())
                {
                    TB_Usuario Usuario_Encontrado = entidades.TB_Usuario
                                                    .Include("TB_Perfil.TB_TipoPerfil")
                                                    .Where(u => u.Senha == Senha &&
                                                    (u.NomeUsuario == NomeUsuario || u.Email == NomeUsuario)).FirstOrDefault();

                    if (Usuario_Encontrado != null)
                    {
                        Usuario Usuario = new Usuario();

                        Usuario.CodUsuario = Usuario_Encontrado.CodUsuario;
                        Usuario.Nome = Usuario_Encontrado.Nome;
                        Usuario.CPF = Usuario_Encontrado.CPF;
                        Usuario.Email = Usuario_Encontrado.Email;
                        Usuario.Senha = Usuario_Encontrado.Senha;
                        Usuario.DataValidade = Usuario_Encontrado.DataValidade;
                        Usuario.Perfil = new Perfil(Usuario_Encontrado.TB_Perfil);

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
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
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




            return new Ponto();
        }

    }
}
