using CapaEntidad;
using CapaNegocio;
using CapaNegocio.Library;
using CryptSharp;
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

            LoadComboRegion();
            LoadComboTipoEmpleado();
            LoadComboEstadoEmpleado();

            CNEmpleado lista = new CNEmpleado();
            dataGridViewEmpleados.DataSource = lista.ObtenerEmpleados();
            //cleanDGVEmpleados();
        }

        //private void cleanDGVEmpleados()
        //{
        //    dataGridViewEmpleados.Columns["direccion"].Visible = false;
        //    dataGridViewEmpleados.Columns["vehiculo"].Visible = false;
        //    dataGridViewEmpleados.Columns["region"].Visible = false;
        //    dataGridViewEmpleados.Columns["comuna"].Visible = false;
        //    dataGridViewEmpleados.Columns["tipoempleado"].Visible = false;
        //    dataGridViewEmpleados.Columns["estado"].Visible = false;
        //}
        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNEmpleado.PruebaOracle();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CEEmpleado empleado = new CEEmpleado();
                CEDireccion direccion = new CEDireccion();
                empleado.IDEMPLEADO = Convert.ToInt32(txtIDEmpleado.Text);
                empleado.IDDIRECCION = Convert.ToInt32(txtIDDireccion.Text);

                empleado.EM_NOMBRE = txtNOMBRE.Text;
                empleado.EM_APATERNO = txtAPATERNO.Text;
                empleado.EM_AMATERNO = txtAMATERNO.Text;
                empleado.EM_CONTRASEÑA = txtPW.Text;
                empleado.IDTIPOEMPLEADO = Convert.ToInt32(cbIDTipo.SelectedValue);
                empleado.IDESTADO = Convert.ToInt32(cbESTADO.SelectedValue);


                direccion.de_direccion = txtDIRECCION.Text;
                direccion.de_numero = txtNUM_DIRECCION.Text;
                direccion.id_comuna = Convert.ToInt32(cbComuna.SelectedValue);
                empleado.direccion = direccion;

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



                if (cNEmpleado.EditarEmpleado(empleado))
                    MessageBox.Show("Empleado editado");
                else
                    MessageBox.Show("Empleado no editado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Editato" + ex);
            }


        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxVehiculo_Enter(object sender, EventArgs e)
        {

        }

        private void cbIDTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDTipo.Text == "CHÓFER")
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

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getEMPLEADOS()
        {
            try
            {
                txtIDEmpleado.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["IDEMPLEADO"].Value);
                txtIDDireccion.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["iDDIRECCION"].Value);
                txtNOMBRE.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["eMNOMBRE"].Value);
                txtAPATERNO.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["eMAPATERNO"].Value);
                txtAMATERNO.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["eMAMATERNO"].Value);
                txtDIRECCION.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["de_direccion"].Value);
                txtNUM_DIRECCION.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["de_numero"].Value);
                cbIDTipo.SelectedValue = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["iDTIPOEMPLEADO"].Value);
                cbIDTipo.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["TP_DESCRIPCION"].Value);
                cbESTADO.SelectedValue = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["iDESTADO"].Value);
                cbESTADO.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["ES_DESCRIPCION"].Value);
                cbRegion.SelectedValue = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["iDREGION"].Value);
                cbRegion.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["rEDESCRIPCION"].Value);
                cbComuna.SelectedValue = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["idcomuna"].Value);
                cbComuna.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["cdescripcion"].Value);


                if (cbIDTipo.Text == "CHÓFER")
                {
                    txtMarcaVe.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["VE_MARCA"].Value);
                    txtPatenteVe.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["VE_PATENTE"].Value);
                    txtAnioVe.Text = Convert.ToString(dataGridViewEmpleados.CurrentRow.Cells["VE_ANIO"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible mostrar la informacion del empleado");
            }
            
        }

        private void dataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleados.Rows.Count != 0)
            {
                getEMPLEADOS();
            }
        }

        private void dataGridViewEmpleados_KeyUp(object sender, KeyEventArgs e)
        {
            getEMPLEADOS();
        }
    }
}
