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

        public List<CEDepartamento> ObtenerDatos()
        {
            List<CEDepartamento> listaDepto = new List<CEDepartamento>();
            listaDepto = cDDepartamento.ListarDepartamento();
            return listaDepto;
        }

        public List<CEDeptoListaJoin> ObtenerDatosJoinCaracteristicas()
        {
            List<CEDeptoListaJoin> listaDepto = new List<CEDeptoListaJoin>();
            listaDepto = cDDepartamento.ListaCaracteristicasDeptoJoin();
            return listaDepto;
        }

        public List<CEAdjuntos> ListarAdjuntosJoin()
        {
            List<CEAdjuntos> listaAdjuntos = new List<CEAdjuntos>();
            listaAdjuntos = cDDepartamento.ListarAdjuntosJoin();
            return listaAdjuntos;
        }

        public List<CEAdjuntos> ListarAdjuntosPorIdDepto(string idDepto)
        {
            //ListarAdjuntosJoinPorIdDepto
            List<CEAdjuntos> listaAdjuntosIdDepto = new List<CEAdjuntos>();
            return listaAdjuntosIdDepto = cDDepartamento.ListarAdjuntosJoinPorIdDepto(idDepto);
        }

        public void EliminarDepartamento(CEDepartamento departamento)
        {
            cDDepartamento.EliminarDepartamento(departamento);
        }

        

        public bool CrearDepartamento(CEDepartamento depto)
        {
            return cDDepartamento.CrearDepartamento(depto);
        }
        public bool CrearAdjunto(CEAdjunto adjunto)
        {
            return cDDepartamento.CrearAdjunto(adjunto);
        }

        public bool EliminarAdjunto(CEAdjunto adjunto)
        {

            return cDDepartamento.EliminarAdjuntoPorId(adjunto);
        }

        public bool ActualizarDepartamento(CEDepartamento depto)
        {
            return cDDepartamento.ActualizarDepartamento(depto);
        }

        public List<CETipoDepartamento> ObtenerTipoDepto()
        {
            List<CETipoDepartamento> listaTDDepartamento = new List<CETipoDepartamento>();
            listaTDDepartamento = cDDepartamento.TipoDepto();
            return listaTDDepartamento;
        }

        

        public bool CAMBIAR_ESTADO_DEPARTAMENTO(CEDepartamento cE)
        {
            return cDDepartamento.CAMBIAR_ESTADO_DEPARTAMENTO(cE);
        }

        public List<CESysEstadoDepto> ObtenerEstadoDepto()
        {
            List<CESysEstadoDepto> listarEstadoDepto = new List<CESysEstadoDepto>();
            listarEstadoDepto = cDDepartamento.SysEstDepto();
            return listarEstadoDepto;
        }
        public List<CE_ESTADO> ObtenerEstado()
        {
            List<CE_ESTADO> listaEstado = new List<CE_ESTADO>();
            listaEstado = cDDepartamento.Estado();
            return listaEstado;
        }

        public List<CEComuna> ObtenerComunas(int idregion)
        {
            List<CEComuna> listaDireccion = new List<CEComuna>();
            listaDireccion = cDDepartamento.Comunas(idregion + 1);
            return listaDireccion;
        }

        public List<CERegion> ObtenerRegion()
        {
            List<CERegion> listaRegion = new List<CERegion>();
            listaRegion = cDDepartamento.Region();
            return listaRegion;
        }

        
    }
}
