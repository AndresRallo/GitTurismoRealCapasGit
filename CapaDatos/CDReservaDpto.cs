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
    public class CDReservaDpto
    {
        string conexion = ConfigurationManager.AppSettings["conn"];

        #region Add reserva
        public bool AddReserva(CEReservaDpto service)
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
                    command.Parameters.Add("FECHAEN", OracleType.DateTime).Value = service.FECHAEN;
                    command.Parameters.Add("FECHASA", OracleType.DateTime).Value = service.FECHASA;
                    command.Parameters.Add("ABONO", OracleType.Int32).Value = service.ABONO;
                    command.Parameters.Add("TOTAL", OracleType.Int32).Value = service.TOTAL;
                    command.Parameters.Add("CANTADULTOS", OracleType.VarChar).Value = service.CANTADULTOS;
                    command.Parameters.Add("CANTNINIOS", OracleType.VarChar).Value = service.CANTNINIOS;
                    command.Parameters.Add("IDUSUARIO", OracleType.Int32).Value = service.IDUSUARIO;
                    command.Parameters.Add("IDDEPTO", OracleType.Int32).Value = service.IDDEPTO;
                    command.Parameters.Add("ESTADORESERVA", OracleType.Int32).Value = service.ESTADORESERVA;
                    command.Parameters.Add("IDEMPLEADO", OracleType.Int32).Value = service.IDEMPLEADO;
                    command.Parameters.Add("IDTEMPORADA", OracleType.Int32).Value = service.IDTEMPORADA;
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
        public bool DeleteReserva(CEReservaDpto reserva)
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
        public bool UpdateReserva(CEReservaDpto reserva)
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
                    command.Parameters.Add("IDRESERVA", OracleType.Number).Value = reserva.IDRESERVA;
                    command.Parameters.Add("FECHAEN", OracleType.DateTime).Value = reserva.FECHAEN;
                    command.Parameters.Add("FECHASA", OracleType.DateTime).Value = reserva.FECHASA;
                    command.Parameters.Add("ABONO", OracleType.Int32).Value = reserva.ABONO;
                    command.Parameters.Add("TOTAL", OracleType.Int32).Value = reserva.TOTAL;
                    command.Parameters.Add("CANTADULTOS", OracleType.VarChar).Value = reserva.CANTADULTOS;
                    command.Parameters.Add("CANTNINIOS", OracleType.VarChar).Value = reserva.CANTNINIOS;
                    command.Parameters.Add("IDUSUARIO", OracleType.Int32).Value = reserva.IDUSUARIO;
                    command.Parameters.Add("IDDEPTO", OracleType.Int32).Value = reserva.IDDEPTO;
                    command.Parameters.Add("ESTADORESERVA", OracleType.Int32).Value = reserva.ESTADORESERVA;
                    command.Parameters.Add("IDEMPLEADO", OracleType.Int32).Value = reserva.IDEMPLEADO;
                    command.Parameters.Add("IDTEMPORADA", OracleType.Int32).Value = reserva.IDTEMPORADA;
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
        public List<CEReservaDpto> ListALLReserva()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEReservaDpto> reservas = new List<CEReservaDpto>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_Reserva", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        reservas.Add(new CEReservaDpto
                        {
                            IDRESERVA = int.Parse(mostrarTabla["IDRESERVA"].ToString()),
                            FECHAEN = DateTime.Parse(mostrarTabla["FECHAEN"].ToString()),
                            FECHASA = DateTime.Parse(mostrarTabla["FECHASA"].ToString()),
                            ABONO = int.Parse(mostrarTabla["ABONO"].ToString()),
                            TOTAL = int.Parse(mostrarTabla["TOTAL"].ToString()),
                            CANTADULTOS = int.Parse(mostrarTabla["CANTADULTOS"].ToString()),
                            CANTNINIOS = int.Parse(mostrarTabla["CANTNINIOS"].ToString()),
                            IDUSUARIO = int.Parse(mostrarTabla["IDUSUARIO"].ToString()),
                            IDDEPTO = int.Parse(mostrarTabla["IDDEPTO"].ToString()),
                            ESTADORESERVA = int.Parse(mostrarTabla["ESTADORESERVA"].ToString()),
                            IDEMPLEADO = int.Parse(mostrarTabla["IDEMPLEADO"].ToString()),
                            IDTEMPORADA = int.Parse(mostrarTabla["IDTEMPORADA"].ToString()),
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
