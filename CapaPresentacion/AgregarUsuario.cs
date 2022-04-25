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
    public partial class AgregarUsuario : Form
    {
        CNUsuario cnUsuario = new CNUsuario();
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                CEUsuario usuario = new CEUsuario();
                usuario.us_rut = txtRut.Text;
                usuario.us_dv = txtDV.Text;
                usuario.us_nombre = txtNom.Text;
                usuario.us_apaterno = txtAPaterno.Text;
                usuario.us_amaterno = txtAMaterno.Text;
                usuario.us_email = txtEmail.Text;
                usuario.us_contraseña = txtContrasenia.Text;
                usuario.us_telefono = txtTelefono.Text;
                usuario.idEstado = Convert.ToInt32(txtIDEstado.Text);

                cnUsuario.CrearUsuario(usuario);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuario No Agregado " + ex);
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
    }
}
