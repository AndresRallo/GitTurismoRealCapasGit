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
            try
            {
                CEUsuario usuario = new CEUsuario();
                usuario.US_RUT = txtRUT.Text;
                usuario.US_DV = txtDV.Text;
                usuario.US_NOMBRE = txtNOMBRE.Text;
                usuario.US_APATERNO = txtAPATERNO.Text;
                usuario.US_AMATERNO = txtAMATERNO.Text;
                usuario.US_EMAIL = txtEMAIL.Text;
                string ePass = Encrypt.GetSHA256(txtPW.Text);

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

        }
    }
}
