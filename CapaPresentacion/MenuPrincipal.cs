using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantDepartamentos = new Departamentos.MantDepartamentos();
            mantDepartamentos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorReservas mantenedorReservas = new MantenedorReservas();
            mantenedorReservas.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region List  employee 
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarEmpleados listarEmpleados = new ListarEmpleados();
            listarEmpleados.Show();
            this.Close();
        }
        #endregion

        #region Add new employee 
        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region Edit  employee 
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEmpleado editarEmpleado = new EditarEmpleado();
            editarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region Delete  employee 
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarEstadoEmpleado eliminarEmpleado = new CambiarEstadoEmpleado();
            eliminarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region list User
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            ListarUsuario listarUsuario = new ListarUsuario();
            listarUsuario.Show();
            this.Close();
            
        }
        #endregion

        #region create User
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
            this.Close();
            
        }
        #endregion

        #region edit User
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.Show();
            this.Close();
       
        }
        #endregion

        #region delete User
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            CambiarEstadoUsuario eliminarUsuario = new CambiarEstadoUsuario();
            eliminarUsuario.Show();
            this.Close();
            
        }
        #endregion

        #region list department
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region add department
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region edit department
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region delete department
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region create Service booking
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            CreateServiceBooking mantenedor = new CreateServiceBooking();
            mantenedor.Show();
            this.Close();
        }
        #endregion

        #region list Service booking
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region edit Service booking
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region delete Service booking
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
