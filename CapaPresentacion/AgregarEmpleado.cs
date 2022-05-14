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
using CapaNegocio.Library;
using CryptSharp;

namespace CapaPresentacion
{
    public partial class AgregarEmpleado : Form
    {
        Librarys librarys = new Librarys();
        CNEmpleado cNEmpleado = new CNEmpleado();
        
        
        public AgregarEmpleado()
        {
            InitializeComponent();


            LoadComboRegion();
            LoadComboTipoEmpleado();
            LoadComboEstadoEmpleado();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtRut.Text == "")
            {
                lblRut.Text = "Rut Obligatorio";
                lblRut.ForeColor = Color.Red;
            }
            
            if (txtDV.Text == "")
            {
                lblDV.Text = "Falta el Dígito";
                lblDV.ForeColor = Color.Red;
            }
            if (txtNom.Text == "")
            {
                lblNombre.Text = "Falta Nombre";
                lblNombre.ForeColor = Color.Red;
            }
            if (txtAPaterno.Text == "")
            {
                lblAPaterno.Text = "Falta Ap. Paterno";
                lblAPaterno.ForeColor = Color.Red;
            }
            if (txtAMaterno.Text == "")
            {
                lblAMaterno.Text = "Falta Ap. Materno";
                lblAMaterno.ForeColor = Color.Red;
            }
            if (txtEmail.Text == "")
            {
                lblEmail.Text = "Falta Email";
                lblEmail.ForeColor = Color.Red;
            }
            else if (! librarys.textBoxEvent.ComprobarFormatoEmail(txtEmail.Text))
            {
                lblEmail.Text = "Email inválido";
                lblEmail.ForeColor = Color.Red;
            }
            if (txtContrasenia.Text == "")
            {
                lblContrasenia.Text = "Falta Contraseña";
                lblContrasenia.ForeColor = Color.Red;
            }
            if (txtIDEmpresa.Text == "")
            {
                lblIDEmpresa.Text = "Falta ID Empresa";
                lblIDEmpresa.ForeColor = Color.Red;
            }
            if (txtDireccion.Text == "")
            {
                lblDireccion.Text = "Falta Dirección";
                lblDireccion.ForeColor = Color.Red;

            }
            if (txtNumDireccion.Text == "")
            {
                lblNumDireccion.Text = "Falta Número";
                lblNumDireccion.ForeColor = Color.Red;
            }
            
            else
            {
                GuardarEmpleado();
            }

            
            
                
        }

        private void GuardarEmpleado()
        {
            try
            {
                CEEmpleado empleado = new CEEmpleado();
                empleado.EM_RUT = txtRut.Text;
                empleado.EM_DV = txtDV.Text;
                empleado.EM_NOMBRE = txtNom.Text;
                empleado.EM_APATERNO = txtAPaterno.Text;
                empleado.EM_AMATERNO = txtAMaterno.Text;
                empleado.EM_EMAIL = txtEmail.Text;
                string ePass = Crypter.Blowfish.Crypt(txtContrasenia.Text);

                empleado.EM_CONTRASEÑA = ePass;
                empleado.IDEMPRESA = Convert.ToInt32(txtIDEmpresa.Text);
                empleado.IDTIPOEMPLEADO = Convert.ToInt32(cbIDTipo.SelectedValue);
                empleado.IDESTADO = Convert.ToInt32(cbESTADO.SelectedValue);

                CEDireccion direccion = new CEDireccion();
                direccion.de_direccion = txtDireccion.Text;
                direccion.de_numero = txtNumDireccion.Text;
                direccion.id_comuna = Convert.ToInt32(cbComuna.SelectedValue);
                empleado.direccion = direccion;

                if (cbIDTipo.Text == "CHÓFER")
                {

                    CEVehiculo vehiculo = new CEVehiculo();
                    vehiculo.marca_ve = txtMarcaVe.Text;
                    vehiculo.patente_ve = txtPatenteVe.Text;
                    vehiculo.anio_ve = Convert.ToInt32(txtAnioVe.Text);
                    //cNEmpleado.CrearVehiculo(vehiculo);
                    empleado.vehiculo = vehiculo;
                }
                else
                {
                    CEVehiculo vehiculo = new CEVehiculo();
                    vehiculo.marca_ve = string.Empty;
                    vehiculo.patente_ve = string.Empty;
                    vehiculo.anio_ve = 0;
                    //cNEmpleado.CrearVehiculo(vehiculo);
                    empleado.vehiculo = vehiculo;
                }

                if (cNEmpleado.CrearEmpleado(empleado))
                    MessageBox.Show("Empleado agregado");
                else
                    MessageBox.Show("Empleado no agregado");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Agregado " + ex);
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
        }

        private void cbIDTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbIDTipo.Text == "CHÓFER")
            {
                groupBoxVehiculo.Visible = true;
                groupBoxVehiculo.Enabled = true;
            }
            else
            {
                groupBoxVehiculo.Visible = false;
                groupBoxVehiculo.Enabled = false;
                txtMarcaVe.Clear();
                txtPatenteVe.Clear();
                txtAnioVe.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadComboTipoEmpleado()
        {
            try
            {
                cbIDTipo.DataSource = cNEmpleado.ObtenerTipoEmpleado();
                cbIDTipo.ValueMember = "IDTIPOUSUARIO";
                cbIDTipo.DisplayMember = "TP_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo tipo empleado" + ex);
            }
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
        private void LoadComboRegion()
        {
            try
            {
                cbRegion.DataSource = cNEmpleado.ObtenerRegion();
                cbRegion.ValueMember = "IDREGION";
                cbRegion.DisplayMember = "RE_DESCRIPCION";

                if (cbRegion.Items.Count != 0)
                {
                    int idregion = Convert.ToInt32(cbRegion.SelectedValue);
                    cbComuna.DataSource = null;
                    cbComuna.Items.Clear();
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
                cbComuna.DataSource = cNEmpleado.ObtenerComunas(idregion);
                cbComuna.ValueMember = "IDCOMUNA";
                cbComuna.DisplayMember = "C_DESCRIPCION";
                if (cbRegion.Items.Count != 0)
                {
                    int idcomuna = Convert.ToInt32(cbComuna.SelectedValue);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex); 
            }
            
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                cbComuna.DataSource = cNEmpleado.ObtenerComunas();
                cbComuna.ValueMember = "IDCOMUNA";
                cbComuna.DisplayMember = "C_DESCRIPCION";

            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }*/

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                int regionid = cbRegion.SelectedIndex;

                LoadComboComuna(regionid);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }

        }

