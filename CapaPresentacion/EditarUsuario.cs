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
    public partial class EditarUsuario : Form
    {
        CNUsuario cNUsuario = new CNUsuario();
        public EditarUsuario()
        {
            InitializeComponent();

            LoadComboEstadoEmpleado();

            CNUsuario lista = new CNUsuario();
            dgvUSER.DataSource = lista.ObtenerDatos();
            //dgvUSER.Columns["IDTIPOUSUARIO"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CEUsuario usuario = new CEUsuario();
                usuario.IDUSUARIO = Convert.ToInt32(txtIDUsuario.Text);
                
                usuario.US_NOMBRE = txtNom.Text;
                usuario.US_APATERNO = txtAPaterno.Text;
                usuario.US_AMATERNO = txtAMaterno.Text;
                
                usuario.US_CONTRASEÑA = txtContrasenia.Text;
                usuario.IDESTADO = Convert.ToInt32(cbESTADO.SelectedValue);


                if (cNUsuario.EditarUsuario(usuario))
                    MessageBox.Show("Usuario editado");
                else
                    MessageBox.Show("Usuario no editado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuadio No Editado"+ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mantenedorUsuario = new MantenedorUsuario();
            mantenedorUsuario.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                CNUsuario lista = new CNUsuario();
                dgvUSER.DataSource = lista.ObtenerDatos();


            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex);
            } 
        }
        private void LoadComboEstadoEmpleado()
        {
            try
            {
                cbESTADO.DataSource = cNUsuario.ObtenerEstado();
                cbESTADO.ValueMember = "IDESTADO";
                cbESTADO.DisplayMember = "ES_DESCRIPCION";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado empleado" + ex);
            }
        }
        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            cNUsuario.PruebaOracle();
        }

        private void dgvUSER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUSER.Rows.Count != 0)
            {
                getUSER();
            }
        }

        private void getUSER()
        {
            txtIDUsuario.Text = Convert.ToString(dgvUSER.CurrentRow.Cells["iDUSUARIODataGridViewTextBoxColumn"].Value);
            txtNom.Text = Convert.ToString(dgvUSER.CurrentRow.Cells["uSNOMBREDataGridViewTextBoxColumn"].Value);
            txtAPaterno.Text = Convert.ToString(dgvUSER.CurrentRow.Cells["uSAPATERNODataGridViewTextBoxColumn"].Value);
            txtAMaterno.Text = Convert.ToString(dgvUSER.CurrentRow.Cells["uSAMATERNODataGridViewTextBoxColumn"].Value);
            cbESTADO.SelectedValue = Convert.ToString(dgvUSER.CurrentRow.Cells["iDESTADODataGridViewTextBoxColumn"].Value);
            cbESTADO.Text = Convert.ToString(dgvUSER.CurrentRow.Cells["ES_DESCRIPCION"].Value);

        }

        private void dgvUSER_KeyUp(object sender, KeyEventArgs e)
        {
            getUSER();
        }
    }
}
