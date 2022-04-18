using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
