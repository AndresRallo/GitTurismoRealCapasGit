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
    public partial class MantenedorUsuario : Form
    {
        CNUsuario usuario = new CNUsuario();
        public MantenedorUsuario()
        {
            InitializeComponent();

            //btnEditar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal("mant user");
            menuPrincipal.Show();
            this.Close();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            usuario.PruebaOracle();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Here migration ok 
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Here migration ok 
            ListarUsuario listarUsuario = new ListarUsuario();
            listarUsuario.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Here migration ok 
            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Here migration ok 
            CambiarEstadoUsuario eliminarUsuario = new CambiarEstadoUsuario();
            eliminarUsuario.Show();
            this.Close();
        }
    }
}
