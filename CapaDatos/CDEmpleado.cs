using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CDEmpleado
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


        public void InsertarEmpleado(CEEmpleado cE)
        {
            OracleConnection oracleConnection = new OracleConnection(cadenaConexion);
            oracleConnection.Open();

            try
            {
                
                string query = @"INSERT INTO empleado (
                                        
                                        EM_RUT,
                                        EM_DV,
                                        EM_NOMBRE,
                                        EM_APATERNO,
                                        EM_AMATERNO,
                                        EM_EMAIL,
                                        EM_CONTRASEÑA,
                                        IDEMPRESA,
                                        ID_TIPOEMPLEADO,
                                        IDESTADO,
                                        ID_DIRECCION) VALUES (" + cE.em_rut + ",'" + cE.em_dv + "','" + cE.em_nombre + "','" + cE.em_apaterno +"'," +
                                        "'"+ cE.emp_amaterno +"','"+ cE.em_mail +"','"+ cE.em_contrasena +"'," + cE.idEmpresa +","+ cE.idTipoEmleado + "," + cE.idEstado + "," + cE.idDireccion + ")";

                OracleCommand oracleCommand = new OracleCommand(query, oracleConnection);
                //OracleCommand command = new OracleCommand(query, oracleConnection);
                oracleCommand.ExecuteNonQuery();
                oracleConnection.Close();
                MessageBox.Show("Bien venido ");
            }
            catch (Exception ex)
            {
                oracleConnection.Close();
                MessageBox.Show("No conectado");
                
            }

        }

        public DataSet Listar()
        {
            OracleConnection oracleConnection = new OracleConnection(cadenaConexion);
            oracleConnection.Open();
            string query = "SELECT * FROM EMPLEADO";
            OracleDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new OracleDataAdapter(query, oracleConnection);
            Adaptador.Fill(dataSet, "tbl");

            return dataSet;

        }


        public void EditarEmpleado(CEEmpleado cE)
        {
            OracleConnection oracleConnection = new OracleConnection(cadenaConexion);
            oracleConnection.Open();

            try
            {
                
                string query = @"SET
                        a = b
                    WHERE
                            idempleado = " + cE.idempleado + " AND em_rut = " + cE.em_rut + "AND em_dv = '" + cE.em_dv + "' AND em_nombre = '" + cE.em_nombre + "'AND em_apaterno = :v4 '" + cE.em_apaterno + "' AND em_amaterno = '" + cE.emp_amaterno + "' AND em_email = '" + cE.em_mail + "' AND EM_CONTRASEÑA = '" + cE.em_contrasena + "' AND idempresa = " + cE.idEmpresa + " AND id_tipoempleado = " + cE.idTipoEmleado + "AND idestado = " + cE.idEstado + "AND id_direccion = " + cE.idDireccion + ";)";



                OracleCommand oracleCommand = new OracleCommand(query, oracleConnection);
                //OracleCommand command = new OracleCommand(query, oracleConnection);
                oracleCommand.ExecuteNonQuery();
                oracleConnection.Close();
                MessageBox.Show("Registro Actualizado");
            }
            catch (Exception ex)
            {
                oracleConnection.Close();
                MessageBox.Show("No conectado");

            }

        }

        public void EliminarEmpleado(CEEmpleado cE) 
        {
            OracleConnection oracleConnection = new OracleConnection(cadenaConexion);
            oracleConnection.Open();

            try
            {

                string query = @"delete from empleado WHERE em_rut = " + cE.em_rut +";)";



                OracleCommand oracleCommand = new OracleCommand(query, oracleConnection);
                //OracleCommand command = new OracleCommand(query, oracleConnection);
                oracleCommand.ExecuteNonQuery();
                oracleConnection.Close();
                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception ex)
            {
                oracleConnection.Close();
                MessageBox.Show("No Eliminado");

            }

        }
    }
}
