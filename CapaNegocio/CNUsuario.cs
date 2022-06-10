using CapaDatos;
using CapaEntidad;
using CryptSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNUsuario
    {
        CDUsuario cDUsuario = new CDUsuario();

        public void PruebaOracle()
        {
            cDUsuario.PruebaConexion();
        }

        public List<CEUSER_ESTADO> ObtenerDatos()
        {
            List<CEUSER_ESTADO> LISTA_USUARIO = new List<CEUSER_ESTADO>();
            LISTA_USUARIO = cDUsuario.LISTAR_USUARIO_();
            return LISTA_USUARIO;
        }

        public bool CrearUsuario(CEUsuario usuario)
        {
           return cDUsuario.AgregarUsuario(usuario);
        }

        public bool EditarUsuario(CEUsuario usuario)
        {
            usuario.US_CONTRASEÑA = Crypter.Blowfish.Crypt(usuario.US_CONTRASEÑA);
           return cDUsuario.EditarUsuario(usuario);
        }

        public bool CAMBIAR_ESTADO_USUARIO(CEUsuario usuario)
        {
           return cDUsuario.CAMBIAR_ESTADO_USUARIO(usuario);
        }

        public List<CE_ESTADO> ObtenerEstado()
        {
            List<CE_ESTADO> LISTA_ESTADO = new List<CE_ESTADO>();
            LISTA_ESTADO = cDUsuario.ESTADO();
            return LISTA_ESTADO;
        }
    }
}
