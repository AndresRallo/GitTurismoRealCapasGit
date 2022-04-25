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
                usuario.idUsuario = Convert.ToInt32(txtIDUsuario.Text);
                usuario.us_rut = txtRut.Text;
                usuario.us_dv = txtDV.Text;
                usuario.us_nombre = txtNom.Text;
                usuario.us_apaterno = txtAPaterno.Text;
                usuario.us_amaterno = txtAMaterno.Text;
                usuario.us_email = txtEmail.Text;
                usuario.us_contraseña = txtContrasenia.Text;
                usuario.us_telefono = txtTelefono.Text;
                usuario.idEstado = Convert.ToInt32(txtIDEstado.Text);

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
