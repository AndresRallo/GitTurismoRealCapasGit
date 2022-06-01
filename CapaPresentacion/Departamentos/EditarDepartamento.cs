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
        Librarys librarys = new Librarys();
        CNDepartamento cNDepartamento = new CNDepartamento();

        public EditarDepartamento()
        {
            InitializeComponent();
            LoadComboEstadoDepto();
            LoadTipoDepto();
            LoadComboRegion();
            Lista();
        }


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
                /*  else
                  {
                      cbComuna.DataSource = null;

                  } */
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
            dgvDepartamentos.DataSource = lista.ObtenerCaracteristicas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
                carDepto.Ca_NumDepto = Convert.ToInt32(txtNumDepto.Text);
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
                    MessageBox.Show("Departamento NO Agregado");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Departamento no agregado :(" + ex);
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
        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
