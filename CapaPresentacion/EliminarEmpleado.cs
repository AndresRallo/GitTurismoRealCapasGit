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
   
    public partial class EliminarEmpleado : Form
    {
        CNEmpleado cNEmpleado = new CNEmpleado();
        CEEmpleado cEEmpleado = new CEEmpleado();
        string conexion = ConfigurationManager.AppSettings["conn"];
        
        public EliminarEmpleado()
        {
            InitializeComponent();
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

                cNEmpleado.EliminarEmpleado(empleado);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Eliminado " + ex);
            }
            /*
            
            */
            
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
    }
}
