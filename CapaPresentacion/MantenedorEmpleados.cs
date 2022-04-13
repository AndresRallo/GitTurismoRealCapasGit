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
    public partial class MantenedorEmpleados : Form
    {
        public MantenedorEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarEmpleados listarEmpleados = new ListarEmpleados();
            listarEmpleados.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado eliminarEmpleado = new EliminarEmpleado();
            eliminarEmpleado.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpleado editarEmpleado = new EditarEmpleado();
            editarEmpleado.Show();
            this.Close();
        }
    }
}
