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

        public void EditarUsuario(CEUsuario cEUsuario)
        {
            OracleConnection conn = new OracleConnection(conexion);

            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand("actualizarUsuario", conn);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idUsuario", OracleType.Number).Value = Convert.ToInt32(cEUsuario.IDUSUARIO);
                command.Parameters.Add("rutUs", OracleType.Number).Value = Convert.ToInt32(cEUsuario.US_RUT);
                command.Parameters.Add("dvUs", OracleType.Char).Value = cEUsuario.US_DV;
                command.Parameters.Add("nomUs", OracleType.NVarChar).Value = cEUsuario.US_NOMBRE;
                command.Parameters.Add("aPaternoUs", OracleType.NVarChar).Value = cEUsuario.US_APATERNO;
                command.Parameters.Add("aMaternoUs", OracleType.NVarChar).Value = cEUsuario.US_AMATERNO;
                command.Parameters.Add("telefonoUs", OracleType.NVarChar).Value = cEUsuario.US_TELEFONO;
                command.Parameters.Add("emailUs", OracleType.NVarChar).Value = cEUsuario.US_EMAIL;
                command.Parameters.Add("contraseniaUs", OracleType.NVarChar).Value = cEUsuario.US_CONTRASEÑA;
                command.Parameters.Add("idEstadoUs", OracleType.Number).Value = Convert.ToInt32(cEUsuario.IDESTADO);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No conectado" + ex);
            }
            conn.Close();
            MessageBox.Show("Usuario Actualizado");
        }
        public void AgregarUsuario(CEUsuario usuario)
        {
            OracleConnection conn = new OracleConnection(conexion);

            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand("agregarUsuario", conn);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("rutUs", OracleType.Number).Value = Convert.ToInt32(usuario.US_RUT);
                command.Parameters.Add("dvUs", OracleType.Char).Value = usuario.US_DV;
                command.Parameters.Add("nomUs", OracleType.NVarChar).Value = usuario.US_NOMBRE;
                command.Parameters.Add("aPaternoUs", OracleType.NVarChar).Value = usuario.US_APATERNO;
                command.Parameters.Add("aMaternoUs", OracleType.NVarChar).Value = usuario.US_AMATERNO;
                command.Parameters.Add("emailUs", OracleType.NVarChar).Value = usuario.US_EMAIL;
                command.Parameters.Add("contraseniaUs", OracleType.NVarChar).Value = usuario.US_CONTRASEÑA;
                command.Parameters.Add("telefonoUs", OracleType.NVarChar).Value = usuario.US_TELEFONO;
                command.Parameters.Add("idEstado", OracleType.Number).Value = Convert.ToInt32(usuario.IDESTADO);
                command.ExecuteNonQuery();
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
            catch (Exception ex)
            {

                MessageBox.Show("No conectado" + ex.Message);
            }
            conn.Close();
            MessageBox.Show("Usuario Agregado");
        }
        public DataTable Listar()
        {
            OracleConnection conn = new OracleConnection(conexion);
            OracleDataReader mostrarTabla;
            DataTable tablaUsuario = new DataTable();

            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand("seleccionarUsuarios", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                mostrarTabla = command.ExecuteReader();
                mostrarTabla.Read();
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = command;
                adaptador.Fill(tablaUsuario);

            }
            catch (Exception ex)
            {

                MessageBox.Show("No conectado" + ex.Message);
            }

            conn.Close();
            return tablaUsuario;
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
        public void EliminarUsuario(CEUsuario usuario)
        {
            OracleConnection conn = new OracleConnection(conexion);
            try
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta seguro de eliminar este empleado?", "Eliminar Empleado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("eliminarUsuario", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("idUsuario", OracleType.Number).Value = Convert.ToInt32(usuario.IDUSUARIO);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario Eliminado");
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
        }
    }
}
