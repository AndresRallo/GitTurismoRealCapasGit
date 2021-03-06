using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using TurismoRealExceptions;

namespace CapaDatos
{
    public class CDDepartamento
    {
        string conexion = ConfigurationManager.AppSettings["conn"];


        public void PruebaConexion()
        {
            OracleConnection conn = new OracleConnection(conexion);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conecta a la BD" + ex.Message);
                return;
            }
            conn.Close();
            MessageBox.Show("Conectado :)");
        }

        public void EliminarDepartamento(CEDepartamento departamento)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Está seguro elimianr Depto?", "Eliminar Departamento", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        OracleCommand command = new OracleCommand("DP_eliminarDepartamento", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("ID_DEPARTAMENTO", OracleType.Number).Value = Convert.ToInt32(departamento.idDepto);
                        command.ExecuteNonQuery();

                    }
                    conn.Close();
                }
                MessageBox.Show("Departamento eliminado :)");

            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }

        

        public bool CAMBIAR_ESTADO_DEPARTAMENTO(CEDepartamento cE)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Esta seguro de cambiar el estado del departamento?", "Cambiar Estado", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        OracleCommand command = new OracleCommand("SP_SET_STATUS_CHANGE_DEPTO", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("IDDEPTO", OracleType.Number).Value = Convert.ToInt32(cE.idDepto);
                        command.Parameters.Add("IDESTADO", OracleType.Number).Value = Convert.ToInt32(cE.idEstadoDepto);

                        OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                        par.Direction = ParameterDirection.Output;
                        par.Size = 250;
                        command.Parameters.Add(par);
                        command.ExecuteNonQuery();
                        salida = command.Parameters["V_DETALLE"].Value.ToString();
                        conn.Close();
                    }
                }
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException orex)
            {
                return false;
            }
            catch (Exception ex)
            {
                //ex.Message;
                //ex.StackTrace;
                //agregar ex al Log
                return false;
            }
        }

        public List<CERegion> Region()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CERegion> listaDireccion = new List<CERegion>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_REGION", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        listaDireccion.Add(new CERegion
                        {
                            IDREGION = Convert.ToInt32(mostrarTabla["IDREGION"]),
                            RE_DESCRIPCION = Convert.ToString(mostrarTabla["RE_DESCRIPCION"].ToString())
                        });
                    }
                    conn.Close();
                }
                return listaDireccion;

            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }
        public List<CEComuna> Comunas(int idregion)
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEComuna> listaDireccion = new List<CEComuna>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_COMUNA_BY_IDREGION", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("IDREGION_", OracleType.Number).Value = idregion;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        listaDireccion.Add(new CEComuna
                        {
                            idcomuna = Convert.ToInt32(mostrarTabla["IDCOMUNA"]),
                            c_descripcion = Convert.ToString(mostrarTabla["C_DESCRIPCION"].ToString())
                        });
                    }
                    conn.Close();
                }
                return listaDireccion;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }

        public List<CETipoDepartamento> TipoDepto()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CETipoDepartamento> ListaTipoDepto = new List<CETipoDepartamento>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_TIPO_DEPARTAMENTOS", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        ListaTipoDepto.Add(new CETipoDepartamento
                        {
                            IDTIPODEPARTAMENTO = Convert.ToInt32(mostrarTabla["IDTIPODEPARTAMENTO"]),
                            TD_DESCRIPCION = Convert.ToString(mostrarTabla["TD_DESCRIPCION"].ToString())

                        });
                    }
                    conn.Close();
                }
                return ListaTipoDepto;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }


        public List<CESysEstadoDepto> SysEstDepto()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CESysEstadoDepto> listarEstadoDepto = new List<CESysEstadoDepto>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_TIPO_ESTADO_DEPARTAMENTO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();

                    while (mostrarTabla.Read())
                    {
                        listarEstadoDepto.Add(new CESysEstadoDepto
                        {
                            IDEstDepto = Convert.ToInt32(mostrarTabla["IDESTADODEPARTAMENTO"]),
                            EdDescripcion = Convert.ToString(mostrarTabla["ED_DESCRIPCION"].ToString())
                        });
                    }
                    conn.Close();
                }
                return listarEstadoDepto;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }
        public List<CE_ESTADO> Estado()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CE_ESTADO> listarEstado = new List<CE_ESTADO>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_SYS_ESTADO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        listarEstado.Add(new CE_ESTADO
                        {
                            IDESTADO = Convert.ToInt32(mostrarTabla["IDESTADO"]),
                            ES_DESCRIPCION = Convert.ToString(mostrarTabla["ES_DESCRIPCION"].ToString())
                        });

                    }
                    conn.Close();
                }
                return listarEstado;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }
        public bool CrearAdjunto(CEAdjunto adjunto)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_SET_ADD_ADJUNTO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = adjunto.AD_NOMBRE;
                    command.Parameters.Add("FECHA", OracleType.DateTime).Value = adjunto.AD_FECHACREACION;
                    command.Parameters.Add("IDDEPTO", OracleType.Number).Value = Convert.ToInt32(adjunto.IDDEPARTAMENTO);
                    command.Parameters.Add("IDESTADO", OracleType.Number).Value = Convert.ToInt32(adjunto.IDESTADO);

                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();


                    conn.Close();
                }
                 if(string.IsNullOrEmpty(salida))

                    return true;
                else

                    return false;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("No se creó el adjunto" + oex.Message);
            }
        }
        public bool CrearDepartamento(CEDepartamento depto)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_SET_ADD_DEPTO", conn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = depto.de_nombre;
                    command.Parameters.Add("DESCRIPCION", OracleType.NVarChar).Value = depto.descripcionDepto;
                    command.Parameters.Add("PRECIO", OracleType.Number).Value = Convert.ToInt32(depto.precioDepto);
                    command.Parameters.Add("STARS", OracleType.Number).Value = Convert.ToInt32(depto.de_start);
                    command.Parameters.Add("IDTIPODEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idTipoDepto);
                    command.Parameters.Add("IDESTADODEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idEstadoDepto);

                    command.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = depto.direccion.de_direccion;
                    command.Parameters.Add("NUMDIREC", OracleType.NVarChar).Value = depto.direccion.de_numero;
                    command.Parameters.Add("IDCOMUNADIREC", OracleType.Number).Value = Convert.ToInt32(depto.direccion.id_comuna);

                    command.Parameters.Add("NUMDEPTO", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_NumDepto);
                    command.Parameters.Add("CANTHAB", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantHabitaciones);
                    command.Parameters.Add("CANTCAMAS", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantCamas);
                    command.Parameters.Add("CANTBANIO", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantBaño);
                    command.Parameters.Add("CANTPERS", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CapPersonas);

                    command.Parameters.Add("CHECKIN", OracleType.NVarChar).Value = depto.carateristicasDepartamento.Ca_CheckIn;
                    command.Parameters.Add("CHECKOUT", OracleType.NVarChar).Value = depto.carateristicasDepartamento.Ca_CheckOut;

                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();


                    conn.Close();

                }
                if (string.IsNullOrEmpty(salida))

                    return true;
                else

                    return false;


            }
            catch (OracleException oex)
            {

                throw new TechnicalException("No se creó el departamento" + oex.Message);
            }
        }

        public bool ActualizarDepartamento(CEDepartamento depto)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_SET_UPDATE_DEPTO", conn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add("IDDEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idDepto);

                    command.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = depto.de_nombre;
                    command.Parameters.Add("DESCRIPCION", OracleType.NVarChar).Value = depto.descripcionDepto;
                    command.Parameters.Add("PRECIO", OracleType.Number).Value = Convert.ToInt32(depto.precioDepto);
                    command.Parameters.Add("STARS", OracleType.Number).Value = Convert.ToInt32(depto.de_start);
                    command.Parameters.Add("IDTIPODEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idTipoDepto);
                    command.Parameters.Add("IDESTADODEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idEstadoDepto);

                    command.Parameters.Add("IDDIREC", OracleType.Number).Value = Convert.ToInt32(depto.direccion.idDireccion);

                    command.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = depto.direccion.de_direccion;
                    command.Parameters.Add("NUMDIREC", OracleType.NVarChar).Value = depto.direccion.de_numero;
                    command.Parameters.Add("IDCOMUNADIREC", OracleType.Number).Value = Convert.ToInt32(depto.direccion.id_comuna);

                    command.Parameters.Add("IDCARACT", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.IdCaracteristica);

                    command.Parameters.Add("NUMDEPTO", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_NumDepto);
                    command.Parameters.Add("CANTHAB", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantHabitaciones);
                    command.Parameters.Add("CANTCAMAS", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantCamas);
                    command.Parameters.Add("CANTBANIO", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantBaño);
                    command.Parameters.Add("CANTPERS", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CapPersonas);

                    command.Parameters.Add("CHECKIN", OracleType.NVarChar).Value = depto.carateristicasDepartamento.Ca_CheckIn;
                    command.Parameters.Add("CHECKOUT", OracleType.NVarChar).Value = depto.carateristicasDepartamento.Ca_CheckOut;

                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();

                    conn.Close();
                }
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException oex)
            {
                throw new TechnicalException("No se creó el departamento" + oex.Message);
            }
        }

        #region ListaCaracteristicasDeptoJoin()

        

        public List<CEDeptoListaJoin> ListaCaracteristicasDeptoJoin()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEDeptoListaJoin> LISTA_DEPTO = new List<CEDeptoListaJoin>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_CARACTERISTICAS_BY_DEPTO_VER_EDITAR", conn);//SP_GET_CARACTERISTICAS_BY_DEPTO
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        CEDeptoListaJoin departamento = new CEDeptoListaJoin
                        {
                            idDepto = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            de_nombre = Convert.ToString(mostrarTabla["DE_NOMBRE"].ToString()),
                            descripcionDepto = Convert.ToString(mostrarTabla["DE_DESCRIPCION"].ToString()),
                            precioDepto = Convert.ToInt32(mostrarTabla["DE_PRECIO"]),
                            de_start = Convert.ToInt32(mostrarTabla["DE_START"]),
                            idTipoDepto = Convert.ToInt32(mostrarTabla["IDTIPODEPARTAMENTO"]),
                            idEstadoDepto = Convert.ToInt32(mostrarTabla["IDESTADODEPARTAMENTO"]),
                            tipoDepto = Convert.ToString(mostrarTabla["TD_DESCRIPCION"].ToString()),
                            estadoDepto = Convert.ToString(mostrarTabla["ED_DESCRIPCION"].ToString()),



                            IdCaracteristica = Convert.ToInt32(mostrarTabla["IDCARACTERISTICA"]),
                            Ca_NumDepto = Convert.ToString(mostrarTabla["CA_NUMDEPTO"]),
                            Ca_CantHabitaciones = Convert.ToInt32(mostrarTabla["CA_CANTHABITACIONES"]),
                            Ca_CantCamas = Convert.ToInt32(mostrarTabla["CA_CANTCAMAS"]),
                            Ca_CantBaño = Convert.ToInt32(mostrarTabla["CA_CANTBAÑO"]),
                            Ca_CapPersonas = Convert.ToInt32(mostrarTabla["CA_CAPPERSONAS"]),
                            Ca_CheckIn = Convert.ToString(mostrarTabla["CA_CHECKIN"].ToString()),
                            Ca_CheckOut = Convert.ToString(mostrarTabla["CA_CHECKOUT"].ToString()),
                            IdDepartamento = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            IdDirecion = Convert.ToInt32(mostrarTabla["IDDIRECCION"]),

                            comuna = Convert.ToString(mostrarTabla["C_DESCRIPCION"].ToString()),
                            region = Convert.ToString(mostrarTabla["RE_DESCRIPCION"].ToString()),
                            

                            idDireccion = Convert.ToInt32(mostrarTabla["IDDIRECCION"]),
                            de_direccion = Convert.ToString(mostrarTabla["DE_DIRECCION"]),
                            de_numero = Convert.ToString(mostrarTabla["DE_NUMERO"]),
                            id_comuna = Convert.ToInt32(mostrarTabla["IDCOMUNA"]),
                            idRegion = Convert.ToInt32(mostrarTabla["IDREGION"])
                        };


                        LISTA_DEPTO.Add(departamento);
                    };
                    conn.Close();
                }
                return LISTA_DEPTO;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
            catch (Exception ex)
            {
                throw new TechnicalException("Error al obtener listado de departamentos", ex);
            }
        }


        public List<CEAdjuntos> ListarAdjuntosJoin()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEAdjuntos> LISTA_ADJUNTOS = new List<CEAdjuntos>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();

                    OracleCommand command = new OracleCommand("SP_GET_ADJUNTO_BY_DEPTO_VER_EDITAR", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        CEAdjuntos departamentoAdjuntos = new CEAdjuntos
                        {
                            //depto
                            IDDEPARTAMENTO = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            nombreDepto = Convert.ToString(mostrarTabla["DE_NOMBRE"].ToString()),
                            //adjunto
                            IDADJUNTOHABITACION = Convert.ToInt32(mostrarTabla["IDADJUNTOHABITACION"]),
                            AD_NOMBRE = Convert.ToString(mostrarTabla["AD_NOMBRE"].ToString()),
                            AD_FECHACREACION = Convert.ToDateTime(mostrarTabla["AD_FECHACREACION"]),
                            AD_TIPOARCHIVO = Convert.ToString(mostrarTabla["AD_NOMBRE"].ToString()),
                            //sys_estado
                            IDESTADO = Convert.ToInt32(mostrarTabla["IDESTADO"]),
                            estado = Convert.ToString(mostrarTabla["ES_DESCRIPCION"].ToString())
                        };
                        LISTA_ADJUNTOS.Add(departamentoAdjuntos);
                    }
                    conn.Close();
                }
                return LISTA_ADJUNTOS;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
            catch (Exception ex)
            {
                throw new TechnicalException("Error al obtener listado de adjuntoos", ex);
            }
        }

        public bool EliminarAdjuntoPorId(CEAdjunto adjunto)
        {

            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Esta seguro de eliminar adjunto?", "Cambiar Adjunto", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        OracleCommand command = new OracleCommand("SP_SET_DELETE_ADJUNTO", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("IDADJ", OracleType.Number).Value = Convert.ToInt32(adjunto.IDADJUNTOHABITACION);

                        OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                        par.Direction = ParameterDirection.Output;
                        par.Size = 250;
                        command.Parameters.Add(par);
                        command.ExecuteNonQuery();
                        salida = command.Parameters["V_DETALLE"].Value.ToString();
                        conn.Close();
                    }
                }
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException orex)
            {
                return false;
            }
            catch (Exception ex)
            {
                //ex.Message;
                //ex.StackTrace;
                //agregar ex al Log
                return false;
            }

        }

        public List<CEAdjuntos> ListarAdjuntosJoinPorIdDepto(string idDepto)
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEAdjuntos> LISTA_ADJUNTOS = new List<CEAdjuntos>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();

                    OracleCommand command = new OracleCommand("SP_GET_ADJUNTO_BY_DEPTO_VER_EDITAR_BY_IDDEPTO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    command.Parameters.Add("IDDEPTO", OracleType.NVarChar).Value = idDepto;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        
                        CEAdjuntos departamentoAdjuntos = new CEAdjuntos
                        {
                            
                            //depto
                            IDDEPARTAMENTO = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            nombreDepto = Convert.ToString(mostrarTabla["DE_NOMBRE"].ToString()),
                            //adjunto
                            IDADJUNTOHABITACION = Convert.ToInt32(mostrarTabla["IDADJUNTOHABITACION"]),
                            AD_NOMBRE = Convert.ToString(mostrarTabla["AD_NOMBRE"].ToString()),
                            AD_FECHACREACION = Convert.ToDateTime(mostrarTabla["AD_FECHACREACION"]),
                            AD_TIPOARCHIVO = Convert.ToString(mostrarTabla["AD_NOMBRE"].ToString()),
                            //sys_estado
                            IDESTADO = Convert.ToInt32(mostrarTabla["IDESTADO"]),
                            estado = Convert.ToString(mostrarTabla["ES_DESCRIPCION"].ToString())
                        };
                        LISTA_ADJUNTOS.Add(departamentoAdjuntos);
                    }
                    conn.Close();     
                }
                return LISTA_ADJUNTOS;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
            catch (Exception ex)
            {
                throw new TechnicalException("Error al obtener listado de adjuntoos", ex);
            }
        }
        #endregion

        #region ListarDepartamento

        public List<CEDepartamento> ListarDepartamento()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEDepartamento> LISTA_DEPARTAMENTOS = new List<CEDepartamento>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();

                    OracleCommand command = new OracleCommand("SP_GET_ALL_DEPARTAMENTO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        LISTA_DEPARTAMENTOS.Add(new CEDepartamento
                        {
                            idDepto = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            de_nombre = Convert.ToString(mostrarTabla["DE_NOMBRE"].ToString()),
                            descripcionDepto = Convert.ToString(mostrarTabla["DE_DESCRIPCION"].ToString()),
                            precioDepto = Convert.ToInt32(mostrarTabla["DE_PRECIO"]),
                            de_start = Convert.ToInt32(mostrarTabla["DE_START"]),

                            idTipoDepto = Convert.ToInt32(mostrarTabla["IDTIPODEPARTAMENTO"]),
                            idEstadoDepto = Convert.ToInt32(mostrarTabla["IDESTADODEPARTAMENTO"])

                            //idDireccion = Convert.ToInt32(mostrarTabla["IDDIRECCION"]),
                            //idCaracteristicas = Convert.ToInt32(mostrarTabla["IDCARACTERISTICA"])
                        });
                    }
                    conn.Close();
                }
                return LISTA_DEPARTAMENTOS;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }
        #endregion

        public List<CEDepartamento> ListarDepartamentoJoinCaractJoinDireccion()
        {
            try
            {
                OracleDataReader mostrarTabla;

                List<CEDepartamento> LISTA_DEPARTAMENTOS = new List<CEDepartamento>();



                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();

                    OracleCommand command = new OracleCommand("SP_GET_ALL_DEPARTAMENTO_JOIN_CARACT_JOIN_DIRECCION", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        CEDepartamento depto = new CEDepartamento();
                        LISTA_DEPARTAMENTOS.Add(new CEDepartamento
                        {

                            idDepto = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            de_nombre = Convert.ToString(mostrarTabla["DE_NOMBRE"].ToString()),


                            descripcionDepto = Convert.ToString(mostrarTabla["DE_DESCRIPCION"].ToString()),
                            precioDepto = Convert.ToInt32(mostrarTabla["DE_PRECIO"]),
                            de_start = Convert.ToInt32(mostrarTabla["DE_START"]),

                            idTipoDepto = Convert.ToInt32(mostrarTabla["IDTIPODEPARTAMENTO"]),
                            idEstadoDepto = Convert.ToInt32(mostrarTabla["IDESTADODEPARTAMENTO"]),

                            idDireccion = Convert.ToInt32(mostrarTabla["IDDIRECCION"]),
                            idCaracteristicas = Convert.ToInt32(mostrarTabla["IDCARACTERISTICA"]),





                        });
                    }
                    conn.Close();
                }
                return LISTA_DEPARTAMENTOS;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }

        public List<CECaracteristicas_Departamento> ListaCaracteristicasDepto()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CECaracteristicas_Departamento> LISTA_Caract_DEPTO = new List<CECaracteristicas_Departamento>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_DEPARTAMENTO_IDDIRECCION_IDCARACTERISTCA", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        LISTA_Caract_DEPTO.Add(new CECaracteristicas_Departamento
                        {
                            IdCaracteristica = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            Ca_CantHabitaciones = Convert.ToInt32(mostrarTabla["CA_CANTHABITACIONES"]),
                            Ca_CantCamas = Convert.ToInt32(mostrarTabla["CA_CANTCAMAS"]),
                            Ca_CantBaño = Convert.ToInt32(mostrarTabla["CA_CANTBAÑO"]),
                            Ca_CapPersonas = Convert.ToInt32(mostrarTabla["CA_CAPPERSONAS"]),

                            Ca_CheckIn = Convert.ToString(mostrarTabla["CA_CHECKIN"].ToString()),
                            Ca_CheckOut = Convert.ToString(mostrarTabla["CA_CHECKOUT"].ToString()),

                            IdDepartamento = Convert.ToInt32(mostrarTabla["IDDEPARTAMENTO"]),
                            IdDirecion = Convert.ToInt32(mostrarTabla["IDDIRECCION"]),
                            //idDireccion = Convert.ToInt32(mostrarTabla["IDDIRECCION"]),
                            //idCaracteristicas = Convert.ToInt32(mostrarTabla["IDCARACTERISTICA"])

                        });
                    }
                    conn.Close();
                }
                return LISTA_Caract_DEPTO;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }

        public bool EditarDepartamento(CEDepartamento depto)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_SET_UPDATE_DEPTO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add("IDDEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idDepto);

                    command.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = depto.de_nombre;
                    command.Parameters.Add("DESCRIPCION", OracleType.NVarChar).Value = depto.descripcionDepto;
                    command.Parameters.Add("PRECIO", OracleType.Number).Value = Convert.ToInt32(depto.precioDepto);
                    command.Parameters.Add("STARS", OracleType.Number).Value = Convert.ToInt32(depto.de_start);
                    command.Parameters.Add("IDTIPODEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idTipoDepto);
                    command.Parameters.Add("IDESTADODEPTO", OracleType.Number).Value = Convert.ToInt32(depto.idEstadoDepto);


                    command.Parameters.Add("IDDIREC", OracleType.Number).Value = Convert.ToInt32(depto.direccion.idDireccion);

                    command.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = depto.direccion.de_direccion;
                    command.Parameters.Add("NUMDIREC", OracleType.NVarChar).Value = depto.direccion.de_numero;
                    command.Parameters.Add("IDCOMUNADIREC", OracleType.Number).Value = Convert.ToInt32(depto.direccion.id_comuna);

                    command.Parameters.Add("IDCARACT", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.IdCaracteristica);

                    command.Parameters.Add("CANTHAB", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantHabitaciones);
                    command.Parameters.Add("CANTCAMAS", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantCamas);
                    command.Parameters.Add("CANTBANIO", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CantBaño);
                    command.Parameters.Add("CANTPERS", OracleType.Number).Value = Convert.ToInt32(depto.carateristicasDepartamento.Ca_CapPersonas);

                    command.Parameters.Add("CHECKIN", OracleType.NVarChar).Value = depto.carateristicasDepartamento.Ca_CheckIn;
                    command.Parameters.Add("CHECKOUT", OracleType.NVarChar).Value = depto.carateristicasDepartamento.Ca_CheckOut;

                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();

                    conn.Close();
                }
                //agregara salida a un Log
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;


            }
            catch (OracleException orex)
            {
                return false;
            }
            catch (Exception ex)
            {
                //ex.Message;
                //ex.StackTrace;
                //agregar ex al Log
                return false;
            }
        }
    }
}
