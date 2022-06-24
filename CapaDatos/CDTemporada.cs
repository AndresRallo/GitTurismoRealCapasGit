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
    public class CDTemporada
    {
        string conexion = ConfigurationManager.AppSettings["conn"];

        #region ListReserva
        public List<CETemporada> ListALLTemporada()
        {
            try
            {
                OracleDataReader mostrarTabla;
                List<CETemporada> temporada = new List<CETemporada>();
                using (OracleConnection conn = new OracleConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("SP_GET_ALL_Temporada", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("V_RESULT", OracleType.Cursor).Direction = ParameterDirection.Output;
                    mostrarTabla = command.ExecuteReader();
                    while (mostrarTabla.Read())
                    {
                        temporada.Add(new CETemporada
                        {
                            IDTEMPORADAy = int.Parse(mostrarTabla["IDTEMPORADA"].ToString()),
                            TE_DESCRIPCION = mostrarTabla["TE_DESCRIPCION"].ToString(),
                        });
                    }
                    conn.Close();
                }
                return temporada;

            }
            catch (OracleException)
            {
                throw new TechnicalException("LISTA NO ENCONTRADA, CONTACTAR CON AREA DE SOPORTE");
            }
        }
        #endregion
    }
}
