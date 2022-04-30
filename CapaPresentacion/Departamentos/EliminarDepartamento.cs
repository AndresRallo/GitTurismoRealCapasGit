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
    public partial class EliminarDepartamento : Form
    {
        CNDepartamento cNDepartamento = new CNDepartamento();
        CEDepartamento cEDepartamento = new CEDepartamento();
      
        public EliminarDepartamento()
        {
            InitializeComponent();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CEDepartamento departamento = new CEDepartamento();
                departamento.idDepto = Convert.ToInt32(txtIDDepartamento.Text);
                cNDepartamento.EliminarDepartamento(departamento);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se eliminó el departamento :(" + ex);
            }
        }
    }
}
