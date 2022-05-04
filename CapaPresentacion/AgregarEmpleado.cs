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
using CapaNegocio.Library;

namespace CapaPresentacion
{
    public partial class AgregarEmpleado : Form
    {
        Librarys librarys = new Librarys();
        CNEmpleado cNEmpleado = new CNEmpleado();
        
        
        public AgregarEmpleado()
        {
            InitializeComponent();


            LoadComboRegion();
            
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
                string ePass = Encrypt.GetSHA256(txtContrasenia.Text);

                empleado.em_contrasena = ePass;
                empleado.idEmpresa = Convert.ToInt32(txtIDEmpresa.Text);
                empleado.idTipoEmleado = Convert.ToInt32(cbIDTipo.SelectedIndex);
                empleado.idEstado = Convert.ToInt32(txtIDEstado.Text);
                empleado.idDireccion = Convert.ToInt32(txtDireccion.Text);
                if (cbIDTipo.SelectedIndex == 3)
                {

                    CEVehiculo vehiculo = new CEVehiculo();
                    vehiculo.marca_ve = txtMarcaVe.Text;
                    vehiculo.patente_ve = txtPatenteVe.Text;
                    vehiculo.anio_ve = Convert.ToInt32(txtAnioVe.Text);
                    //cNEmpleado.CrearVehiculo(vehiculo);
                    empleado.vehiculo = vehiculo;
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
                txtMarcaVe.Clear();
                txtPatenteVe.Clear();
                txtAnioVe.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadComboRegion()
        {
            try
            {
                cbRegion.DataSource = cNEmpleado.ObtenerRegion();
                cbRegion.ValueMember = "IDREGION";
                cbRegion.DisplayMember = "RE_DESCRIPCION";

                if (cbRegion.Items.Count != 0)
                {
                    int idregion = Convert.ToInt32(cbRegion.SelectedValue);
                    cbComuna.DataSource = null;
                    cbComuna.Items.Clear();
                    LoadComboComuna(idregion);
                    
                }
              /*  else
                {
                    cbComuna.DataSource = null;
                    
                } */
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }
            
            
        }

        private void LoadComboComuna(int idregion)
        {
            try
            {
                cbComuna.DataSource = cNEmpleado.ObtenerComunas(idregion);
                cbComuna.ValueMember = "IDCOMUNA";
                cbComuna.DisplayMember = "C_DESCRIPCION";
                if (cbRegion.Items.Count != 0)
                {
                    int idcomuna = Convert.ToInt32(cbComuna.SelectedValue);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex); 
            }
            
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                cbComuna.DataSource = cNEmpleado.ObtenerComunas();
                cbComuna.ValueMember = "IDCOMUNA";
                cbComuna.DisplayMember = "C_DESCRIPCION";

            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }*/

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                int regionid = cbRegion.SelectedIndex;

                LoadComboComuna(regionid);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            }

        }
    }
}
