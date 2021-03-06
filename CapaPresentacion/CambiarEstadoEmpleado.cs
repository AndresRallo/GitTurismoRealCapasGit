using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
   
    public partial class CambiarEstadoEmpleado : Form
    {
        CNEmpleado cNEmpleado = new CNEmpleado();
        
        string conexion = ConfigurationManager.AppSettings["conn"];
        
        public CambiarEstadoEmpleado()
        {
            InitializeComponent();

            LoadComboEstadoEmpleado();

            CNEmpleado lista = new CNEmpleado();
            dataGridViewEmpleados.DataSource = lista.ObtenerEmpleados();
            cleanDGVEmpleados();
        }

        private void cleanDGVEmpleados()
        {
            //dataGridViewEmpleados.Columns["direccion"].Visible = false;
            //dataGridViewEmpleados.Columns["vehiculo"].Visible = false;
            //dataGridViewEmpleados.Columns["region"].Visible = false;
            //dataGridViewEmpleados.Columns["comuna"].Visible = false;
            //dataGridViewEmpleados.Columns["tipoempleado"].Visible = false;
            //dataGridViewEmpleados.Columns["estado"].Visible = false;
        }
        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                CNEmpleado lista = new CNEmpleado();
                dataGridViewEmpleados.DataSource = lista.ObtenerEmpleados();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            } 
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                CEEmpleado empleado = new CEEmpleado();
                empleado.IDEMPLEADO = Convert.ToInt32(txtIDEmpleado.Text);
                empleado.IDESTADO = Convert.ToInt32(cbESTADO.SelectedValue);

                if (cNEmpleado.CAMBIAR_ESTADO_EMPLEADO(empleado))
                    MessageBox.Show("CAMBIO DE ESTADO EXITOSO");
                else
                    MessageBox.Show("CAMBIO DE ESTADO NO EXITOSO");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Eliminado " + ex);
            }
            /*
            
            */
            
        }

        private void LoadComboEstadoEmpleado()
        {
            try
            {
                cbESTADO.DataSource = cNEmpleado.ObtenerEstado();
                cbESTADO.ValueMember = "IDESTADO";
                cbESTADO.DisplayMember = "ES_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado empleado" + ex);
            }
        }

        private void cargarDATOS()
        {
            txtIDEmpleado.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["iDEMPLEADODataGridViewTextBoxColumn"].Value);
            cbESTADO.SelectedValue = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["iDESTADODataGridViewTextBoxColumn"].Value);
            cbESTADO.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["eSDESCRIPCIONDataGridViewTextBoxColumn"].Value);
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIngresarID_Click(object sender, EventArgs e)
        {

        }

        private void lblEliminarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleados.Rows.Count != 0)
            {
                cargarDATOS();
            }
        }

        private void dataGridViewEmpleados_KeyUp(object sender, KeyEventArgs e)
        {
            cargarDATOS();
        }
    }
}
