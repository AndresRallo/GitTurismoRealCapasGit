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
using System.Data.OracleClient;
using CapaNegocio.Library;

namespace CapaPresentacion.Departamentos
{
    public partial class AgregarDepartamento : Form
    {

        Librarys librarys = new Librarys();
        CNDepartamento cNDepartamento = new CNDepartamento();

        

        public AgregarDepartamento()
        {
            InitializeComponent();
            
            LoadComboEstadoDepto();
            LoadTipoDepto();
            LoadComboRegion();
        }

        private void btnAgreDepto_Click(object sender, EventArgs e)
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
                
            }else if (Convert.ToInt32(txtEstrellas.Text) < 1 || Convert.ToInt32(txtEstrellas.Text) > 5)
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

            //---------------Ahora se guarda el departamento----------------//
            else
            {
                GuardarDepartamento();
            }
        }

        private void GuardarDepartamento()
        {
            try
            {
                CEDepartamento depto = new CEDepartamento();

                depto.de_nombre = txtNombre.Text;
                depto.descripcionDepto = txtDescDepto.Text;
                depto.precioDepto = Convert.ToInt32(txtPrecio.Text);
                depto.de_start = Convert.ToInt32(txtEstrellas.Text);
                depto.idTipoDepto = Convert.ToInt32(cbxTipoDepto.SelectedValue);
                depto.idEstadoDepto = Convert.ToInt32(cbxEstadoDepa.SelectedValue);

                CEDireccion direccion = new CEDireccion();

                direccion.de_direccion = txtDireccion.Text;
                direccion.de_numero = txtNumero.Text;
                direccion.id_comuna = Convert.ToInt32(cbxComuna.SelectedValue);

                depto.direccion = direccion;

                CECaracteristicas_Departamento carDepto = new CECaracteristicas_Departamento();

                carDepto.Ca_NumDepto = txtNumDepto.Text;
                carDepto.Ca_CantHabitaciones = Convert.ToInt32(txtCantHabitaciones.Text);
                carDepto.Ca_CantCamas = Convert.ToInt32(txtCanCamas.Text);
                carDepto.Ca_CantBaño = Convert.ToInt32(txtCantBanos.Text);
                carDepto.Ca_CapPersonas = Convert.ToInt32(txtCanPersonas.Text);

                carDepto.Ca_CheckIn = txtCheckIn.Text;
                carDepto.Ca_CheckOut = txtCheckOut.Text;

                depto.carateristicasDepartamento = carDepto;

                if (cNDepartamento.CrearDepartamento(depto))
                {
                    Limpiar();
                    Departamentos.ListarDepartamentos listarDepartamentos = new ListarDepartamentos();
                    listarDepartamentos.Show();
                    this.Close();
                    MessageBox.Show("Departamento Agregado");
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

        private void cbxTipoDepto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }


        //---------------combos region y comunas
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

        

        private void Limpiar()
        {
            
            txtNombre.Text = string.Empty;
            txtDescDepto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtEstrellas.Text = string.Empty;

            
            txtDireccion.Text = string.Empty;
            txtNumero.Text = string.Empty;

            
            txtNumDepto.Text = string.Empty;
            txtCantHabitaciones.Text = string.Empty;
            txtCanCamas.Text = string.Empty;
            txtCantBanos.Text = string.Empty;
            txtCanPersonas.Text = string.Empty;

            txtCheckIn.Text = string.Empty;
            txtCheckOut.Text = string.Empty;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                lblNombre.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblNombre.ForeColor = Color.ForestGreen;
                lblNombre.Text = "Nombre del Departamento";
            }
        }

        private void txtDescDepto_TextChanged(object sender, EventArgs e)
        {
            if (txtDescDepto.Text.Equals(""))
            {
                lblDesDepto.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblDesDepto.ForeColor = Color.ForestGreen;
                lblDesDepto.Text = "Descripción del Departamento";
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Equals(""))
            {
                lblAgrePrecio.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblAgrePrecio.ForeColor = Color.ForestGreen;
                lblAgrePrecio.Text = "Agregar Precio en Pesos";
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtEstrellas_TextChanged(object sender, EventArgs e)
        {
            if (txtEstrellas.Text.Equals(""))
            {
                lblEstrellas.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblEstrellas.ForeColor = Color.ForestGreen;
                lblEstrellas.Text = "Número de Estrellas";
            }
        }

        private void txtEstrellas_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Equals(""))
            {
                lblDireccion.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblDireccion.ForeColor = Color.ForestGreen;
                lblDireccion.Text = "Dirección";
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text.Equals(""))
            {
                lblNumero.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblNumero.ForeColor = Color.ForestGreen;
                lblNumero.Text = "Número";
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtNumDepto_TextChanged(object sender, EventArgs e)
        {
            if (txtNumDepto.Text.Equals(""))
            {
                lblNumDepto.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblNumDepto.ForeColor = Color.ForestGreen;
                lblNumDepto.Text = "Número Departamento";
            }
        }

        private void txtNumDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtCantHabitaciones_TextChanged(object sender, EventArgs e)
        {
            if (txtCantHabitaciones.Text.Equals(""))
            {
                lblHabitaciones.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblHabitaciones.ForeColor = Color.ForestGreen;
                lblHabitaciones.Text = "Cantidad de Habitaciones";
            }
        }

        private void txtCantHabitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtCanCamas_TextChanged(object sender, EventArgs e)
        {
            if (txtCanCamas.Text.Equals(""))
            {
                lblCantCamas.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblCantCamas.ForeColor = Color.ForestGreen;
                lblCantCamas.Text = "Cantidad de Camas";
            }
        }

        private void txtCanCamas_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }
        private void txtCantBanos_TextChanged(object sender, EventArgs e)
        {
            if (txtCantBanos.Text.Equals(""))
            {
                lblCantBanos.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblCantBanos.ForeColor = Color.ForestGreen;
                lblCantBanos.Text = "Cantidad de Baños";
            }
        }
        private void txtCantBanos_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtCanPersonas_TextChanged(object sender, EventArgs e)
        {
            if (txtCanPersonas.Text.Equals(""))
            {
                lblCantPersonas.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblCantPersonas.ForeColor = Color.ForestGreen;
                lblCantPersonas.Text = "Cantidad de Personas";
            }
        }
        private void txtCanPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtCheckIn_TextChanged(object sender, EventArgs e)
        {
            if (txtCheckIn.Text.Equals(""))
            {
                lblCheckIn.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblCheckIn.ForeColor = Color.ForestGreen;
                lblCheckIn.Text = "Check In";
            }
        }

        private void txtCheckIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspaciosConPuntos(e);
        }

        private void txtCheckOut_TextChanged(object sender, EventArgs e)
        {
            if (txtCheckOut.Text.Equals(""))
            {
                lblCheckOut.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblCheckOut.ForeColor = Color.ForestGreen;
                lblCheckOut.Text = "Check Out";
            }
        }

        private void txtCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspaciosConPuntos(e);
        }
    }
}
