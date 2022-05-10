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
    public partial class EditarUsuario : Form
    {
        CNUsuario cNUsuario = new CNUsuario();
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CEUsuario usuario = new CEUsuario();
                usuario.IDUSUARIO = Convert.ToInt32(txtIDUsuario.Text);
                usuario.US_RUT = txtRut.Text;
                usuario.US_DV = txtDV.Text;
                usuario.US_NOMBRE = txtNom.Text;
                usuario.US_APATERNO = txtAPaterno.Text;
                usuario.US_AMATERNO = txtAMaterno.Text;
                usuario.US_EMAIL = txtEmail.Text;
                usuario.US_CONTRASEÑA = txtContrasenia.Text;
                usuario.US_TELEFONO = txtTelefono.Text;
                usuario.IDESTADO = Convert.ToInt32(txtIDEstado.Text);

                cNUsuario.EditarUsuario(usuario);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuadio No Editado"+ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                CNUsuario lista = new CNUsuario();
                dataGridViewEmpleados.DataSource = lista.ObtenerDatos();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNUsuario.PruebaOracle();
        }
    }
}
