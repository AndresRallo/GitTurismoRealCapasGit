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
    public partial class Perfil_Empleado : Form
    {
        public Perfil_Empleado()
        {
            InitializeComponent();
            GROUP_BOX();
        }

        CNEmpleado cn_empleado = new CNEmpleado();
        CEEmpleado ce_empleado = new CEEmpleado();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GROUP_BOX()
        {
            GB_EMPLEADO.Visible = false;
            GB_EMPLEADO.Enabled = false;
            GB_CHANGE_PW.Visible = false;
            GB_CHANGE_PW.Enabled = false;
        }

        private void CARGAR_DATOS(string email)
        {
            CEEmpleado empleado = CNEmpleado.getUserByEmail(email);
            if(empleado != null)
            {
                GB_EMPLEADO.Enabled = true;
                GB_EMPLEADO.Visible = true;
                empleado.EM_RUT = lblRUT_.Text;
                empleado.EM_DV = lblDV_.Text;
                empleado.EM_NOMBRE = lblNOM_.Text;
                empleado.EM_APATERNO = lblAPATERNO_.Text;
                empleado.EM_AMATERNO = lblAMATERNO_.Text;
                empleado.EM_EMAIL = lblEMAIl_.Text;
                empleado.IDTIPOEMPLEADO = Convert.ToInt32(lblTIPO_EMPLEADO_.Text);
                empleado.IDESTADO = Convert.ToInt32(lblESTADO_.Text);
            }
            else
            {
                MessageBox.Show("EMAIL NO ENCONTRADO");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GB_CHANGE_PW.Enabled = true;
            GB_CHANGE_PW.Visible = true;
        }
    }
}
