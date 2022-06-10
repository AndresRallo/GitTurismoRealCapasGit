using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Departamentos
{
    public partial class MantDepartamentos : Form
    {
        public MantDepartamentos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDepartamento agregarDepartamento = new AgregarDepartamento();
            agregarDepartamento.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarDepartamento editarDepartamento = new EditarDepartamento();
            editarDepartamento.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarDepartamentos listarDepartamentos = new ListarDepartamentos();
            listarDepartamentos.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CambiarEstadoDepartamento eliminarDepartamento = new CambiarEstadoDepartamento();
            eliminarDepartamento.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal("");
            menuPrincipal.Show();
            this.Close();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
