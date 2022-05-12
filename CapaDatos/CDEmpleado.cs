using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;
using CapaEntidad;
using System.Data;
using System.Configuration;
using TurismoRealExceptions;

namespace CapaDatos
{
    public class CDEmpleado
    {
        string conexion = ConfigurationManager.AppSettings["conn"];

        public void ValidarDatos(CEEmpleado cE)
        {
            OracleConnection conn = new OracleConnection(conexion);
            
            
            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand();
                command.CommandText = "select * from empleado where (em_email=@user and em_contraseña=@pass) or (Email=@user and password=@pass)";
                command.Parameters.AddWithValue("@user", OracleType.NVarChar).Value = cE.EM_EMAIL;
                command.Parameters.AddWithValue("@pass", OracleType.NVarChar).Value = cE.EM_CONTRASEÑA;
                OracleDataReader leerLogin = command.ExecuteReader();
                if(leerLogin.Read())
                {
                    MessageBox.Show("Bienvenido a Turismo Real");
                }else
                {
                    MessageBox.Show("Credenciales Incorrectas");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error "+ ex);
            }
            
            conn.Close();
           
            /*
            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand();

                command.CommandText = "select * from empleado where (em_email=@user and em_contraseña=@pass) or (Email=@user and password=@pass)";
                command.Parameters.AddWithValue("@user", em_email);
                command.Parameters.AddWithValue("@pass", em_contraseña);
                command.CommandType = CommandType.Text;
                leerLogin = command.ExecuteReader();
                if (leerLogin.HasRows)
                {
                    while (leerLogin.Read()) 
                    {
                        Console.WriteLine()
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            */
        }

        /// <summary>
        /// Busca en el procedimiento almacenado "SP_GET_EMAIL_EMPLEADO" el usuario segun correo
        /// </summary>
        /// <param name="email">cooreo del usuario a buscar</param>
        /// <returns>entidad empleado</returns>
        public static CEEmpleado getUserByEmail(string email)
        {
            try
            {
                CEEmpleado cE = new CEEmpleado();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_EMAIL_EMPLEADO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("EMAIL", OracleType.NVarChar).Value = email;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    command.ExecuteReader();
                    OracleDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cE.IDEMPLEADO = Convert.ToInt32(reader["idempleado"]);
                        cE.EM_CONTRASEÑA = reader["em_contraseña"].ToString();
                        cE.EM_RUT = reader["em_rut"].ToString();
                        cE.EM_DV = reader["em_dv"].ToString();
                        cE.EM_NOMBRE = reader["em_nombre"].ToString();
                        cE.EM_APATERNO = reader["em_apaterno"].ToString();
                        cE.EM_AMATERNO = reader["em_amaterno"].ToString();
                        cE.EM_EMAIL = reader["em_email"].ToString();
                        cE.IDTIPOEMPLEADO = Convert.ToInt32(reader["idtipoempleado"]);
                        cE.IDDIRECCION = Convert.ToInt32(reader["iddireccion"]);
                        cE.IDESTADO = Convert.ToInt32(reader["idestado"]);
                        cE.IDEMPRESA = Convert.ToInt32(reader["idempresa"]);
                    }
                    conn.Close();
                }

