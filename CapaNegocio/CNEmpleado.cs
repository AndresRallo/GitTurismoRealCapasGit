using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        CDEmpleado cDEmpleado = new CDEmpleado();
        public void ValidarDatosLogin(CEEmpleado cE)
        {
            cDEmpleado.ValidarDatos(cE);
            
        }
        /*  public bool ValidarDatos(CEEmpleado empleado)
          {
              bool resultado = true;

              if (empleado.em_rut == string.Empty)
              {
                  resultado = false;
                  MessageBox.Show("El RUT es Obligatorio");
              }

              if (empleado.em_nombre == string.Empty)
              {
                  resultado = false;
                  MessageBox.Show("El nombre es Obligatorio");
              }

              if (empleado.em_apaterno == string.Empty)
              {
                  resultado = false;
                  MessageBox.Show("El apellido materno es Obligatorio");
              }

              if (empleado.emp_amaterno == string.Empty)
              {
                  resultado = false;
                  MessageBox.Show("El apellido materno es Obligatorio");
              }

              if (empleado.em_mail == string.Empty)
              {
                  resultado = false;
                  MessageBox.Show("El Email es Obligatorio");
              }

              if (empleado.em_contrasena == string.Empty)
              {
                  resultado = false;
                  MessageBox.Show("La contraseña es obligatoria");
              }


              if (empleado.idEmpresa <= 0)
              {
                  resultado = false;
                  MessageBox.Show("El id de la Empresa es Obligatorio");
              }
              if (empleado.idTipoEmleado <= 0)
              {
                  resultado = false;
                  MessageBox.Show("El id del tipo de empleado es obligatorio");
              }
              if (empleado.idEstado <= 0)
              {
                  resultado = false;
                  MessageBox.Show("El id del estado del empleado es obligatorio");
              }
              if (empleado.idDireccion <= 0)
              {
                  resultado = false;
                  MessageBox.Show("El id de la dirección es obligatorio");
              }
              return resultado;
          } */

        public void PruebaOracle()
        {
            cDEmpleado.PruebaConexion();
        }

        public void CrearEmpleado(CEEmpleado cE)
        {
            cDEmpleado.AgregarEmpleado(cE);
        }

        public void EditarEmpleado(CEEmpleado cE) 
        {
            cDEmpleado.EditarEmpleado(cE);
        }

        public void EliminarEmpleado(CEEmpleado cE) 
        {
            cDEmpleado.EliminarEmpleado(cE);
        }


        public DataTable ObtenerDatos()
        {
            DataTable lista = new DataTable();
            lista = cDEmpleado.Listar();
            return lista;
        }

        public List<CEComuna> ObtenerComunas()
        {
            List<CEComuna> listaDireccion = new List<CEComuna>();
            listaDireccion = cDEmpleado.Comunas();
            return listaDireccion;
        }
    }
}
