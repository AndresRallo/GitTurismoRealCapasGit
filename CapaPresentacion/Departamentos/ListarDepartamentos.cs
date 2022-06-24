using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Departamentos
{
    public partial class ListarDepartamentos : Form
    {


        public ListarDepartamentos()
        {
            InitializeComponent();
            Lista();
            CLEAN_DGV_DEPTO();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Lista();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Lista()
        {
            CNDepartamento lista = new CNDepartamento();
            dgvDepartamentos.DataSource = lista.ObtenerDatosJoinCaracteristicas();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }

        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
