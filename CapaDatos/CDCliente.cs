using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDCliente
    {
        string cadenaConexion = "DATA SOURCE=localhost:1521/XEPDB1 ; PASSWORD=123456; USER ID=TURISMOADMIN;";

        public void PruebaConexion()
        {
            OracleConnection oracleConnection = new OracleConnection(cadenaConexion);

            try
            {
                oracleConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conecta a la BD" + ex.Message);
                return;
            }
            oracleConnection.Close();
            MessageBox.Show("Conectado :)");
        }

        public void Crear(CECliente cE)
        {
            OracleConnection oracleConnection = new OracleConnection(cadenaConexion);
            oracleConnection.Open();



            //try
            //{
            //    string query = "SELECT * FROM EMPLEADO WHERE EM_RUT = " + cE.em_rut + "AND EM_CONTRASEÑA = " + cE.em_contrasena;
            //    OracleCommand oracleCommand = new OracleCommand(query, oracleConnection);
            //    oracleCommand.ExecuteNonQuery();
            //    oracleConnection.Close();
            //    MessageBox.Show("Bien venido ");
            //}
            //catch (Exception)
            //{
            //    oracleConnection.Close();
            //    MessageBox.Show("No conectado");
            //    throw;
            //}
            ////////////////////




            OracleCommand comando = new OracleCommand("SELECT * FROM EMPLEADO WHERE EM_RUT = :rut AND EM_CONTRASEÑA = :contra", oracleConnection);

            comando.Parameters.AddWithValue(":rut", Int32.Parse(cE.em_rut));//UsuarioBO.empleado.em_rut
            comando.Parameters.AddWithValue(":contra", cE.em_contrasena);//UsuarioBO.empleado.em_rut

            //OracleDataReader lector = comando.ExecuteReader();
           // var result = comando.ExecuteNonQuery();
            //string Query = "";

            oracleConnection.Close();

        }
    }
}