        private void cbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            if (txtRut.Text.Equals(""))
            {
                lblRut.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblRut.ForeColor = Color.ForestGreen;
                lblRut.Text = "RUT";
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtDV_TextChanged(object sender, EventArgs e)
        {
            if (txtDV.Text.Equals(""))
            {
                lblDV.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblDV.ForeColor = Color.ForestGreen;
                lblDV.Text = "Dígito agregado";
            }
        }

        private void txtDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text.Equals(""))
            {
                lblNombre.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblNombre.ForeColor = Color.ForestGreen;
                lblNombre.Text = "Nombre";
            }
        }

        private void txtAPaterno_TextChanged(object sender, EventArgs e)
        {
            if (txtAPaterno.Text.Equals(""))
            {
                lblAPaterno.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblAPaterno.ForeColor = Color.ForestGreen;
                lblAPaterno.Text = "Apellido Paterno";
            }
        }

        private void txtAMaterno_TextChanged(object sender, EventArgs e)
        {
            if (txtAMaterno.Text.Equals(""))
            {
                lblAMaterno.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblAMaterno.ForeColor = Color.ForestGreen;
                lblAMaterno.Text = "Apellido Materno";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (librarys.textBoxEvent.ComprobarFormatoEmail(txtEmail.Text))
            {
                lblEmail.Text = "Email válido";
                lblEmail.ForeColor = Color.Green;
            }
            else if (txtEmail.Text == "" && !librarys.textBoxEvent.ComprobarFormatoEmail(txtEmail.Text))
            {
                lblEmail.Text = "Email";
                lblEmail.ForeColor = Color.DarkOrange;
            }
            else if (!librarys.textBoxEvent.ComprobarFormatoEmail(txtEmail.Text))
            {
                lblEmail.Text = "Email no válido";
                lblEmail.ForeColor = Color.Red;
            }      
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasenia.Text.Equals(""))
            {
                lblContrasenia.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblContrasenia.ForeColor = Color.ForestGreen;
                lblContrasenia.Text = "Contraseña";
            }
        }

        private void txtIDEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (txtIDEmpresa.Text.Equals(""))
            {
                lblIDEmpresa.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblIDEmpresa.ForeColor = Color.ForestGreen;
                lblIDEmpresa.Text = "Id Empresa";
            }
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

        private void txtNumDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNumDireccion.Text.Equals(""))
            {
                lblNumDireccion.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblNumDireccion.ForeColor = Color.ForestGreen;
                lblNumDireccion.Text = "Número";
            }
        }

        private void cbRegion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbComuna_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbIDTipo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPatenteVe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMarcaVe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAnioVe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacioNiNumeros(e);
        }

        private void txtAPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacioNiNumeros(e);
        }

        private void txtAMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacioNiNumeros(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacio(e);
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //librarys.textBoxEvent.SoloTextoSinSaltoNiEspacio(e);
        }

        private void txtIDEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNumDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }
    }
}
