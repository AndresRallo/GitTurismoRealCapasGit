using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNCliente
    {
        CDCliente cDCliente = new CDCliente();
        public bool ValidarDatos(CECliente cliente)
        {
            bool resultado = true;

            if (cliente.em_rut == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El RUT es Obligatorio");
            }
            if(cliente.em_contrasena == string.Empty)
            {
                resultado = false;
                MessageBox.Show("La contraseña es obligatoria");
            }

            return resultado;
        }

        public void PruebaOracle()
        {
            cDCliente.PruebaConexion();
        }

        public void CrearCliente(CECliente cE)
        {
            cDCliente.Crear(cE);
        }

        
    }
}
