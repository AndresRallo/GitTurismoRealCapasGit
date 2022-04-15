using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using CapaEntidad;
using System.Windows.Forms;
using System.Configuration;

namespace CapaDatos
{
    public class CDCliente
    {
        string conexion = ConfigurationManager.AppSettings["conn"];

        public void PruebaConexion()
        {
            OracleConnection oracleConnection = new OracleConnection(conexion);

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
            OracleConnection oracleConnection = new OracleConnection(conexion);
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
