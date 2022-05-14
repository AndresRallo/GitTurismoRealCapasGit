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
using CapaNegocio.Library;
using CryptSharp;

namespace CapaPresentacion
{
    public partial class AgregarUsuario : Form
    {
        Librarys librarys = new Librarys();
        CNUsuario cnUsuario = new CNUsuario();

        public string contrasenaEncriptada;
        public AgregarUsuario()
        {
            InitializeComponent();
            LoadComboEstadoEmpleado();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (txtRUT.Text == "")
            {
                lblRut.Text = "Rut Obligatorio";
                lblRut.ForeColor = Color.Red;
            }
            if (txtDV.Text == "")
            {
                lblDV.Text = "Falta el Dígito";
                lblDV.ForeColor = Color.Red;
            }
            if (txtNOMBRE.Text == "")
            {
                lblNombre.Text = "Falta Nombre";
                lblNombre.ForeColor = Color.Red;
            }
            if (txtAPATERNO.Text == "")
            {
                lblAPaterno.Text = "Falta Ap. Paterno";
                lblAPaterno.ForeColor = Color.Red;
            }
            if (txtAMATERNO.Text == "")
            {
                lblAMaterno.Text = "Falta Ap. Materno";
                lblAMaterno.ForeColor = Color.Red;
            }
            if (txtEMAIL.Text == "")
            {
                lblEmail.Text = "Falta Email";
                lblEmail.ForeColor = Color.Red;
            }
            else if (!librarys.textBoxEvent.ComprobarFormatoEmail(txtEMAIL.Text))
            {
                lblEmail.Text = "Email inválido";
                lblEmail.ForeColor = Color.Red;
            }
            if (txtPW.Text == "")
            {
                lblContrasenia.Text = "Falta Contraseña";
                lblContrasenia.ForeColor = Color.Red;
            }
            if (txtTELEFONO.Text == "")
            {
                lblTelefono.Text = "Falta Teléfono";
                lblTelefono.ForeColor = Color.Red;
            }
            else
            {
                GuardarUsuario();
            }
            
            
        }

        private void GuardarUsuario()
        {
            try
            {
                CEUsuario usuario = new CEUsuario();
                usuario.US_RUT = txtRUT.Text;
                usuario.US_DV = txtDV.Text;
                usuario.US_NOMBRE = txtNOMBRE.Text;
                usuario.US_APATERNO = txtAPATERNO.Text;
                usuario.US_AMATERNO = txtAMATERNO.Text;
                usuario.US_EMAIL = txtEMAIL.Text;
                string ePass = Crypter.Blowfish.Crypt(txtPW.Text);

                usuario.US_CONTRASEÑA = ePass;
                usuario.US_TELEFONO = txtTELEFONO.Text;
                usuario.IDESTADO = Convert.ToInt32(cbESTADO.SelectedValue);

                if (cnUsuario.CrearUsuario(usuario))
                    MessageBox.Show("Usuario agregado");
                else
                    MessageBox.Show("Usuario no agregado");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuario No Agregado " + ex);
            }
        }

        private void LoadComboEstadoEmpleado()
        {
            try
            {
                cbESTADO.DataSource = cnUsuario.ObtenerEstado();
                cbESTADO.ValueMember = "IDESTADO";
                cbESTADO.DisplayMember = "ES_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado empleado" + ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cnUsuario.PruebaOracle();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtPW.Text.Equals(""))
            {
                lblContrasenia.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblContrasenia.ForeColor = Color.ForestGreen;
                lblContrasenia.Text = "Contraseña";
            }
        }

        private void txtRUT_TextChanged(object sender, EventArgs e)
        {
            if (txtRUT.Text.Equals(""))
            {
                lblRut.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblRut.ForeColor = Color.ForestGreen;
                lblRut.Text = "RUT";
            }
        }

        private void txtNOMBRE_TextChanged(object sender, EventArgs e)
        {
            if (txtNOMBRE.Text.Equals(""))
            {
                lblNombre.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblNombre.ForeColor = Color.ForestGreen;
                lblNombre.Text = "Nombre";
            }
        }

        private void txtDV_TextChanged(object sender, EventArgs e)
        {
            if (txtDV.Text.Equals(""))
            {
                lblDV.ForeColor = Color.DarkOrange;
                lblDV.Text = "Dígito";
            }
            else
            {
                lblDV.ForeColor = Color.ForestGreen;
                lblDV.Text = "Dígito agregado";
            }
        }

        private void txtAPATERNO_TextChanged(object sender, EventArgs e)
        {
            if (txtAPATERNO.Text.Equals(""))
            {
                lblAPaterno.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblAPaterno.ForeColor = Color.ForestGreen;
                lblAPaterno.Text = "Apellido Paterno";
            }
        }

        private void txtAMATERNO_TextChanged(object sender, EventArgs e)
        {
            if (txtAMATERNO.Text.Equals(""))
            {
                lblAMaterno.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblAMaterno.ForeColor = Color.ForestGreen;
                lblAMaterno.Text = "Apellido Materno";
            }
        }

        private void txtEMAIL_TextChanged(object sender, EventArgs e)
        {
            if (librarys.textBoxEvent.ComprobarFormatoEmail(txtEMAIL.Text))
            {
                lblEmail.Text = "Email válido";
                lblEmail.ForeColor = Color.Green;
            }
            else if (txtEMAIL.Text == "" && !librarys.textBoxEvent.ComprobarFormatoEmail(txtEMAIL.Text))
            {
                lblEmail.Text = "Email";
                lblEmail.ForeColor = Color.DarkOrange;
            }
            else if (!librarys.textBoxEvent.ComprobarFormatoEmail(txtEMAIL.Text))
            {
                lblEmail.Text = "Email no válido";
                lblEmail.ForeColor = Color.Red;
            }
            
        }

        private void txtTELEFONO_TextChanged(object sender, EventArgs e)
        {
            if (txtTELEFONO.Text.Equals(""))
            {
                lblTelefono.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblTelefono.ForeColor = Color.ForestGreen;
                lblTelefono.Text = "Apellido Materno";
            }
        }

        private void cbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacioNiNumeros(e);
        }

        private void txtAPATERNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacioNiNumeros(e);
        }

        private void txtAMATERNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacioNiNumeros(e);
        }

        private void txtEMAIL_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacio(e);
        }

        private void txtPW_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }
    }
}
