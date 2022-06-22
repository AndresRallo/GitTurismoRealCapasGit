using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealExceptions;

namespace CapaDatos
{
    public class CDUsuario
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

        public bool EditarUsuario(CEUsuario cEUsuario)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_UPDATE_USUARIO", conn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("IDUSER", OracleType.Number).Value = Convert.ToInt32(cEUsuario.IDUSUARIO);
                    
                    command.Parameters.Add("NOMBREUSER", OracleType.NVarChar).Value = cEUsuario.US_NOMBRE;
                    command.Parameters.Add("APATERNOUSER", OracleType.NVarChar).Value = cEUsuario.US_APATERNO;
                    command.Parameters.Add("AMATERNOUSER", OracleType.NVarChar).Value = cEUsuario.US_AMATERNO;
                    
                    command.Parameters.Add("PWSUSER", OracleType.NVarChar).Value = cEUsuario.US_CONTRASEÑA;
                    
                    command.Parameters.Add("IDESTADOUSER", OracleType.Number).Value = Convert.ToInt32(cEUsuario.IDESTADO);
                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();

                    conn.Close();
                    #region procedimiento almacenado
                    /*
                    create or replace procedure agregarUsuario(rutUs in number, dvUs in char, nomUs in nvarchar2, aPaternoUs in nvarchar2, aMaternoUs in nvarchar2, emailUs in nvarchar2, 
                    contraseniaUs in nvarchar2,
                    telefonoUs in number,  idEstado in number)
                    as
                      Begin
                        insert into usuario (us_rut,us_dv,us_nombre,us_apaterno,us_amaterno,us_email,us_contraseña,us_telefono,idestado) 
                        values(rutUs,dvUs,nomUs,aPaternoUs,aMaternoUs,emailUs,contraseniaUs,telefonoUs,idEstado);
                    end;
                    */
                    #endregion
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
        public bool AgregarUsuario(CEUsuario usuario)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_SET_ADD_CLIENTE", conn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("RUTCLI", OracleType.Number).Value = Convert.ToInt32(usuario.US_RUT);
                    command.Parameters.Add("DVCLI", OracleType.Char).Value = usuario.US_DV;
                    command.Parameters.Add("NOMBRECLI", OracleType.NVarChar).Value = usuario.US_NOMBRE;
                    command.Parameters.Add("APATERNOCLI", OracleType.NVarChar).Value = usuario.US_APATERNO;
                    command.Parameters.Add("AMATERNOEMP", OracleType.NVarChar).Value = usuario.US_AMATERNO;
                    command.Parameters.Add("EMAILEMP", OracleType.NVarChar).Value = usuario.US_EMAIL;
                    command.Parameters.Add("PWSEMP", OracleType.NVarChar).Value = usuario.US_CONTRASEÑA;
                    command.Parameters.Add("TELEFONOEMP", OracleType.NVarChar).Value = usuario.US_TELEFONO;
                    command.Parameters.Add("IDTIPOCLI", OracleType.Number).Value = Convert.ToInt32(usuario.IDTIPOUSUARIO);
                    command.Parameters.Add("IDESTADOCLI", OracleType.Number).Value = Convert.ToInt32(usuario.IDESTADO);
                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();

                    conn.Close();
                    #region procedimiento almacenado
                    /*
                    create or replace procedure agregarUsuario(rutUs in number, dvUs in char, nomUs in nvarchar2, aPaternoUs in nvarchar2, aMaternoUs in nvarchar2, emailUs in nvarchar2, 
                    contraseniaUs in nvarchar2,
                    telefonoUs in number,  idEstado in number)
                    as
                      Begin
                        insert into usuario (us_rut,us_dv,us_nombre,us_apaterno,us_amaterno,us_email,us_contraseña,us_telefono,idestado) 
                        values(rutUs,dvUs,nomUs,aPaternoUs,aMaternoUs,emailUs,contraseniaUs,telefonoUs,idEstado);
                    end;
                    */
                    #endregion
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

