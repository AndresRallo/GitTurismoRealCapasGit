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

namespace CapaPresentacion.Servicios
{
    public partial class DeleteService : Form
    {
        public DeleteService()
        {
            InitializeComponent();
            btnEliminarResServicio.Visible = true;
        }

        private void btnEliminarResServicio_Click(object sender, EventArgs e)
        {
            CEService service = new CEService();
            service.IdService= int.Parse(txtIdServicio.Text);
            CNService nService = new CNService();
            if (nService.DeleteService(service))
                MessageBox.Show("Servicio eliminado");
            else
                MessageBox.Show("Servicio no eliminado");

        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        private void button1_Click(object sender, EventArgs e)
        {
            string idService = txtIdServicio.Text;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal("");
            menuPrincipal.Show();
            this.Close();
        }
    }
}
