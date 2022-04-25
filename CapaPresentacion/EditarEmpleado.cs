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
                dataGridViewEmpleados.DataSource = lista.ObtenerDatos();


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
                empleado.idempleado = Convert.ToInt32(txtIDEmpleado.Text);
                empleado.em_rut = txtRut.Text;
                empleado.em_dv = txtDV.Text;
                empleado.em_nombre = txtNom.Text;
                empleado.em_apaterno = txtAPaterno.Text;
                empleado.emp_amaterno = txtAMaterno.Text;
                empleado.em_mail = txtEmail.Text;
                empleado.em_contrasena = txtContrasenia.Text;
                empleado.idEmpresa = Convert.ToInt32(txtIDEmpresa.Text);
                empleado.idTipoEmleado = Convert.ToInt32(txtIDTipo.Text);
                empleado.idEstado = Convert.ToInt32(txtIDEstado.Text);
                empleado.idDireccion = Convert.ToInt32(txtIDDireccion.Text);

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
