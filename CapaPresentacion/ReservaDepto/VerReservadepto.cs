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

namespace CapaPresentacion.Reserva
{
    public partial class VerReservadepto : Form
    {
        

        public VerReservadepto()
        {
            InitializeComponent();
            listar();

        }

        public void listar()
        {
            CNReservaDpto cNReserva = new CNReservaDpto();
            dvgReservaDepto.DataSource = cNReserva.ListALLReserva();
        }
        private void VerReserva_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal("");
            menuPrincipal.Show();
            this.Close();
        }
    }
}
