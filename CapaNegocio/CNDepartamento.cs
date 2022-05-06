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
    public class CNDepartamento
    {
        CDDepartamento cDDepartamento = new CDDepartamento();

        public void PruebaOracle()
        {
            cDDepartamento.PruebaConexion();
        }

        public object ObtenerDatos()
        {
            DataTable lista = new DataTable();
            lista = cDDepartamento.Listar();
            return lista;
        }

        public void EliminarDepartamento(CEDepartamento departamento)
        {
            cDDepartamento.EliminarDepartamento(departamento);
        }

        public void CrearDepartamento(CEDepartamento depto)
        {
            cDDepartamento.CrearDepartamento(depto);
        }

        public List<CETipoDepartamento> ObtenerTipoDepto()
        {
            List<CETipoDepartamento> listaTDDepartamento = new List<CETipoDepartamento>();
            listaTDDepartamento = cDDepartamento.TipoDepto();
            return listaTDDepartamento;
        }

        public List<CESysEstadoDepto> ObtenerEstadoDepto()
        {
            List<CESysEstadoDepto> listarEstadoDepto = new List<CESysEstadoDepto>();
            listarEstadoDepto = cDDepartamento.SysEstDepto();
            return listarEstadoDepto;
        }
    }
}
