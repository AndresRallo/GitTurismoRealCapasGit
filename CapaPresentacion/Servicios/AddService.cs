using CapaEntidad;
using CapaNegocio;
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
    public partial class CreateServiceBooking : Form
    {
        
        public CreateServiceBooking()
        {
            InitializeComponent();
            LoadComboService();
            LoadComboComuna();
        }

        private void LoadComboService()
        {
            try
            {
                CNService ListALLService = new CNService();
                List<CETipoServicio> services = ListALLService.ListALLtipeService();

                comboBoxTipoServicio.DataSource = services;
                comboBoxTipoServicio.ValueMember = "idtiposervicio";
                comboBoxTipoServicio.DisplayMember = "ts_descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo servicio" + ex);
            }
        }

        private void LoadComboComuna()
        {
            try
            {
                CNComuna ListALLComuna = new CNComuna();
                List<CEComuna> services = ListALLComuna.ListALLcomuna();

                comboBoxComuna.DataSource = services;
                comboBoxComuna.ValueMember = "idcomuna";
                comboBoxComuna.DisplayMember = "c_descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo servicio" + ex);
            }
        }
        private void MantenedorServicioReserva_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
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
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region Edit  employee 
        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditarEmpleado editarEmpleado = new EditarEmpleado();
            editarEmpleado.Show();
            this.Close();
        }
        #endregion

        #region Delete  employee 
        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        ///
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

        #region add service
        private void button1_Click(object sender, EventArgs e)
        {
            CEService service = new CEService();
             
            service.NameService = (txtNombreServicio.Text != "") ? txtNombreServicio.Text : null;
            service.Precio = (txtPrecio.Text != "") ? int.Parse(txtPrecio.Text) : 0;
            service.Iva = (txtIVA.Text != "") ? int.Parse(txtIVA.Text) : 0;
            service.ValorTotal = (txtTotal.Text != "") ? int.Parse(txtTotal.Text) : 0;
            service.DireccionSucursal = (textDireccionSucursal.Text != "") ? textDireccionSucursal.Text : null;
            service.Estado = ((int)Estados.Activo);
            service.TipoServicio = (comboBoxTipoServicio.SelectedValue.ToString() != "") ? int.Parse(comboBoxTipoServicio.SelectedValue.ToString()) : 0;
            service.NumeroDireccion = (txtNumDireccion.Text != "") ? int.Parse(txtNumDireccion.Text) : 0;
            service.IdComuna = (comboBoxComuna.SelectedValue.ToString() != "") ? int.Parse(comboBoxComuna.SelectedValue.ToString()) : 0;
            service.Descripcion = (txtDescripcion.Text != "") ? txtDescripcion.Text : "";

            CNService cNService = new CNService();
            if (cNService.CreateService(service))

                MessageBox.Show("Servicio agregado");
            else
                MessageBox.Show("Servicio no agregado");

        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
