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

namespace CapaPresentacion.Servicios
{
    public partial class ListService : Form
    {
        public ListService()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {
            CNService cNService = new CNService();
            gridServicios.DataSource = cNService.ListALLService();
        }
        private void gridServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal("");
            menuPrincipal.Show();
            this.Close();
        }
    }
}
