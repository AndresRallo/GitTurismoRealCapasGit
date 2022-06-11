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
    public class CDReserva
    {
        string conexion = ConfigurationManager.AppSettings["conn"];

        #region Add reserva
        public bool AddReserva(CEReserva reserva)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();

                    //-> cambiar name sp y probar
                    OracleCommand command = new OracleCommand("SP_SET_ADD_RESERVA_SERVICIO", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("FECHAS", OracleType.DateTime).Value = reserva.RS_FECHAINGRESO;
                    command.Parameters.Add("IDRESERVA", OracleType.Number).Value = reserva.IDRESERVA;
                    command.Parameters.Add("IDSERVICIO", OracleType.Number).Value = reserva.IDSERVICIO;
                    command.Parameters.Add("ID_EMPLEADO", OracleType.Number).Value = reserva.IDEMPLEADO;
                    command.Parameters.Add("HORA", OracleType.LongVarChar).Value = reserva.RS_HORA;
                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.LongVarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();
                    conn.Close();
                }
                //response varification
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException e)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region Delete Reserva
        public bool DeleteReserva(CEReserva reserva)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    DialogResult result;
                    result = MessageBox.Show("¿Esta seguro de eliminar la reserva?", "Eliminar Reserva", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        //-->cambiar name de sp y parametros 
                        OracleCommand command = new OracleCommand("SP_SET_STATUS_CHANGE_RESERVA_SERVICIO", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("IDRESERVASERVICIO", OracleType.Int32).Value = reserva.IDRESERVA;
                        command.Parameters.Add("IDESTADORESERVASERVICIO", OracleType.Int32).Value = 1;

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
            catch (OracleException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region UpdateReserva
        public bool UpdateReserva(CEReserva reserva)
        {
            try
            {
                string salida = string.Empty;
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    conn.Open();
                    //--->cambiar name de sp y verificar los nombres de las variables
                    OracleCommand command = new OracleCommand("SP_UPDATE_RESERVA", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("IdReserva", OracleType.Int32).Value = reserva.IDRESERVA;
                    command.Parameters.Add("FECHAS", OracleType.DateTime).Value = reserva.RS_FECHAINGRESO;
                    command.Parameters.Add("idempleado", OracleType.Int32).Value = reserva.IDEMPLEADO;
                    command.Parameters.Add("IDRESERVA", OracleType.Int32).Value = reserva.IDRESERVA;
                    command.Parameters.Add("IDSERVICIO", OracleType.Int32).Value = reserva.IDSERVICIO;
                    command.Parameters.Add("Hora", OracleType.DateTime).Value = reserva.RS_HORA;
                    command.Parameters.Add("IDESTADORESERVASERVICIO", OracleType.Int32).Value = reserva.IDESTADORESERVASERVICIO;
                    OracleParameter par = new OracleParameter("V_DETALLE", OracleType.VarChar);
                    par.Direction = ParameterDirection.Output;
                    par.Size = 250;
                    command.Parameters.Add(par);
                    command.ExecuteNonQuery();
                    salida = command.Parameters["V_DETALLE"].Value.ToString();
                    conn.Close();
                }
                //response varification
                if (string.IsNullOrEmpty(salida))
                    return true;
                else
                    return false;
            }
            catch (OracleException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region ListReserva
        public List<CEReserva> ListALLReserva()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEReserva> reservas = new List<CEReserva>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_RESERVA_SERVICIOS", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        reservas.Add(new CEReserva
                        {
                            RS_FECHAINGRESO = DateTime.Parse(mostrarTabla["RS_FECHAINGRESO"].ToString()),
                            IDRESERVA = int.Parse(mostrarTabla["IDRESERVA"].ToString()),
                            IDSERVICIO = int.Parse(mostrarTabla["IDSERVICIO"].ToString()),
                            IDEMPLEADO = int.Parse(mostrarTabla["IDEMPLEADO"].ToString()),
                            RS_HORA = mostrarTabla["RS_HORA"].ToString(),
                            IDESTADORESERVASERVICIO = int.Parse(mostrarTabla["IDESTADORESERVASERVICIO"].ToString())
                        });
                    }
                    conn.Close();
                }
                return reservas;

            }
            catch (OracleException)
            {
                throw new TechnicalException("LISTA NO ENCONTRADA, CONTACTAR CON AREA DE SOPORTE");
            }
        }
        #endregion
    }
}
