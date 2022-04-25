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
using CapaNegocio.Library;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        Librarys librarys = new Librarys();
        CNEmpleado cNEmpleado = new CNEmpleado();
        public Login()
        {
            InitializeComponent();
        }

        CEEmpleado objEuser = new CEEmpleado();
        CNLogin objNuser = new CNLogin();
        CNLogin objNMail = new CNLogin();
        MenuPrincipal menuPrincipal = new MenuPrincipal();

        public static string usuario_nombre;
        public static string area;

        void MailCorrecto()
        {
            DataTable dlmail = new DataTable();
            objEuser.em_mail = txtMail.Text;

            dlmail = objNMail.N_user_mail(objEuser);

            if (dlmail.Rows.Count > 0)
            {
                lblEmail.Text = "Imail de T.R.";
            }
            else if (librarys.textBoxEvent.ComprobarFormatoEmail(txtMail.Text))
            {
                lblEmail.Text = "Imail desconocido";
                lblPass.Text = "Pass sin confirmar";
            }
        }

        void Logeo()
        {

            DataTable dt = new DataTable();
            objEuser.em_mail = txtMail.Text;
            objEuser.em_contrasena = txtPass.Text;

            dt = objNuser.N_user(objEuser);

            if (dt.Rows.Count > 0)
            {

                this.Hide();
                menuPrincipal.Show();
                txtMail.Clear();
                txtPass.Clear();
            }
            else
            {

                if (librarys.textBoxEvent.ComprobarFormatoEmail(txtMail.Text) && txtPass.Text != "")
                {
                    lblPass.Text = "No se puede confirmar";
                    MailCorrecto();
                }
                //colocar mensajes de error por Mail existente  o sin nada
                if (librarys.textBoxEvent.ComprobarFormatoEmail(txtMail.Text))
                {

                    MailCorrecto();
                }

                if (txtPass.Text.Equals(""))
                {
                    lblPass.Text = "Insertar Contraseña";
                }
                else
                {
                    lblPass.Text = "Contraseña incorrecta";
                }

            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtMail.Text.Equals(""))
            {
                lblEmail.Text = "Email es Obligatorio";
                lblEmail.TextAlign = ContentAlignment.TopCenter;
            }
            else if (librarys.textBoxEvent.ComprobarFormatoEmail(txtMail.Text))
            {

                Logeo();
            }
            else
            {
                lblEmail.Text = "Formato Imail inválido";
            }
        }



       

        private void btnNext_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text.Equals(""))
            {
                lblEmail.ForeColor = Color.Gray;
            }
            else
            {
                lblEmail.ForeColor = Color.ForestGreen;
                lblEmail.Text = "Email";
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                lblPass.ForeColor = Color.Gray;

            }
            else
            {
                lblPass.ForeColor = Color.ForestGreen;
                lblPass.Text = "Contraseña";
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloNumerosSinEspacios(e);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            librarys.textBoxEvent.SoloTextoSinSaltoNiEspacio(e);
        }
    }
}
