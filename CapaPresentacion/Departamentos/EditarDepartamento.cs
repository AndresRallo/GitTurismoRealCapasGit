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
using CapaNegocio.Library;


namespace CapaPresentacion.Departamentos
{
    public partial class EditarDepartamento : Form
    {
        private string _accion = "insert";

        Librarys librarys = new Librarys();
        CNDepartamento cNDepartamento = new CNDepartamento();

        public EditarDepartamento()
        {
            InitializeComponent();
            LoadComboEstadoDepto();
            LoadTipoDepto();
            LoadComboRegion();
            Lista();
            CLEAN_DGV_DEPTO();
        }

        #region combobox
        private void LoadComboEstadoDepto()
        {
            try
            {
                cbxEstadoDepa.DataSource = cNDepartamento.ObtenerEstadoDepto();
                cbxEstadoDepa.ValueMember = "IDEstDepto";
                cbxEstadoDepa.DisplayMember = "EdDescripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado depto" + ex);
            }
        }

        private void LoadTipoDepto()
        {
            try
            {
                cbxTipoDepto.DataSource = cNDepartamento.ObtenerTipoDepto();
                cbxTipoDepto.ValueMember = "IDTIPODEPARTAMENTO";
                cbxTipoDepto.DisplayMember = "TD_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
        }
        private void LoadComboRegion()
        {
            try
            {
                cbxRegion.DataSource = cNDepartamento.ObtenerRegion();
                cbxRegion.ValueMember = "IDREGION";
                cbxRegion.DisplayMember = "RE_DESCRIPCION";

                if (cbxRegion.Items.Count != 0)
                {
                    int idregion = Convert.ToInt32(cbxRegion.SelectedValue);
                    cbxComuna.DataSource = null;
                    cbxComuna.Items.Clear();
                    LoadComboComuna(idregion);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
        }

        private void LoadComboComuna(int idregion)
        {
            try
            {
                cbxComuna.DataSource = cNDepartamento.ObtenerComunas(idregion);
                cbxComuna.ValueMember = "IDCOMUNA";
                cbxComuna.DisplayMember = "C_DESCRIPCION";
                if (cbxRegion.Items.Count != 0)
                {
                    int idcomuna = Convert.ToInt32(cbxComuna.SelectedValue);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
        }
        #endregion

        private void CLEAN_DGV_DEPTO()
        {
            //dgvDepartamentos.Columns["mantencion"].Visible = false;
            //dgvDepartamentos.Columns["adjunto"].Visible = false;
            //dgvDepartamentos.Columns["direccion"].Visible = false;
            //dgvDepartamentos.Columns["carateristicasDepartamento"].Visible = false;
        }
        private void cbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int regionid = cbxRegion.SelectedIndex;

                LoadComboComuna(regionid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                Lista();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Lista()
        {
            CNDepartamento lista = new CNDepartamento();
            dgvDepartamentos.DataSource = lista.ObtenerDatosJoinCaracteristicas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }

        #region validacion textbox
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                lblNombre.Text = "Falta Nombre del Departamento";
                lblNombre.ForeColor = Color.Red;
            }
            if (txtDescDepto.Text == "")
            {
                lblDesDepto.Text = "Falta Descripción Depto";
                lblDesDepto.ForeColor = Color.Red;
            }
            if (txtPrecio.Text == "")
            {
                lblAgrePrecio.Text = "Falta agregar Precio en Pesos";
                lblAgrePrecio.ForeColor = Color.Red;
            }
            if (txtEstrellas.Text == "")
            {
                lblEstrellas.Text = "Falta agregar Estellas";
                lblEstrellas.ForeColor = Color.Red;

            }
            else if (Convert.ToInt32(txtEstrellas.Text) < 1 || Convert.ToInt32(txtEstrellas.Text) > 5)
            {
                lblEstrellas.Text = "Estrellas fuera de rango (1-5)";
                lblEstrellas.ForeColor = Color.Red;
            }
            if (txtDireccion.Text == "")
            {
                lblDireccion.Text = "Falta Dirección";
                lblDireccion.ForeColor = Color.Red;
            }
            if (txtDireccion.Text == "")
            {
                lblNumero.Text = "Falta Número";
                lblNumero.ForeColor = Color.Red;
            }
            if (txtNumDepto.Text == "")
            {
                lblNumDepto.Text = "Falta Núm.Depto";
                lblNumDepto.ForeColor = Color.Red;
            }
            if (txtCantHabitaciones.Text == "")
            {
                lblHabitaciones.Text = "Falta Cant. Habitaciones";
                lblHabitaciones.ForeColor = Color.Red;
            }
            if (txtCanCamas.Text == "")
            {
                lblCantCamas.Text = "Falta Cant. de Camas";
                lblCantCamas.ForeColor = Color.Red;
            }
            if (txtCantBanos.Text == "")
            {
                lblCantBanos.Text = "Falta Cant. de Baños";
                lblCantBanos.ForeColor = Color.Red;
            }
            if (txtCanPersonas.Text == "")
            {
                lblCantPersonas.Text = "Falta Cant. de Personas";
                lblCantPersonas.ForeColor = Color.Red;
            }
            if (txtCheckIn.Text == "")
            {
                lblCheckIn.Text = "Falta Check In";
                lblCheckIn.ForeColor = Color.Red;
            }
            if (txtCheckIn.Text == "")
            {
                lblCheckOut.Text = "Falta Check Out";
                lblCheckOut.ForeColor = Color.Red;
            }

            //---------------Ahora se edita el departamento----------------//
            else
            {
                GuardarEdicionDepartamento();
            }
        }
        #endregion

        private void GuardarEdicionDepartamento()
        {
            try
            {
                CEDepartamento depto = new CEDepartamento();

                depto.idDepto = Convert.ToInt32(txtIdDepto.Text);
                depto.de_nombre = txtNombre.Text;
                depto.descripcionDepto = txtDescDepto.Text;
                depto.precioDepto = Convert.ToInt32(txtPrecio.Text);
                depto.de_start = Convert.ToInt32(txtEstrellas.Text);
                depto.idTipoDepto = Convert.ToInt32(cbxTipoDepto.SelectedValue);
                depto.idEstadoDepto = Convert.ToInt32(cbxEstadoDepa.SelectedValue);

                CEDireccion direccion = new CEDireccion();

                direccion.idDireccion = Convert.ToInt32(txtIdDirc.Text);
                direccion.de_direccion = txtDireccion.Text;
                direccion.de_numero = txtNumero.Text;
                direccion.id_comuna = Convert.ToInt32(cbxComuna.SelectedValue);

                depto.direccion = direccion;

                CECaracteristicas_Departamento carDepto = new CECaracteristicas_Departamento();

                carDepto.IdCaracteristica = Convert.ToInt32(txtIdCaract.Text);
                carDepto.Ca_NumDepto = txtNumDepto.Text;
                carDepto.Ca_CantHabitaciones = Convert.ToInt32(txtCantHabitaciones.Text);
                carDepto.Ca_CantCamas = Convert.ToInt32(txtCanCamas.Text);
                carDepto.Ca_CantBaño = Convert.ToInt32(txtCantBanos.Text);
                carDepto.Ca_CapPersonas = Convert.ToInt32(txtCanPersonas.Text);

                carDepto.Ca_CheckIn = txtCheckIn.Text;
                carDepto.Ca_CheckOut = txtCheckOut.Text;

                depto.carateristicasDepartamento = carDepto;

                if (cNDepartamento.ActualizarDepartamento(depto))
                {
                    Lista();
                    Limpiar();
                    MessageBox.Show("Departamento Editado");
                }
                else
                {
                    MessageBox.Show("Departamento NO Editado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departamento no Editado :(" + ex);
            }
        }

        private void Limpiar()
        {
            txtIdDepto.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescDepto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtEstrellas.Text = string.Empty;

            txtIdDirc.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNumero.Text = string.Empty;

            txtIdCaract.Text = string.Empty;
            txtNumDepto.Text = string.Empty;
            txtCantHabitaciones.Text = string.Empty;
            txtCanCamas.Text = string.Empty;
            txtCantBanos.Text = string.Empty;
            txtCanPersonas.Text = string.Empty;

            txtCheckIn.Text = string.Empty;
            txtCheckOut.Text = string.Empty;
        }


        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDepartamentos.Rows.Count != 0)
            {
                GetDepartamento();
            }

        }

        private void dgvDepartamentos_KeyUp(object sender, KeyEventArgs e)
        {
            GetDepartamento();
        }

        private int _IdCaracteristica = 0;

        public void GetDepartamento()
        {
            _accion = "update";
            _IdCaracteristica = Convert.ToInt32(dgvDepartamentos.CurrentRow.Cells[0].Value);
            txtIdCaract.Text = Convert.ToString(dgvDepartamentos.CurrentRow.Cells[0].Value);
        }
    }
}
