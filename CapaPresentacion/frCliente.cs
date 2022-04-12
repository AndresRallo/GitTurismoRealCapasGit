using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frCliente : Form
    {
        CNCliente cNCliente = new CNCliente();

        public frCliente()
        {
            InitializeComponent();
        }

        private void frCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CECliente cECliente = new CECliente();
            cECliente.em_rut = txtRut.Text;
            cECliente.em_contrasena = txtPass.Text;

            resultado =  cNCliente.ValidarDatos(cECliente);
            if (resultado == false)
            {
                return;
            }

            cNCliente.CrearCliente(cECliente);

            this.Hide();

            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();

        }

        private void conectaPrueba_Click(object sender, EventArgs e)
        {
            txtRut.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void btnProbarCon_Click(object sender, EventArgs e)
        {
            cNCliente.PruebaOracle();
        }
    }
}
