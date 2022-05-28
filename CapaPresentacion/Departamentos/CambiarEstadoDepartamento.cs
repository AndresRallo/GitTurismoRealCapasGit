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
        }

        private void btnListarDepartamentos_Click(object sender, EventArgs e)
        {
            try
            {
                CNDepartamento lista = new CNDepartamento();
                dataGridViewDepartamentos.DataSource = lista.ObtenerDatos();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :(" + ex);
            }
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
                departamento.idDepto = Convert.ToInt32(txtIDepartamento.Text);
                departamento.idEstadoDepto = Convert.ToInt32(cbxEstadoDepa.SelectedValue);


                if (cNDepartamento.CAMBIAR_ESTADO_DEPARTAMENTO(departamento))
                    MessageBox.Show("CAMBIO DE ESTADO EXITOSO");
                else
                    MessageBox.Show("CAMBIO DE ESTADO NO EXITOSO");
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

    }
}
