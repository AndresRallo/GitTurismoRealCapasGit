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
    public partial class Login : Form
    {
        CNEmpleado cNEmpleado = new CNEmpleado();
        public Login()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text=="" && txtPassword.Text=="")
                {
                    MessageBox.Show("Debe ingresar todas sus credenciales.");
                }
                else
                {
                    CEEmpleado empleado = new CEEmpleado();
                    empleado.em_mail = txtEmail.Text;
                    empleado.em_contrasena = txtPassword.Text;

                    cNEmpleado.ValidarDatosLogin(empleado);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            
        }
    }
}
