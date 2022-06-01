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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantDepartamentos = new Departamentos.MantDepartamentos();
            mantDepartamentos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorReservas mantenedorReservas = new MantenedorReservas();
            mantenedorReservas.Show();
            this.Close();
        }
    }
}
