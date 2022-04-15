using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;
using CapaEntidad;
using System.Data;
using System.Configuration;


namespace CapaDatos
{
    public class CDEmpleado
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


        public void AgregarEmpleado(CEEmpleado cE)
        {
            OracleConnection conn = new OracleConnection(conexion);
            

            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand("agregarEmpleado", conn);
                
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("rutEmp", OracleType.Number).Value = Convert.ToInt32(cE.em_rut);      
                command.Parameters.Add("dvEmp", OracleType.Char).Value = cE.em_dv;
                command.Parameters.Add("nomEmp", OracleType.NVarChar).Value = cE.em_nombre;
                command.Parameters.Add("aPaternoEmp", OracleType.NVarChar).Value = cE.em_apaterno;
                command.Parameters.Add("aMaternoEmp", OracleType.NVarChar).Value = cE.emp_amaterno;
                command.Parameters.Add("emailEmp", OracleType.NVarChar).Value = cE.em_mail;
                command.Parameters.Add("contraseniaEmp", OracleType.NVarChar).Value = cE.em_contrasena;
                command.Parameters.Add("idEmpresaEmp", OracleType.Number).Value = Convert.ToInt32(cE.idEmpresa);
                command.Parameters.Add("idTipoEmp", OracleType.Number).Value = Convert.ToInt32(cE.idTipoEmleado);
                command.Parameters.Add("idEstadoEmp", OracleType.Number).Value = Convert.ToInt32(cE.idEstado);
                command.Parameters.Add("idDireccionEmp", OracleType.Number).Value = Convert.ToInt32(cE.idDireccion);
                command.ExecuteNonQuery();
                #region procedimiento almacenado
                /*
                create or replace procedure agregarEmpleado(rutEmp in number, dvEmp in char, nomEmp in nvarchar2, aPaternoEmp in nvarchar2, aMaternoEmp in nvarchar2, emailEmp in nvarchar2, 
                contraseniaEmp in nvarchar2,
                idEmpresaEmp in number, idTipoEmp in number, idEstadoEmp in number, idDireccionEmp in number)
                as
                  Begin
                    insert into empleado (em_rut,em_dv,em_nombre,em_apaterno,em_amaterno,em_email,em_contraseña,idempresa,id_tipoempleado,idestado,id_direccion) 
                    values(rutEmp,dvEmp,nomEmp,aPaternoEmp,aMaternoEmp,emailEmp,contraseniaEmp,idEmpresaEmp,idTipoEmp,idEstadoEmp,idDireccionEmp);
                end;
                */
                #endregion
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("No conectado" + ex.Message);

            }
            conn.Close();
            MessageBox.Show("Empleado Agregado");
        }

        public DataTable Listar()
        {
            OracleConnection conn = new OracleConnection(conexion);
            OracleDataReader mostrarTabla;
            DataTable tablaEmpleado = new DataTable();

            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand("seleccionarEmpleados", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                mostrarTabla = command.ExecuteReader();
                mostrarTabla.Read();
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = command;
                adaptador.Fill(tablaEmpleado);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("No conectado" + ex.Message);
            }
            
            conn.Close();
            return tablaEmpleado;
        }


        public void EditarEmpleado(CEEmpleado cE)
        {
            OracleConnection conn = new OracleConnection(conexion);

            try
            {
                conn.Open();
                OracleCommand command = new OracleCommand("actualizarEmpleado", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idEmpleado", OracleType.Number).Value = Convert.ToInt32(cE.idempleado);
                command.Parameters.Add("rutEmp", OracleType.Number).Value = Convert.ToInt32(cE.em_rut);
                command.Parameters.Add("dvEmp", OracleType.Char).Value = cE.em_dv;
                command.Parameters.Add("nomEmp", OracleType.NVarChar).Value = cE.em_nombre;
                command.Parameters.Add("aPaternoEmp", OracleType.NVarChar).Value = cE.em_apaterno;
                command.Parameters.Add("aMaternoEmp", OracleType.NVarChar).Value = cE.emp_amaterno;
                command.Parameters.Add("emailEmp", OracleType.NVarChar).Value = cE.em_mail;
                command.Parameters.Add("contraseniaEmp", OracleType.NVarChar).Value = cE.em_contrasena;
                command.Parameters.Add("idEmpresaEmp", OracleType.Number).Value = Convert.ToInt32(cE.idEmpresa);
                command.Parameters.Add("idTipoEmp", OracleType.Number).Value = Convert.ToInt32(cE.idTipoEmleado);
                command.Parameters.Add("idEstadoEmp", OracleType.Number).Value = Convert.ToInt32(cE.idEstado);
                command.Parameters.Add("idDireccionEmp", OracleType.Number).Value = Convert.ToInt32(cE.idDireccion);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("No conectado");

            }
            conn.Close();
            MessageBox.Show("Empleado Actualizado");
            #region procedimiento almacenado
            /*
             create or replace PROCEDURE actualizarEmpleado(idEmpleado in Number, rutEmp in number, dvEmp in char, nomEmp in nvarchar2, aPaternoEmp in nvarchar2, aMaternoEmp in nvarchar2, emailEmp in nvarchar2, 
             contraseniaEmp in nvarchar2,
                idEmpresaEmp in number, idTipoEmp in number, idEstadoEmp in number, idDireccionEmp in number)
                as
                    vid NUMBER := idEmpleado;
                    vrut NUMBER := rutEmp;
                    vdv char := dvEmp;
                    vnom nvarchar2(50) := nomEmp;
                    vaPaterno nvarchar2(50) := aPaternoEmp;
                    vaMaterno nvarchar2(50) := aMaternoEmp;
                    vEmail nvarchar2(50) := emailEmp;
                    vContrasenia nvarchar2(50) := contraseniaEmp;
                    vIdEmpresa NUMBER := idEmpresaEmp;
                    vIdTipo NUMBER := idTipoEmp;
                    vIdEstado NUMBER := idEstadoEmp;
                    vIdDireccion NUMBER := idDireccionEmp;
                begin
                    update empleado set EM_RUT = vrut, EM_DV = vdv, em_nombre = vnom,
                    em_apaterno=vaPaterno, em_amaterno=vaMaterno, em_email=vEmail,
                    EM_CONTRASEÑA=vContrasenia, idempresa=vIdEmpresa, id_tipoempleado=vIdTipo,
                    idestado=vIdEstado, id_direccion=vIdDireccion
                WHERE        idempleado = vid;
                Exception
                    when NO_DATA_FOUND then
                    null;
                    When others then
                    raise;
                END actualizarEmpleado;
             */
            #endregion
        }

        public void EliminarEmpleado(CEEmpleado cE) 
        {
            OracleConnection conn = new OracleConnection(conexion);
            try
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta seguro de eliminar este empleado?", "Eliminar Empleado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("eliminarEmpleado", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("idEmpleado", OracleType.Number).Value = Convert.ToInt32(cE.idempleado);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Empleado Eliminado");
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
            #region procedimiento almacenado
            /* Procedimiento almacenado 
             Create or replace procedure eliminarEmpleado (idEmpleado in NUMBER)
             as
                vid number := idEmpleado;
             begin
                delete from empleado where idempleado = vid;
             END;
             */
            #endregion
        }
    }
}
