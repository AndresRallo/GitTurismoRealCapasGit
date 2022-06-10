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
                    OracleCommand command = new OracleCommand("SP_SET_ADD_RESERVA", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("FECHAS", OracleType.DateTime).Value = reserva.FECHAS;
                    command.Parameters.Add("Hora", OracleType.DateTime).Value = reserva.Hora;
                    command.Parameters.Add("idempleado", OracleType.Int32).Value = reserva.idempleado;
                    command.Parameters.Add("IDRESERVA", OracleType.Int32).Value = reserva.IDRESERVA;
                    command.Parameters.Add("IDSERVICIO", OracleType.VarChar).Value = reserva.IDSERVICIO;
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
                        OracleCommand command = new OracleCommand("SP_SET_STATUS_CHANGE_RESERVA", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("IdReserva", OracleType.Number).Value = reserva.IDRESERVA;
                        command.Parameters.Add("IDESTADO", OracleType.Number).Value = 1;

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
                    command.Parameters.Add("IdReserva", OracleType.Number).Value = reserva.IDRESERVA;
                    command.Parameters.Add("FECHAS", OracleType.DateTime).Value = reserva.FECHAS;
                    command.Parameters.Add("Hora", OracleType.DateTime).Value = reserva.Hora;
                    command.Parameters.Add("idempleado", OracleType.Int32).Value = reserva.idempleado;
                    command.Parameters.Add("IDRESERVA", OracleType.Int32).Value = reserva.IDRESERVA;
                    command.Parameters.Add("IDSERVICIO", OracleType.VarChar).Value = reserva.IDSERVICIO;
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
                    OracleCommand command = new OracleCommand("SP_GET_ALL_Reserva", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        reservas.Add(new CEReserva
                        {
                            FECHAS = DateTime.Parse(mostrarTabla["FECHAS"].ToString()),
                            Hora = mostrarTabla["Hora"].ToString(),
                            idempleado = int.Parse(mostrarTabla["idempleado"].ToString()),
                            IDRESERVA = int.Parse(mostrarTabla["IDRESERVA"].ToString()),
                            IDSERVICIO = int.Parse(mostrarTabla["IDSERVICIO"].ToString()),

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