                return cE;
            }
            catch (Exception ex)
            {
                throw new TechnicalException("No es posible obtener los datos del usuario por email, emal: " + email);
            }
        }

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

        public List<CE_TIPOEMPLEADO> TIPOEMPLEADO()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CE_TIPOEMPLEADO> LISTA_TIPOEMPLEADO = new List<CE_TIPOEMPLEADO>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_SYS_TIPO_EMPLEADO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        LISTA_TIPOEMPLEADO.Add(new CE_TIPOEMPLEADO
                        {
                            IDTIPOUSUARIO = Convert.ToInt32(mostrarTabla["IDTIPOUSUARIO"]),
                            TP_DESCRIPCION = Convert.ToString(mostrarTabla["TP_DESCRIPCION"].ToString())
                        });
                    }
                    conn.Close();
                }
                return LISTA_TIPOEMPLEADO;
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

        public List<CEEmpleado> Empleado()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEEmpleado> LISTA_EMPLEADO = new List<CEEmpleado>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_EMPLEADO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        LISTA_EMPLEADO.Add(new CEEmpleado
                        {
                            IDEMPLEADO = Convert.ToInt32(mostrarTabla["IDEMPLEADO"]),
                            EM_RUT = Convert.ToString(mostrarTabla["EM_RUT"].ToString()),
                            EM_DV = Convert.ToString(mostrarTabla["EM_DV"].ToString()),
                            EM_NOMBRE = Convert.ToString(mostrarTabla["EM_NOMBRE"].ToString()),
                            EM_APATERNO = Convert.ToString(mostrarTabla["EM_APATERNO"].ToString()),
                            EM_AMATERNO = Convert.ToString(mostrarTabla["EM_AMATERNO"].ToString()),
                            EM_EMAIL = Convert.ToString(mostrarTabla["EM_EMAIL"].ToString()),
                            EM_CONTRASEÑA = Convert.ToString(mostrarTabla["EM_CONTRASEÑA"].ToString()),
                            IDEMPRESA = Convert.ToInt32(mostrarTabla["IDEMPRESA"]),
                            IDTIPOEMPLEADO = Convert.ToInt32(mostrarTabla["IDTIPOEMPLEADO"]),
                            IDESTADO = Convert.ToInt32(mostrarTabla["IDESTADO"]),
                            IDDIRECCION = Convert.ToInt32(mostrarTabla["IDDIRECCION"])
                        });
                    }
                    conn.Close();
                }
                return LISTA_EMPLEADO;
            }
            catch (OracleException oex)
            {

                throw new TechnicalException("LISTA NO ENCONTRADA" + oex.Message);
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

        public bool AgregarEmpleado(CEEmpleado cE)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_SET_ADD_EMPLEADO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("RUTEMP", OracleType.Number).Value = Convert.ToInt32(cE.EM_RUT);
                    command.Parameters.Add("DVEMP", OracleType.Char).Value = cE.EM_DV;
                    command.Parameters.Add("NOMBREEMP", OracleType.NVarChar).Value = cE.EM_NOMBRE;
                    command.Parameters.Add("APATERNOEMP", OracleType.NVarChar).Value = cE.EM_APATERNO;
                    command.Parameters.Add("AMATERNOEMP", OracleType.NVarChar).Value = cE.EM_AMATERNO;
                    command.Parameters.Add("EMAILEMP", OracleType.NVarChar).Value = cE.EM_EMAIL;
                    command.Parameters.Add("PWSEMP", OracleType.NVarChar).Value = cE.EM_CONTRASEÑA;
                    command.Parameters.Add("IDEMP", OracleType.Number).Value = Convert.ToInt32(cE.IDEMPRESA);
                    command.Parameters.Add("IDTIPOEMP", OracleType.Number).Value = Convert.ToInt32(cE.IDTIPOEMPLEADO);
                    command.Parameters.Add("IDESTADOEMP", OracleType.Number).Value = Convert.ToInt32(cE.IDESTADO);
                    command.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = Convert.ToString(cE.direccion.de_direccion);
                    command.Parameters.Add("NUMDIREC", OracleType.NVarChar).Value = cE.direccion.de_numero;
                    command.Parameters.Add("IDCOMUNADIREC", OracleType.Number).Value = Convert.ToInt32(cE.direccion.id_comuna);
                    command.Parameters.Add("MARCA", OracleType.NVarChar).Value = cE.vehiculo.marca_ve;
                    command.Parameters.Add("ANIO", OracleType.Number).Value = Convert.ToInt32(cE.vehiculo.anio_ve);
                    command.Parameters.Add("PATENTE", OracleType.NVarChar).Value = cE.vehiculo.patente_ve;
                    //command.Parameters.Add("V_DETALLE", OracleType.NVarChar).Direction = ParameterDirection.Output;
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

                #region procedimiento almacenado
                /*
                create or replace procedure agregarEmpleado(rutEmp in number, dvEmp in char, nomEmp in nvarchar2, aPaternoEmp in nvarchar2, aMaternoEmp in nvarchar2, emailEmp in nvarchar2, 
                contraseniaEmp in nvarchar2,
                idEmpresaEmp in number, idTipoEmp in number, idEstadoEmp in number, idDireccionEmp in number)
                as
                  Begin
                    insert into empleado (em_rut,em_dv,em_nombre,em_apaterno,em_amaterno,em_email,em_contraseña,idempresa,id_tipoempleado,idestado,id_direccion) 
                    values(rutEmp,dvEmp,nomEmp,aPaternoEmp,aMaternoEmp,emailEmp,contraseniaEmp,idEmpresaEmp,idTipoEmp,idEstadoEmp,idDireccionEmp);
                end;
                */
                #endregion
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

        public void EditarEmpleado(CEEmpleado cE)
        {
            OracleConnection conn = new OracleConnection(conexion);

            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand("actualizarEmpleado", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idEmpleado", OracleType.Number).Value = Convert.ToInt32(cE.IDEMPLEADO);
                command.Parameters.Add("rutEmp", OracleType.Number).Value = Convert.ToInt32(cE.EM_RUT);
                command.Parameters.Add("dvEmp", OracleType.Char).Value = cE.EM_DV;
                command.Parameters.Add("nomEmp", OracleType.NVarChar).Value = cE.EM_NOMBRE;
                command.Parameters.Add("aPaternoEmp", OracleType.NVarChar).Value = cE.EM_APATERNO;
                command.Parameters.Add("aMaternoEmp", OracleType.NVarChar).Value = cE.EM_AMATERNO;
                command.Parameters.Add("emailEmp", OracleType.NVarChar).Value = cE.EM_EMAIL;
                command.Parameters.Add("contraseniaEmp", OracleType.NVarChar).Value = cE.EM_CONTRASEÑA;
                command.Parameters.Add("idEmpresaEmp", OracleType.Number).Value = Convert.ToInt32(cE.IDEMPRESA);
                command.Parameters.Add("idTipoEmp", OracleType.Number).Value = Convert.ToInt32(cE.IDTIPOEMPLEADO);
                command.Parameters.Add("idEstadoEmp", OracleType.Number).Value = Convert.ToInt32(cE.IDESTADO);
                command.Parameters.Add("idDireccionEmp", OracleType.Number).Value = Convert.ToInt32(cE.IDDIRECCION);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("No conectado");

            }
            conn.Close();
            MessageBox.Show("Empleado Actualizado");
            #region procedimiento almacenado
            /*
             create or replace PROCEDURE actualizarEmpleado(idEmpleado in Number, rutEmp in number, dvEmp in char, nomEmp in nvarchar2, aPaternoEmp in nvarchar2, aMaternoEmp in nvarchar2, emailEmp in nvarchar2, 
             contraseniaEmp in nvarchar2,
                idEmpresaEmp in number, idTipoEmp in number, idEstadoEmp in number, idDireccionEmp in number)
                as
                    vid NUMBER := idEmpleado;
                    vrut NUMBER := rutEmp;
                    vdv char := dvEmp;
                    vnom nvarchar2(50) := nomEmp;
                    vaPaterno nvarchar2(50) := aPaternoEmp;
                    vaMaterno nvarchar2(50) := aMaternoEmp;
                    vEmail nvarchar2(50) := emailEmp;
                    vContrasenia nvarchar2(50) := contraseniaEmp;
                    vIdEmpresa NUMBER := idEmpresaEmp;
                    vIdTipo NUMBER := idTipoEmp;
                    vIdEstado NUMBER := idEstadoEmp;
                    vIdDireccion NUMBER := idDireccionEmp;
                begin
                    update empleado set EM_RUT = vrut, EM_DV = vdv, em_nombre = vnom,
                    em_apaterno=vaPaterno, em_amaterno=vaMaterno, em_email=vEmail,
                    EM_CONTRASEÑA=vContrasenia, idempresa=vIdEmpresa, id_tipoempleado=vIdTipo,
                    idestado=vIdEstado, id_direccion=vIdDireccion
                WHERE        idempleado = vid;
                Exception
                    when NO_DATA_FOUND then
                    null;
                    When others then
                    raise;
                END actualizarEmpleado;
             */
            #endregion
        }

        public void EliminarEmpleado(CEEmpleado cE) 
        {
            OracleConnection conn = new OracleConnection(conexion);
            try
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta seguro de eliminar este empleado?", "Eliminar Empleado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("eliminarEmpleado", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("idEmpleado", OracleType.Number).Value = Convert.ToInt32(cE.IDEMPLEADO);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Empleado Eliminado");
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

            conn.Close();
            #region procedimiento almacenado
            /* Procedimiento almacenado 
             Create or replace procedure eliminarEmpleado (idEmpleado in NUMBER)
             as
                vid number := idEmpleado;
             begin
                delete from empleado where idempleado = vid;
             END;
             */
            #endregion
        }
    }
}
