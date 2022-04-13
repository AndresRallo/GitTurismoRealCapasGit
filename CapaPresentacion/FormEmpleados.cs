using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormEmpleados : Form
    {
        CNEmpleado cNEmpleado = new CNEmpleado();
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        public void Limpiar()
        {

            txtRut.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApPa.Text = string.Empty;
            txtApMa.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPass.Text = string.Empty;
            //txtEmpresa.Text = string.Empty;
            //txtTiEmpleado.Text = string.Empty;
            //txtEstado.Text = string.Empty;
            //txtDireccion.Text = string.Empty;
        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            bool resultado;
            CEEmpleado cEEmpleado = new CEEmpleado();

            cEEmpleado.em_rut = txtRut.Text;
            cEEmpleado.em_dv = txtEm_dv.Text;
            cEEmpleado.em_nombre = txtNombre.Text;
            cEEmpleado.em_apaterno = txtApPa.Text;
            cEEmpleado.emp_amaterno = txtApMa.Text;
            cEEmpleado.em_mail = txtEmail.Text;
            cEEmpleado.em_contrasena = txtPass.Text;
            cEEmpleado.idEmpresa = Int32.Parse(txtEmpresa.Text);
            cEEmpleado.idTipoEmleado = Int32.Parse(txtTiEmpleado.Text);
            cEEmpleado.idEstado = Int32.Parse(txtEstado.Text);
            cEEmpleado.idDireccion = Int32.Parse(txtDireccion.Text);

            resultado = cNEmpleado.ValidarDatos(cEEmpleado);

            if (resultado == false)
            {
                return;
            }

            if (cEEmpleado.idempleado == 0)
            {
                cNEmpleado.CrearEmpleado(cEEmpleado);
            }
            else
            {
                cNEmpleado.EditarEmpleado(cEEmpleado);
            }

            

            CargarDatos();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
            Limpiar();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAplicacion_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }






        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAplicacion_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Limpiar();
        }

        private void CargarDatos()
        {
            gridDatos.DataSource = cNEmpleado.ObtenerDatos().Tables["tbl"];
        }

        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRut.Text = gridDatos.CurrentRow.Cells["EM_RUT"].Value.ToString();
            txtEm_dv.Text = gridDatos.CurrentRow.Cells["EM_DV"].Value.ToString();
            txtNombre.Text = gridDatos.CurrentRow.Cells["EM_NOMBRE"].Value.ToString();
            txtApPa.Text = gridDatos.CurrentRow.Cells["EM_APATERNO"].Value.ToString();
            txtApMa.Text = gridDatos.CurrentRow.Cells["EM_AMATERNO"].Value.ToString();
            txtEmail.Text = gridDatos.CurrentRow.Cells["EM_EMAIL"].Value.ToString();
            txtPass.Text = gridDatos.CurrentRow.Cells["EM_CONTRASEÑA"].Value.ToString();
            //txtEmpresa.Text = Int32.Parse(gridDatos).CurrentRow.Cells["EM_RUT"].Value;
            //txtTiEmpleado.Text = (int)gridDatos.CurrentRow.Cells["EM_RUT"].Value;
            //Int32.Parse(txtEstado.Text) = gridDatos.CurrentRow.Cells["EM_RUT"].Value.ToString();
            //Int32.Parse(txtDireccion.Text) = gridDatos.CurrentRow.Cells["EM_RUT"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text == string.Empty) return;

            if (MessageBox.Show("¿deseas eliminar el registro?", "Titulo",MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CEEmpleado cE = new CEEmpleado();
                cE.em_rut = txtRut.Text;
                cNEmpleado.EliminarEmpleado(cE);
            }
        }
    }
}
