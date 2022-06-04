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
            dataGridViewDepartamentos.DataSource = lista.ObtenerDatos();
        }

        private void CLEAN_DGV_DEPTO()
        {
            dataGridViewDepartamentos.Columns["mantencion"].Visible = false;
            dataGridViewDepartamentos.Columns["adjunto"].Visible = false;
            dataGridViewDepartamentos.Columns["direccion"].Visible = false;
            dataGridViewDepartamentos.Columns["carateristicasDepartamento"].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Departamentos.MantDepartamentos mantenedorDepartamento = new MantDepartamentos();
            mantenedorDepartamento.Show();
            this.Close();
        }
    }
}
