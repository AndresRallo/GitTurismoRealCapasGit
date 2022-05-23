using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaDatos;
using System.Data;
using TurismoRealExceptions;
using CryptSharp;

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

        public bool CrearEmpleado(CEEmpleado cE)
        {
            return cDEmpleado.AgregarEmpleado(cE);
        }

        
        public bool EditarEmpleado(CEEmpleado cE) 
        {
            cE.EM_CONTRASEÑA = Crypter.Blowfish.Crypt(cE.EM_CONTRASEÑA);
           return cDEmpleado.EditarEmpleado(cE);
        }

        public bool CAMBIAR_ESTADO_EMPLEADO(CEEmpleado cE) 
        {
           return cDEmpleado.CAMBIAR_ESTADO_EMPLEADO(cE);
        }

      /*  public DataTable ObtenerDatos()
        {
            DataTable lista = new DataTable();
            lista = cDEmpleado.Listar();
            return lista;
        } */

        public List<CEEmpleado> ObtenerEmpleados()
        {
            List<CEEmpleado> LISTA_EMPLEADO = new List<CEEmpleado>();
            LISTA_EMPLEADO = cDEmpleado.Empleado();
            return LISTA_EMPLEADO;
        }

        public List<CEVehiculo> ObtenerVehiculos()
        {
            List<CEVehiculo> LISTA_VEHICULO = new List<CEVehiculo>();
            LISTA_VEHICULO = cDEmpleado.LISTA_VEHICULO();
            return LISTA_VEHICULO;
        }

        public List<CEComuna> ObtenerComunas(int idregion)
        {
            List<CEComuna> listaDireccion = new List<CEComuna>();
            listaDireccion = cDEmpleado.Comunas(idregion + 1);
            return listaDireccion;
        }

        public List<CERegion> ObtenerRegion()
        {
            List<CERegion> listaRegion = new List<CERegion>();
            listaRegion = cDEmpleado.Region();
            return listaRegion;
        }

        public List<CE_TIPOEMPLEADO> ObtenerTipoEmpleado()
        {
            List<CE_TIPOEMPLEADO> LISTA_TIPOEMPLEADO = new List<CE_TIPOEMPLEADO>();
            LISTA_TIPOEMPLEADO = cDEmpleado.TIPOEMPLEADO();
            return LISTA_TIPOEMPLEADO;
        }
        public List<CE_ESTADO> ObtenerEstado()
        {
            List<CE_ESTADO> LISTA_ESTADO = new List<CE_ESTADO>();
            LISTA_ESTADO = cDEmpleado.ESTADO();
            return LISTA_ESTADO;
        }

        /// <summary>
        /// Obtiene el usuario segun correo ingresado, si el usuario no existe devuelve nul
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Entidad usuario</returns>
        public static CEEmpleado getUserByEmail(string email)
        {
            try
            {
                return CDEmpleado.getUserByEmail(email);
            }
            catch (TechnicalException)
            {
                throw new BusinessException("Estimado usuario, no es posible obtener el usuario, por favor contactarse con el administrador"); 
            }
        }
    }
}
