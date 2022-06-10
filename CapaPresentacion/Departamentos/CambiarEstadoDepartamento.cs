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

namespace CapaPresentacion.Departamentos
{
    public partial class CambiarEstadoDepartamento : Form
    {
        CNDepartamento cNDepartamento = new CNDepartamento();
        CEDepartamento cEDepartamento = new CEDepartamento();

        public CambiarEstadoDepartamento()
        {
            InitializeComponent();
            LoadComboEstadoDepto();
            Listar();
            CLEAN_DGV_DEPTO();
        }

        private void CLEAN_DGV_DEPTO()
        {

            dgvDepartamentos.Columns[0].Visible = false;
            dgvDepartamentos.Columns[1].Visible = false;
            dgvDepartamentos.Columns[2].Visible = false;

            dgvDepartamentos.Columns[3].Visible = false;
            dgvDepartamentos.Columns[4].Visible = false;

            dgvDepartamentos.Columns[5].Visible = false;
            dgvDepartamentos.Columns[6].Visible = false;

        }

        private void btnListarDepartamentos_Click(object sender, EventArgs e)
        {
            try
            {

                Listar();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :(" + ex);
            }
        }

        private void Listar()
        {
            CNDepartamento lista = new CNDepartamento();
            dgvDepartamentos.DataSource = lista.ObtenerDatosJoinCaracteristicas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                CEDepartamento departamento = new CEDepartamento();
                departamento.idDepto = Convert.ToInt32(txtIdDepto.Text);
                departamento.idEstadoDepto = Convert.ToInt32(cbxEstadoDepa.SelectedValue);


                if (cNDepartamento.CAMBIAR_ESTADO_DEPARTAMENTO(departamento))
                {
                    Listar();
                    MessageBox.Show("CAMBIO DE ESTADO EXITOSO");
                }

                else
                {
                    MessageBox.Show("CAMBIO DE ESTADO NO EXITOSO");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Empleado No Eliminado " + ex);
            }
        }

        private void LoadComboEstadoDepto()
        {
            try
            {
                cbxEstadoDepa.DataSource = cNDepartamento.ObtenerEstadoDepto();
                cbxEstadoDepa.ValueMember = "IDEstDepto";
                cbxEstadoDepa.DisplayMember = "EdDescripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error combo estado depto" + ex);
            }


        }

        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartamentos.Rows.Count != 0)
            {
                GetDepartamento();
            }
        }

        private void dgvDepartamentos_KeyUp(object sender, KeyEventArgs e)
        {
            GetDepartamento();
        }


        public void GetDepartamento()
        {
            txtIdDepto.Text = Convert.ToString(dgvDepartamentos.CurrentRow.Cells["idDepto"].Value);
            cbxEstadoDepa.SelectedValue = Convert.ToString(dgvDepartamentos.CurrentRow.Cells["idEstadoDepto"].Value);
            cbxEstadoDepa.Text = Convert.ToString(dgvDepartamentos.CurrentRow.Cells["estadoDepto"].Value);
        }
    }
}
