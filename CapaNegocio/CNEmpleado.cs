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

        public void PruebaOracle()
        {
            cDEmpleado.PruebaConexion();
        }

        public void CrearEmpleado(CEEmpleado cE)
        {
            cDEmpleado.AgregarEmpleado(cE);
        }

        public void CrearVehiculo(CEVehiculo cV)
        {
            cDEmpleado.agregarVehiculo(cV);
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

        public List<CEComuna> ObtenerComunas(int idregion)
        {
            List<CEComuna> listaDireccion = new List<CEComuna>();
            listaDireccion = cDEmpleado.Comunas(idregion);
            return listaDireccion;
        }

        public List<CERegion> ObtenerRegion()
        {
            List<CERegion> listaRegion = new List<CERegion>();
            listaRegion = cDEmpleado.Region();
            return listaRegion;
        }
    }
}
