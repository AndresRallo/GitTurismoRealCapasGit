﻿using CapaDatos;
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

        public List<CECaracteristicas_Departamento> ObtenerCaracteristicas()
        {
            List<CECaracteristicas_Departamento> listaCaracteristicas = new List<CECaracteristicas_Departamento>();
            listaCaracteristicas = cDDepartamento.ListaCaracteristicasDepto();
            return listaCaracteristicas;
        }

        public void EliminarDepartamento(CEDepartamento departamento)
        {
            cDDepartamento.EliminarDepartamento(departamento);
        }

        public bool CrearDepartamento(CEDepartamento depto)
        {
            return cDDepartamento.CrearDepartamento(depto);
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
