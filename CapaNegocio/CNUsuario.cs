using CapaDatos;
using CapaEntidad;
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

        public DataTable ObtenerDatos()
        {
            DataTable lista = new DataTable();
            lista = cDUsuario.Listar();
            return lista;
        }

        public void CrearUsuario(CEUsuario usuario)
        {
            cDUsuario.AgregarUsuario(usuario);
        }

        public void EditarUsuario(CEUsuario usuario)
        {
            cDUsuario.EditarUsuario(usuario);
        }

        public void EliminarUsuario(CEUsuario usuario)
        {
            cDUsuario.EliminarUsuario(usuario);
        }
    }
}