        public List<CEUsuario> LISTAR_USUARIO()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEUsuario> LISTA_USUARIO = new List<CEUsuario>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_CLIENTE", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        LISTA_USUARIO.Add(new CEUsuario
                        {
                            IDUSUARIO = Convert.ToInt32(mostrarTabla["IDUSUARIO"]),
                            US_RUT = Convert.ToString(mostrarTabla["US_RUT"].ToString()),
                            US_DV = Convert.ToString(mostrarTabla["US_DV"].ToString()),
                            US_NOMBRE = Convert.ToString(mostrarTabla["US_NOMBRE"].ToString()),
                            US_APATERNO = Convert.ToString(mostrarTabla["US_APATERNO"].ToString()),
                            US_AMATERNO = Convert.ToString(mostrarTabla["US_AMATERNO"].ToString()),
                            US_TELEFONO = Convert.ToString(mostrarTabla["US_TELEFONO"].ToString()),
                            US_EMAIL = Convert.ToString(mostrarTabla["US_EMAIL"].ToString()),
                            US_CONTRASEÑA = Convert.ToString(mostrarTabla["US_CONTRASEÑA"].ToString()),
                            IDESTADO = Convert.ToInt32(mostrarTabla["IDESTADO"])
                            //  IDTIPOUSUARIO = Convert.ToString(mostrarTabla["IDUSUARIO"].ToString())

                        });
                    }
                    conn.Close();
                }
                return LISTA_USUARIO;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }

        public List<CEUSER_ESTADO> LISTAR_USUARIO_()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEUSER_ESTADO> LISTA_USUARIO = new List<CEUSER_ESTADO>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_USER_BY_ESTADO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        LISTA_USUARIO.Add(new CEUSER_ESTADO
                        {
                            IDUSUARIO = Convert.ToInt32(mostrarTabla["IDUSUARIO"]),
                            US_RUT = Convert.ToString(mostrarTabla["US_RUT"].ToString()),
                            US_DV = Convert.ToString(mostrarTabla["US_DV"].ToString()),
                            US_NOMBRE = Convert.ToString(mostrarTabla["US_NOMBRE"].ToString()),
                            US_APATERNO = Convert.ToString(mostrarTabla["US_APATERNO"].ToString()),
                            US_AMATERNO = Convert.ToString(mostrarTabla["US_AMATERNO"].ToString()),
                            US_TELEFONO = Convert.ToString(mostrarTabla["US_TELEFONO"].ToString()),
                            US_EMAIL = Convert.ToString(mostrarTabla["US_EMAIL"].ToString()),
                            US_CONTRASEÑA = Convert.ToString(mostrarTabla["US_CONTRASEÑA"].ToString()),
                            IDESTADO = Convert.ToInt32(mostrarTabla["IDESTADO"]),
                            ES_DESCRIPCION = Convert.ToString(mostrarTabla["ES_DESCRIPCION"].ToString())

                        });
                    }
                    conn.Close();
                }
                return LISTA_USUARIO;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }
        public List<CE_ESTADO> ESTADO()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CE_ESTADO> LISTA_ESTADO = new List<CE_ESTADO>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_SYS_ESTADO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        LISTA_ESTADO.Add(new CE_ESTADO
                        {
                            IDESTADO = Convert.ToInt32(mostrarTabla["IDESTADO"]),
                            ES_DESCRIPCION = Convert.ToString(mostrarTabla["ES_DESCRIPCION"].ToString())
                        });
                    }
                    conn.Close();
                }
                return LISTA_ESTADO;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
            }
        }
        public bool CAMBIAR_ESTADO_USUARIO(CEUsuario USUARIO)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Esta seguro de cambiar el estado del usuario?", "Cambiar Estado", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        OracleCommand command = new OracleCommand("SP_SET_STATUS_CHANGE_USUARIO", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("IDUSUARIO", OracleType.Number).Value = Convert.ToInt32(USUARIO.IDUSUARIO);
                        command.Parameters.Add("IDESTADO", OracleType.Number).Value = Convert.ToInt32(USUARIO.IDESTADO);

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
    }
}
