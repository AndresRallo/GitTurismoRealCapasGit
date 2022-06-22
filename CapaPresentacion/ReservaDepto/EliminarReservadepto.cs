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
    public partial class EliminarReservadepto : Form
    {
        public EliminarReservadepto()
        {
            InitializeComponent();
        }

        private void btnEliminarDepto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CNReservaDpto reserva = new CNReservaDpto();
            if (reserva.DeleteReserva(int.Parse(txtIdReserva.Text)).Equals(true))
            {
                MessageBox.Show($"Reserva eliminada con el ID :{txtIdReserva.Text}");
            }
            else
                MessageBox.Show($"Reserva no encontrada con el ID :{txtIdReserva.Text}");
        }
    }
}
