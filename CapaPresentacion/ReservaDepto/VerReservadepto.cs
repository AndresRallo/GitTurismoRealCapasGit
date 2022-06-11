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
            CNReservaDpto cNReserva = new CNReservaDpto();
            dataGridView1.DataSource = cNReserva.ListALLReserva();

        }

        private void VerReserva_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
