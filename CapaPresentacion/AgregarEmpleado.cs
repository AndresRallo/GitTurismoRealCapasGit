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
    public partial class AgregarEmpleado : Form
    {
        CNEmpleado cNEmpleado = new CNEmpleado();
        
        
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados mantenedorEmpleados = new MantenedorEmpleados();
            mantenedorEmpleados.Show();
            this.Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            try
            {
                CEEmpleado empleado = new CEEmpleado();
                empleado.em_rut = txtRut.Text;
                empleado.em_dv = txtDV.Text;
                empleado.em_nombre = txtNom.Text;
                empleado.em_apaterno = txtAPaterno.Text;
                empleado.emp_amaterno = txtAMaterno.Text;
                empleado.em_mail = txtEmail.Text;
                empleado.em_contrasena = txtContrasenia.Text;
                empleado.idEmpresa = Convert.ToInt32(txtIDEmpresa.Text);
                empleado.idTipoEmleado = cbIDTipo.SelectedIndex;
                empleado.idEstado = Convert.ToInt32(txtIDEstado.Text);
                empleado.idDireccion = Convert.ToInt32(txtDireccion.Text);
                if (empleado.idTipoEmleado == 3)
                {
                    CEVehiculo vehiculo = new CEVehiculo();
                    vehiculo.marca_ve = txtMarcaVe.Text;
                    vehiculo.patente_ve = txtPatenteVe.Text;
                    vehiculo.anio_ve = Convert.ToInt32(txtAnioVe.Text);
                }
                
                cNEmpleado.CrearEmpleado(empleado);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Agregado "+ ex);
            }
                
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
        }

        private void cbIDTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbIDTipo.SelectedIndex == 2)
            {
                groupBoxVehiculo.Visible = true;
                groupBoxVehiculo.Enabled = true;
            }
            else
            {
                groupBoxVehiculo.Visible = false;
                groupBoxVehiculo.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CNEmpleado lista = new CNEmpleado();
                
                cbComuna.DataSource = lista.ObtenerComunas();
                cbComuna.SelectedIndex = Convert.ToInt32(lista);
                cbComuna.ValueMember = "IDCOMUNA";
                cbComuna.DisplayMember = "C_DESCRIPCION";
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
