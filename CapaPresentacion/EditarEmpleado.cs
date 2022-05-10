using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class EditarEmpleado : Form
    {
        CNEmpleado cNEmpleado = new CNEmpleado();
        
        
        
        public EditarEmpleado()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                CNEmpleado lista = new CNEmpleado();
                dataGridViewEmpleados.DataSource = lista.ObtenerEmpleados();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }

            /**Procedimiento almacenado
               Create or replace procedure seleccionarEmpleados (registros out SYS_REFCURSOR)
                    as
               Begin
                    open registros for select * from empleado;
               End;
            **/
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CEEmpleado empleado = new CEEmpleado();
                empleado.IDEMPLEADO = Convert.ToInt32(txtIDEmpleado.Text);
                empleado.EM_RUT = txtRut.Text;
                empleado.EM_DV = txtDV.Text;
                empleado.EM_NOMBRE = txtNom.Text;
                empleado.EM_APATERNO = txtAPaterno.Text;
                empleado.EM_AMATERNO = txtAMaterno.Text;
                empleado.EM_EMAIL = txtEmail.Text;
                empleado.EM_CONTRASEÑA = txtContrasenia.Text;
                empleado.IDEMPRESA = Convert.ToInt32(txtIDEmpresa.Text);
                empleado.IDTIPOEMPLEADO = Convert.ToInt32(txtIDTipo.Text);
                empleado.IDESTADO = Convert.ToInt32(txtIDEstado.Text);
                empleado.IDDIRECCION = Convert.ToInt32(txtIDDireccion.Text);

                cNEmpleado.EditarEmpleado(empleado);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Editato" + ex);
            }
            
            
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
