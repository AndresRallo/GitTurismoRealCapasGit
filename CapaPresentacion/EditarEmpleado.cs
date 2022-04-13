using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class EditarEmpleado : Form
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = localhost:1521 / XEPDB1 ; PASSWORD=123456; USER ID = TURISMOADMIN;");
        public EditarEmpleado()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Conectado");
            conn.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand command = new OracleCommand("seleccionarEmpleados", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = command;
            DataTable tablaEmpleado = new DataTable();
            adaptador.Fill(tablaEmpleado);
            dataGridViewEmpleados.DataSource = tablaEmpleado;

            conn.Close();

            /**Procedimiento almacenado
               Create or replace procedure seleccionarEmpleados (registros out SYS_REFCURSOR)
                    as
               Begin
                    open registros for select * from empleado;
               End;
            **/
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand command = new OracleCommand("actualizarEmpleado", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("idEmpleado",OracleType.Number).Value =Convert.ToInt32(txtIDEmpleado.Text);
            command.Parameters.Add("rutEmp",OracleType.Number).Value = Convert.ToInt32(txtRut.Text);
            command.Parameters.Add("dvEmp",OracleType.Char).Value = txtDV.Text;
            command.Parameters.Add("nomEmp",OracleType.NVarChar).Value = txtNom.Text;
            command.Parameters.Add("aPaternoEmp",OracleType.NVarChar).Value = txtAPaterno.Text;
            command.Parameters.Add("aMaternoEmp",OracleType.NVarChar).Value = txtAMaterno.Text;
            command.Parameters.Add("emailEmp",OracleType.NVarChar).Value = txtEmail.Text;
            command.Parameters.Add("contraseniaEmp",OracleType.NVarChar).Value = txtContrasenia.Text;
            command.Parameters.Add("idEmpresaEmp", OracleType.Number).Value = Convert.ToInt32(txtIDEmpresa.Text);
            command.Parameters.Add("idTipoEmp", OracleType.Number).Value = Convert.ToInt32(txtIDTipo.Text);
            command.Parameters.Add("idEstadoEmp", OracleType.Number).Value = Convert.ToInt32(txtIDEstado.Text);
            command.Parameters.Add("idDireccionEmp", OracleType.Number).Value = Convert.ToInt32(txtIDDireccion.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Empleado Actualizado");
            conn.Close();
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
        }
    }
}
