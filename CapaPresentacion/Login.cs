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

            //try
            //{
            //    if(txtEmail.Text=="" && txtPassword.Text=="")
            //    {
            //        MessageBox.Show("Debe ingresar todas sus credenciales.");
            //    }
            //    else
            //    {
            //        CEEmpleado empleado = new CEEmpleado();
            //        empleado.em_mail = txtEmail.Text;
            //        empleado.em_contrasena = txtPassword.Text;

            //        cNEmpleado.ValidarDatosLogin(empleado);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("error " + ex);
            //}


            Logeo();

            
        }

        CEEmpleado objEuser = new CEEmpleado();
        CNLogin objNuser = new CNLogin();
        MenuPrincipal fmr1 = new MenuPrincipal();

        public static string usuario_nombre;
        public static string area;

        void Logeo()
        {

            DataTable dt = new DataTable();
            objEuser.em_mail = txtMail.Text;
            objEuser.em_contrasena = txtPass.Text;

            dt = objNuser.N_user(objEuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();

                fmr1.ShowDialog();

                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)

                    Application.Run(new MenuPrincipal());
                txtMail.Clear();
                txtPass.Clear();

            }
            else
            {
                MessageBox.Show("Mail o pass de usuario Incorrrecta ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            
        }
    }
}
