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
using CryptSharp;

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
            LoadComboTipoEmpleado();
            LoadComboEstadoEmpleado();
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
                empleado.EM_RUT = txtRut.Text;
                empleado.EM_DV = txtDV.Text;
                empleado.EM_NOMBRE = txtNom.Text;
                empleado.EM_APATERNO = txtAPaterno.Text;
                empleado.EM_AMATERNO = txtAMaterno.Text;
                empleado.EM_EMAIL = txtEmail.Text;
                string ePass = Encrypt.GetSHA256(txtContrasenia.Text);

                empleado.EM_CONTRASEÑA = ePass;
                empleado.IDEMPRESA = Convert.ToInt32(txtIDEmpresa.Text);
                empleado.IDTIPOEMPLEADO = Convert.ToInt32(cbIDTipo.SelectedValue);
                empleado.IDESTADO = Convert.ToInt32(cbESTADO.SelectedValue);
                
                CEDireccion direccion = new CEDireccion();
                direccion.de_direccion = txtDireccion.Text;
                direccion.de_numero = txtNumDireccion.Text;
                direccion.id_comuna = Convert.ToInt32(cbComuna.SelectedValue);
                empleado.direccion = direccion;

              /*  CERegion region = new CERegion();
                region.RE_DESCRIPCION = Convert.ToString(cbRegion.SelectedIndex);
                empleado.region = region;

                CEComuna comuna = new CEComuna();
                comuna.c_descripcion = Convert.ToString(cbComuna.SelectedIndex);
                empleado.comuna = comuna; */

                if (cbIDTipo.Text == "CHÓFER")
                {

                    CEVehiculo vehiculo = new CEVehiculo();
                    vehiculo.marca_ve = txtMarcaVe.Text;
                    vehiculo.patente_ve = txtPatenteVe.Text;
                    vehiculo.anio_ve = Convert.ToInt32(txtAnioVe.Text);
                    //cNEmpleado.CrearVehiculo(vehiculo);
                    empleado.vehiculo = vehiculo;
                }
                else
                {
                    CEVehiculo vehiculo = new CEVehiculo();
                    vehiculo.marca_ve = string.Empty;
                    vehiculo.patente_ve = string.Empty;
                    vehiculo.anio_ve = 0;
                    //cNEmpleado.CrearVehiculo(vehiculo);
                    empleado.vehiculo = vehiculo;
                }

                if(cNEmpleado.CrearEmpleado(empleado))
                    MessageBox.Show("Empleado agregado");
                else
                    MessageBox.Show("Empleado no agregado");


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
            
            if(cbIDTipo.Text == "CHÓFER")
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

        private void LoadComboTipoEmpleado()
        {
            try
            {
                cbIDTipo.DataSource = cNEmpleado.ObtenerTipoEmpleado();
                cbIDTipo.ValueMember = "IDTIPOUSUARIO";
                cbIDTipo.DisplayMember = "TP_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo tipo empleado" + ex);
            }
        }

        private void LoadComboEstadoEmpleado()
        {
            try
            {
                cbESTADO.DataSource = cNEmpleado.ObtenerEstado();
                cbESTADO.ValueMember = "IDESTADO";
                cbESTADO.DisplayMember = "ES_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado empleado" + ex);
            }
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

        private void cbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
