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
    public class CDComuna
    {
        string conexion = ConfigurationManager.AppSettings["conn"];

        #region ListReserva
        public List<CEComuna> ListALLComuna()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CEComuna> comuna = new List<CEComuna>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_SYS_COMUNA", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        comuna.Add(new CEComuna
                        {
                            idcomuna = int.Parse(mostrarTabla["idcomuna"].ToString()),
                            c_descripcion = mostrarTabla["c_descripcion"].ToString()
                        });
                    }
                    conn.Close();
                }
                return comuna;

            }
            catch (OracleException)
            {
                throw new TechnicalException("LISTA NO ENCONTRADA, CONTACTAR CON AREA DE SOPORTE");
            }
        }
        #endregion

    }
}
